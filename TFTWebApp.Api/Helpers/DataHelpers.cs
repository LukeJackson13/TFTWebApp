using TFTWebApp.Core.Models;

namespace TFTWebApp.Api.Helper
{
    public static class DataHelpers
    {
        public static Ability ToAbility(this Champion5 jsonChampion)
        {
            return new Ability()
            {
                Name = jsonChampion.ability.name,
                Description = jsonChampion.ability.desc,
                Icon = jsonChampion.ability.icon,
                Variables = jsonChampion.ability.variables.Select(x => new Variables {
                    name = x.name,
                    value = x.value
                }).ToList()
               
            };
        }

        public static Stats ToStats(this Champion5 jsonChampion)
        {
            return new Stats()
            {
                Armor = jsonChampion.stats.armor,
                AttackSpeed = jsonChampion.stats.attackSpeed,
                CritChance = jsonChampion.stats.critChance,
                CritMultiplier = jsonChampion.stats.critMultiplier,
                Damage = jsonChampion.stats.damage,
                Hp = jsonChampion.stats.hp,
                InitialMana = jsonChampion.stats.initialMana,
                MagicResist = jsonChampion.stats.magicResist,
                Mana = jsonChampion.stats.mana,
                Range = jsonChampion.stats.range
            };
        }

        public static Champion ToChampion(this Champion5 jsonChampion)
        {
            return new Champion()
            {
                Name = jsonChampion.name,
                Ability = jsonChampion.ToAbility(),
                Stats = jsonChampion.ToStats(),
                ApiName = jsonChampion.apiName,
                CharacterName = jsonChampion.characterName,
                Cost = jsonChampion.cost,
                Icon = jsonChampion.icon,
                SquareIcon = jsonChampion.squareIcon,
                TileIcon = jsonChampion.tileIcon,
                Traits = jsonChampion.traits.Select(x => new Trait
                {
                    Name = x,
                    Description = string.Empty

                }).ToList()
            };
        }

        public static TraitBreakpoint ToTraitBreakpoint(this Trait5 jsonTrait)
        {
            return new TraitBreakpoint()
            {
                Name = jsonTrait.name,
                ApiName = jsonTrait.apiName,
                Icon = jsonTrait.icon,
                Description = jsonTrait.desc,
                Effects = jsonTrait.effects.Select(effect => effect.ToEffects()).ToArray()

            };
        }

        public static Effects ToEffects(this Effect5 effectTrait)
        {
            return new Effects()
            {
                MaxUnits = effectTrait.maxUnits,
                MinUnits = effectTrait.minUnits,
                Style = effectTrait.style,
                TraitVariables = effectTrait.variables
            };
        }

        public static Item ToItems(this Item1 jsonitem)
        {
            return new Item()
            {
                Name = jsonitem.name,
                ApiName = jsonitem.apiName,
                AssociatedTraits = jsonitem.associatedTraits,
                Composition = jsonitem.composition,
                Description = jsonitem.desc,
                From = jsonitem.from,
                Icon = jsonitem.icon,
                Id = jsonitem.id,
                IncompatibleTraits = jsonitem.incompatibleTraits,
                Unique = jsonitem.unique,
                Effects = jsonitem.effects
            };
        }
    }
}
