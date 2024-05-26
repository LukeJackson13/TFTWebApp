using System.Globalization;
using System.Text.RegularExpressions;
using TFTWebApp.Core.Models;

// This code parses the description and replace the @ tags in the description with the correct values from the champion variables

public static class AbilityDescriptionParser
{
    public static void ParseAbility(Champion champion)
    {
        //making adjustments to the variable names which are incorrectly matching to the wrong atTags during the Levenshtein distance calculations
        foreach (var variable in champion.Ability.Variables)
        {
            if (variable.name.Contains("AD"))
            {
                variable.name = variable.name.Replace("AD", "AdditionalDamage");
            }
            if (variable.name.Contains("AP"))
            {
                variable.name = variable.name.Replace("AP", "Magic");
            }
            if (variable.name.Contains("ShieldBase"))
            {
                variable.name = variable.name.Replace("ShieldBase", "Shield");
            }
            if (variable.name.Contains("Boosted"))
            {
                variable.name = "Boosted" + variable.name.Replace("Boosted", "");
            }
            if (variable.name.Contains("HealRatio"))
            {
                variable.name = "Passive" + variable.name;
            }
            if (variable.name.Contains("AOEDamageAdditionalDamageRatio") || variable.name.Contains("BonkDamage") 
                || variable.name.Contains("StunPercentAttackDamage") || variable.name.Contains("AdditionalDamageGain") || variable.name.Contains("HealAmount"))
            {
                variable.name = "Modified" + variable.name;
            }
            if (variable.name.Contains("BladeHit") || variable.name.Contains("SpellHit"))
            {
                variable.name = "Damage" + variable.name.Replace("AdditionalDamage", "");
            }

            string[] removeTerms = { "Target", "APScaling", "ArrowsPerCast" };
            foreach (string term in removeTerms)
            {
                if (variable.name.Contains(term))
                {
                    variable.name = variable.name.Replace(term, "");
                }
            }
        }

        var abilityDescription = Regex.Replace(champion.Ability.Description, "<[^>]*>", string.Empty);
        abilityDescription = Regex.Replace(abilityDescription, @"\([^()]*@TFTUnitProperty[^()]*\)", string.Empty);
        var atRegex = new Regex("@(.*?)@");
        var atTags = atRegex.Matches(abilityDescription).Select(x => x.ToString().Replace("@", "")).ToList();
        var variables = champion.Ability.Variables.Select(x => x.name).ToList();

        List<Similarity> mappings = [];

        while (atTags.Count != 0)
        {
            List<List<Similarity>> comparisons = [];

            for (var i = 0; i < variables.Count; i++)
            {
                comparisons.Add([]);

                foreach (var tag in atTags.ToList())
                {
                    int count = atTags.Count(t => t == tag);

                    if (count > 1)
                    {
                        atTags.Remove(tag);
                    }
                }

                foreach (var tag in atTags)
                {
                    comparisons[i].Add(new Similarity
                    {
                        AtSign = tag,
                        Variable = variables[i],
                        Percentage = tag.CalculateSimilarity(variables[i])
                    });
                }
            }

            foreach (var variable in variables)
            {
                var comparisonsForThisVariable = comparisons.Single(x => x.First().Variable == variable);
                var bestMatch = comparisonsForThisVariable.MaxBy(x => x.Percentage);

                var currentMapping = mappings.SingleOrDefault(x => x.AtSign == bestMatch!.AtSign);
                if (currentMapping is null)
                {
                    mappings.Add(bestMatch!);

                    atTags.Remove(bestMatch!.AtSign);
                }
                else
                {
                    if (!(bestMatch!.Percentage > currentMapping.Percentage))
                        continue;

                    atTags.Add(currentMapping.AtSign);

                    currentMapping.Variable = bestMatch.Variable;
                    currentMapping.Percentage = bestMatch.Percentage;

                    atTags.Remove(bestMatch.AtSign);
                }
            }

            foreach (var mapping in mappings)
                variables.Remove(mapping.Variable!);
        }

        if (abilityDescription.Contains("&nbsp;"))
        {
            abilityDescription = abilityDescription.Replace("&nbsp;", " ");
        }

        var PrimaryDamage = new List<float>();
        foreach (var mapping in mappings)
        {
            var variableValues = champion.Ability.Variables.First(x => x.name == mapping.Variable).value;

            // If the @ sign is a percentage
            if (mapping.AtSign.Contains("100") || mapping.AtSign.Contains("AttackSpeed") || mapping.AtSign.Contains("ModifiedADGain") && !mapping.AtSign.Contains("Duration"))
            {
                for (int i = 1; i < 4; i++)
                {
                    variableValues[i] = (int)(variableValues[i] * 100);
                }
            }
            // If the @ sign relies on the prevoius calculation to calculate the 2nd value
            else if (mapping.Variable.Contains("SecondaryPercentage") || mapping.Variable.Contains("BonusPercentDamage") || mapping.Variable.Contains("TotalSpellTime"))
            {
                if (mapping.Variable.Contains("TotalSpellTime"))
                {
                    variableValues = champion.Ability.Variables.First(x => x.name == "StartingArrows").value;
                }
                for (int i = 1; i < 4; i++)
                {
                    variableValues[i] = (int)(variableValues[i] * PrimaryDamage[i]);
                }
            }
            // If the damage is a mix of scaling damage and flat damage and the Levenshtein distance has matched with the scaling damage value
            else if (mapping.Variable.Contains("BonusResistsPct") || mapping.Variable.Contains("DamageSpellHit") 
                || mapping.Variable.Contains("PercentAdditionalDamageSecondary") || mapping.Variable.Contains("FeatherRecallDamage"))
            {
                var damageValue = champion.Ability.Variables.FirstOrDefault(x => x.name.Contains("Base"));
                if (damageValue == null)
                {
                    damageValue = champion.Ability.Variables.FirstOrDefault(x => x.name.Contains("Magic"));

                }
                string scalingvalue = ExtractScalingValues(abilityDescription, mapping.AtSign);
                float scalingStatValue;
                float levelScaling;
                ExtractScalingStat(out scalingStatValue, out levelScaling, scalingvalue, champion);

                for (int i = 1; i < 4; i++)
                {
                    variableValues[i] = (int)(variableValues[i] * scalingStatValue * Math.Pow(levelScaling, i - 1)) + damageValue.value[i];
                }

            }
            // If the damage is a mix of scaling damage and flat damage and the Levenshtein distance has matched with the flat damage value
            else if (((mapping.AtSign.Contains("Total") || mapping.AtSign.Contains("Modified")) 
                && (mapping.AtSign.Contains("Damage") || mapping.AtSign.Contains("Shield"))) 
                && mapping.AtSign != "ModifiedShieldDamage" && !mapping.Variable.Contains("Percent") 
                && !mapping.Variable.Contains("Ratio") && !mapping.Variable.Contains("Feather") 
                || mapping.AtSign == "BonusHealth" || mapping.AtSign == "TotalAoEDamage")
            {
                string percentVariablename = variables.FirstOrDefault(x => x.Contains("Percent") && !x.Contains("SecondaryPercentage") 
                                                && !x.Contains("IncreasedPercent") && !x.Contains("OmnivampPercent"));
                
                if (percentVariablename == null)
                {
                    percentVariablename = variables.FirstOrDefault(x => x.Contains("Ratio"));
                    if (percentVariablename == null)
                    {
                        percentVariablename = variables.FirstOrDefault(x => x.Contains("ShieldResistPct"));
                    }
                }

                string scalingValue = ExtractScalingValues(abilityDescription, mapping.AtSign);
                float scalingStatValue;
                float levelScaling;
                ExtractScalingStat(out scalingStatValue, out levelScaling, scalingValue, champion);

                if (percentVariablename != null)
                {
                    var percentVariable = champion.Ability.Variables.FirstOrDefault(x => x.name.Contains(percentVariablename));
                    for (int i = 1; i < 4; i++)
                    {
                        variableValues[i] = (int)variableValues[i] + (int)(scalingStatValue * percentVariable.value[i] * Math.Pow(levelScaling, i - 1));
                    }
                }
                if (mapping.Variable.Contains("Damage"))
                {
                    PrimaryDamage = variableValues.ToList();
                }


            }
            // If the damage is scaling damage only
            else if (((mapping.Variable.Contains("Percent") && (mapping.Variable.Contains("Damage") 
                || mapping.Variable.Contains("HealthShield"))) || mapping.Variable.Contains("Ratio") 
                || mapping.Variable.Contains("ShieldDamage") || mapping.Variable.Contains("BladeHit") || mapping.Variable.Contains("FeatherDamage")))
            {
                string scalingValue = ExtractScalingValues(abilityDescription, mapping.AtSign);
                float scalingStatValue;
                float levelScaling;
                ExtractScalingStat(out scalingStatValue, out levelScaling, scalingValue, champion);

                for (int i = 1; i < 4; i++)
                {
                    variableValues[i] = (int)(variableValues[i] * scalingStatValue * Math.Pow(levelScaling, i - 1));
                }

            }

            var stringValues = string.Join("/", variableValues[1..4].Select(x => x.ToString(CultureInfo.InvariantCulture)));

            abilityDescription = abilityDescription.Replace($"@{mapping.AtSign}@", $"{stringValues} ");
        }

        champion.Ability.Description = abilityDescription;
    }

