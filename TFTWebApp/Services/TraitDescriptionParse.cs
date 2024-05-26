using Microsoft.Extensions.Primitives;
using System.Text.RegularExpressions;
using TFTWebApp.Core.Models;

// Parses the trait description replacing the @ tags with the values form the variables data

namespace TFTWebApp.Services
{
    public class TraitDescriptionParse
    {
        public static void ParseTrait(TraitBreakpoint trait)
        {
            var traitDescription = Regex.Replace(trait.Description, "<[^>]*>", string.Empty);
            traitDescription = Regex.Replace(traitDescription, @"@TFTUnitProperty.*?@", string.Empty);
            var atRegex = new Regex("@(.*?)@");
            var atTags = atRegex.Matches(traitDescription).Select(x => x.ToString().Replace("@", "")).ToList();

            if (traitDescription.Contains("&nbsp;"))
            {
                traitDescription = traitDescription.Replace("&nbsp;", " ");
            }

            foreach (var atTag in atTags)
            {
                string stringValues = "";
                int multiplier = 1;
                var currentTag = atTag;

                if (atTag == "MinUnits")
                {
                    foreach (var effect in trait.Effects)
                    {
                        stringValues += effect.MinUnits.ToString() + "/";
                    }
                }
                else
                {
                    if (atTag.Contains("100"))
                    {
                        multiplier = 100;
                        currentTag = currentTag.Replace("*100", "");
                    }
                    if (atTag.Contains("Increased"))
                    {
                        currentTag = currentTag.Replace("Increased", "");
                    }
                    if (atTag.Contains("BonusHexRange"))
                    {
                        currentTag = currentTag.Replace("Bonus", "");
                    }

                    foreach (var effect in trait.Effects)
                    {
                        var property = effect.TraitVariables.GetType().GetProperty(currentTag);
                        if (property != null)
                        {
                            object propertyValue = property.GetValue(effect.TraitVariables);

                            float value = propertyValue?.ToString() == "null" ? 0 : float.Parse(propertyValue.ToString());

                            stringValues += ((int)(value * multiplier)).ToString() + "/";
                        }

                    }
                }


                stringValues = stringValues.Substring(0, stringValues.Length - 1);

                traitDescription = traitDescription.Replace($"@{atTag}@", $"{stringValues}"); ;
            }

            trait.Description = traitDescription;

        }
    }
}