    static string ExtractScalingValues(string input, string tagname)
    {
        string pattern = $"@{tagname}@\\s*\\((.*?)\\)";
        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            return match.Groups[1].Value;
        }
        return "";
    }

    static void ExtractScalingStat(out float scalingStatValue, out float levelScaling, string scalingValue, Champion champion)
    {
        switch (scalingValue)
        {
            case "%i:scaleArmor%":
            case "%i:scaleArmor%%i:scaleMR%":
                scalingStatValue = (float)champion.Stats.Armor;
                levelScaling = 1.5f;
                break;
            case "%i:scaleAD%":
            case "%i:scaleAD%%i:scaleAS%":
            case "":
                scalingStatValue = (float)champion.Stats.Damage;
                levelScaling = 1.5f;
                break;
            case "%i:scaleHealth%":
            case "%i:scaleHealth%%i:scaleAP%":
            case "%i:scaleAP%%i:scaleHealth%":
                scalingStatValue = (float)champion.Stats.Hp;
                levelScaling = 1.8f;
                break;
            case "%i:scaleAP%":
                scalingStatValue = 0.0f;
                levelScaling = 1.5f;
                break;
            default:
                scalingStatValue = (float)champion.Stats.Damage;
                levelScaling = 1.5f;
                break;
        }
    }
}