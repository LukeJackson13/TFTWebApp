﻿using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{

    public class TFTData
    {
        public Item1[] items { get; set; }
        public Setdata[] setData { get; set; }
        public Sets sets { get; set; }
    }

    public class Sets
    {
        //public _1 _1 { get; set; }
        public _3 _3 { get; set; }
        public _9 _9 { get; set; }
        public _10 _10 { get; set; }

        [JsonPropertyName("_11")]
        public Set11 Set11 { get; set; }
    }

    //public class _1
    //{
    //    public Champion[] champions { get; set; }
    //    public string name { get; set; }
    //    public Trait[] traits { get; set; }
    //}

    public class Variables : BaseEntity
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    //public class Trait
    //{
    //    public string apiName { get; set; }
    //    public string desc { get; set; }
    //    public Effect[] effects { get; set; }
    //    public string icon { get; set; }
    //    public string name { get; set; }
    //}

    public class Effect : BaseEntity
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public TraitVariablesJson traitVariables { get; set; }
    }

    public class TraitVariablesJson
    {
        public float AttackSpeedPercent { get; set; }
        public float MaxStacks { get; set; }
        public float ExtraTargetsHit { get; set; }
        public float ProcPercent { get; set; }
        public float f768e185 { get; set; }
        public float MissPercent { get; set; }
        public float StunDuration { get; set; }
        public float AttackSpeedReductionPercent { get; set; }
        public float DebuffDuration { get; set; }
        public float HexSize { get; set; }
        public float a004f927 { get; set; }
        public float ExtraAttacks { get; set; }
        public float ProcChance { get; set; }
        public float AttackDamage { get; set; }
        public float DamageReductionPercent { get; set; }
        public float AP { get; set; }
        public float BlockAmount { get; set; }
        public float BonusHealth { get; set; }
        public float DamageMultiplier { get; set; }
        public float HPPercent { get; set; }
        public float ADValue { get; set; }
        public float APValue { get; set; }
        public float AttackSpeed { get; set; }
        public float BuffDuration { get; set; }
        public float DelayBetweenBuffs { get; set; }
        public float InitialDelay { get; set; }
        public float ManaDrainBurn { get; set; }
        public float ManaDrainDrain { get; set; }
        public float ManaDrainProcChance { get; set; }
        public float CritAmpPercent { get; set; }
        public float CritChanceAmpPercent { get; set; }
    }

    public class _3
    {
        public Champion1[] champions { get; set; }
        public string name { get; set; }
        public Trait1[] traits { get; set; }
    }

    public class Champion1
    {
        public Ability1 ability { get; set; }
        public string apiName { get; set; }
        public string characterName { get; set; }
        public int cost { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string squareIcon { get; set; }
        public Stats1 stats { get; set; }
        public string tileIcon { get; set; }
        public string[] traits { get; set; }
    }

    public class Ability1
    {
        public string desc { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public Variable1[] variables { get; set; }
    }

    public class Variable1
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    public class Stats1
    {
        public float? armor { get; set; }
        public float? attackSpeed { get; set; }
        public float? critChance { get; set; }
        public float critMultiplier { get; set; }
        public float? damage { get; set; }
        public float? hp { get; set; }
        public float initialMana { get; set; }
        public float? magicResist { get; set; }
        public float mana { get; set; }
        public float range { get; set; }
    }

    public class Trait1
    {
        public string apiName { get; set; }
        public string desc { get; set; }
        public Effect1[] effects { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public class Effect1
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public Variables1 variables { get; set; }
    }

    public class Variables1
    {
        public float PercentDamageIncrease { get; set; }
        public float HealPercent { get; set; }
        public float MagicResist { get; set; }
        public float DamageAmp { get; set; }
        public float ShieldAmount { get; set; }
        public float ShieldDuration { get; set; }
        public float CoinDropChance { get; set; }
        public object ItemDropChance { get; set; }
        public float ADandSP { get; set; }
        public float HealOrDamageAmount { get; set; }
        public float ManaPerSecond { get; set; }
        public float ManaCostReduction { get; set; }
        public float ExtraAttacks { get; set; }
        public float ProcChance { get; set; }
        public float Frequency { get; set; }
        public float PercentAttackSpeed { get; set; }
        public float Armor { get; set; }
        public float Duration { get; set; }
        public float ShieldPercent { get; set; }
        public float ManaRestore { get; set; }
        public float BonusHealth { get; set; }
        public float ADAmp { get; set; }
        public float HealthAmp { get; set; }
        public float AP { get; set; }
        public float PercentHealth { get; set; }
        public float EjectedPilotHealthPercent { get; set; }
        public float _092d19fb { get; set; }
        public float _5dd40675 { get; set; }
        public float _952c9d9c { get; set; }
        public float d13e2b40 { get; set; }
        public string dc3931d7 { get; set; }
        public float ed41c244 { get; set; }
        public float CostIncreasePercent { get; set; }
        public float AdditionalAttacks { get; set; }
        public float StunDuration { get; set; }
        public float AttackSpeedPercent { get; set; }
        public float _650d33c0 { get; set; }
    }

    public class _9
    {
        public Champion2[] champions { get; set; }
        public string name { get; set; }
        public Trait2[] traits { get; set; }
    }

    public class Champion2
    {
        public Ability2 ability { get; set; }
        public string apiName { get; set; }
        public string characterName { get; set; }
        public int cost { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string squareIcon { get; set; }
        public Stats2 stats { get; set; }
        public string tileIcon { get; set; }
        public string[] traits { get; set; }
    }

    public class Ability2
    {
        public string desc { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public Variable2[] variables { get; set; }
    }

    public class Variable2
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    public class Stats2
    {
        public float? armor { get; set; }
        public float? attackSpeed { get; set; }
        public float? critChance { get; set; }
        public float critMultiplier { get; set; }
        public float? damage { get; set; }
        public float? hp { get; set; }
        public float initialMana { get; set; }
        public float? magicResist { get; set; }
        public float mana { get; set; }
        public float range { get; set; }
    }

    public class Trait2
    {
        public string apiName { get; set; }
        public string desc { get; set; }
        public Effect2[] effects { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public class Effect2
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public Variables2 variables { get; set; }
    }

    public class Variables2
    {
        public float EmblemBonus { get; set; }
        public float Mana { get; set; }
        public float NumberOfSpirits { get; set; }
        public float SpiritDuration { get; set; }
        public float TooltipBonus { get; set; }
        public float _18bfc1ac { get; set; }
        public float _1b8cd16a { get; set; }
        public float _27b17444 { get; set; }
        public float _3fc62f6f { get; set; }
        public float _4df03474 { get; set; }
        public float _53912082 { get; set; }
        public float _7d34708f { get; set; }
        public float b9a6ee1b { get; set; }
        public float eb0c521b { get; set; }
        public float ed124bdb { get; set; }
        public float f6b4b588 { get; set; }
        public float BonusDefenses { get; set; }
        public float NumElites { get; set; }
        public float BonusCasts { get; set; }
        public float DamageReduction { get; set; }
        public object ManaPerAuto { get; set; }
        public float BonusAP { get; set; }
        public float HealthPct { get; set; }
        public float TargetNum { get; set; }
        public float a34f32df { get; set; }
        public float Duration { get; set; }
        public float MaxDR { get; set; }
        public float MinDR { get; set; }
        public float BonusAS { get; set; }
        public float BurstDuration { get; set; }
        public float IncreasePct { get; set; }
        public float BonusArmor { get; set; }
        public float BonusMR { get; set; }
        public float BonusPercent { get; set; }
        public float _09b7d38c { get; set; }
        public float HealShieldIncrease { get; set; }
        public float BonusPercentHealth { get; set; }
        public float TeamFlatHealth { get; set; }
        public float MaxStacks { get; set; }
        public float PercentAD { get; set; }
        public object AscensionStrengthBoost { get; set; }
        public float BonusASPercent { get; set; }
        public float BonusHealthPercent { get; set; }
        public float HealthRegen { get; set; }
        public float PulsePeriod { get; set; }
        public float SecondsToAscend { get; set; }
        public float e3dc0fc2 { get; set; }
        public float AttackSpeed { get; set; }
        public float BonusHealth { get; set; }
        public float BonusOmnivamp { get; set; }
        public float RespawnTimer { get; set; }
        public object _7714a401 { get; set; }
        public float af532c9d { get; set; }
        public float AD { get; set; }
        public float AP { get; set; }
        public float BonusRatio { get; set; }
        public float Health { get; set; }
        public float BonusRange { get; set; }
        public float DamageAmp { get; set; }
        public float ShotFrequency { get; set; }
        public object BleedDuration { get; set; }
        public object BleedPct { get; set; }
        public float HealthThreshold { get; set; }
        public float HexRange { get; set; }
        public float StealthDuration { get; set; }
        public float PercentBonusMaxHealth { get; set; }
        public float PercentHealthHeal { get; set; }
        public float PercentHealthMagicDamage { get; set; }
        public float _05b87026 { get; set; }
        public object dbf68e4f { get; set; }
        public float BonusDamageBase { get; set; }
        public float Omnivamp { get; set; }
        public float ShieldDuration { get; set; }
        public float ShieldHP { get; set; }
        public float BonusAttackSpeed { get; set; }
        public float DodgeChance { get; set; }
        public float DodgeDuration { get; set; }
        public float ManaReduction { get; set; }
        public float _25ec78e1 { get; set; }
        public float c235f1f1 { get; set; }
        public float eae1472b { get; set; }
        public float PercentHealthAPPerStarLevel { get; set; }
        public float a4dcb3da { get; set; }
        public object SelfBonusMana { get; set; }
        public object TeamAP { get; set; }
        public float TeamMana { get; set; }
        public float TickRate { get; set; }
        public float DamageInstances { get; set; }
        public float ManaRegen { get; set; }
        public float MaxHealthShield { get; set; }
        public float GoldCost { get; set; }
        public float _8063e2fe { get; set; }
        public float db5e6ace { get; set; }
        public float BaseCritChance { get; set; }
        public float CritDmg { get; set; }
        public float DelayTime { get; set; }
        public float PercentHealthDamage { get; set; }
        public float ShredSunder { get; set; }
        public float _81ce23cf { get; set; }
        public float StunDuration { get; set; }
    }

    public class _10
    {
        public Champion3[] champions { get; set; }
        public string name { get; set; }
        public Trait3[] traits { get; set; }
    }

    public class Champion3
    {
        public Ability3 ability { get; set; }
        public string apiName { get; set; }
        public string characterName { get; set; }
        public int cost { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string squareIcon { get; set; }
        public Stats3 stats { get; set; }
        public string tileIcon { get; set; }
        public string[] traits { get; set; }
    }

    public class Ability3
    {
        public string desc { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public Variable3[] variables { get; set; }
    }

    public class Variable3
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    public class Stats3
    {
        public float? armor { get; set; }
        public float? attackSpeed { get; set; }
        public float? critChance { get; set; }
        public float critMultiplier { get; set; }
        public float? damage { get; set; }
        public float? hp { get; set; }
        public float initialMana { get; set; }
        public float? magicResist { get; set; }
        public float mana { get; set; }
        public float range { get; set; }
    }

    public class Trait3
    {
        public string apiName { get; set; }
        public string desc { get; set; }
        public Effect3[] effects { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public class Effect3
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public Variables3 variables { get; set; }
    }

    public class Variables3
    {
        public float BonusPercentHealth { get; set; }
        public float TeamFlatHealth { get; set; }
        public float HealthBonus { get; set; }
        public float OmnivampBonus { get; set; }
        public float AttackDamage { get; set; }
        public float NumHighScores { get; set; }
        public float _07d8a23c { get; set; }
        public float _1898a704 { get; set; }
        public float _23107b0a { get; set; }
        public float _32c611e7 { get; set; }
        public float _32f494a9 { get; set; }
        public float _3ac63386 { get; set; }
        public float _4e4bda72 { get; set; }
        public float _4ff425ef { get; set; }
        public float _57358459 { get; set; }
        public float _5bf0a783 { get; set; }
        public float _5bf63cb6 { get; set; }
        public float _711044ee { get; set; }
        public float _73092577 { get; set; }
        public float _7422b321 { get; set; }
        public float _7741f7e8 { get; set; }
        public float _83f7600e { get; set; }
        public float _849cb125 { get; set; }
        public float c876dba0 { get; set; }
        public float cb973c66 { get; set; }
        public float cb98e839 { get; set; }
        public float e291f403 { get; set; }
        public float f20af5b5 { get; set; }
        public object HeartKeepPercentage { get; set; }
        public float PercentHeartRate { get; set; }
        public float RoundCount { get; set; }
        public float RoundCount_HR { get; set; }
        public float _035b49c7 { get; set; }
        public float _0ed79bac { get; set; }
        public float _1aba31d0 { get; set; }
        public float _270aa35b { get; set; }
        public float _2f144a72 { get; set; }
        public float _3b93f5f0 { get; set; }
        public float _3d93f916 { get; set; }
        public float _3e93faa9 { get; set; }
        public float _3f93fc3c { get; set; }
        public float _4093fdcf { get; set; }
        public float _56e499e0 { get; set; }
        public float _5f254a07 { get; set; }
        public float _776acd0e { get; set; }
        public object _7e97c18b { get; set; }
        public float _877a0743 { get; set; }
        public float _989d8904 { get; set; }
        public float a0fc9505 { get; set; }
        public float a4f2dc1d { get; set; }
        public float c83c7511 { get; set; }
        public float cd492c59 { get; set; }
        public float d0ba644e { get; set; }
        public float d2e59737 { get; set; }
        public float e4b74e78 { get; set; }
        public float ef5a2d30 { get; set; }
        public float f05a2ec3 { get; set; }
        public float f45a350f { get; set; }
        public float f55a36a2 { get; set; }
        public float f65a3835 { get; set; }
        public float PercentHealthThreshold { get; set; }
        public float ShieldPercentAmount { get; set; }
        public float AssassinGoldPerKill { get; set; }
        public float NumOfKills { get; set; }
        public float RhaastPlayerHealthPerKill { get; set; }
        public float AS { get; set; }
        public float BuffDuration { get; set; }
        public float Mana { get; set; }
        public float NumOfAllies { get; set; }
        public float ADRatio { get; set; }
        public float AttackSpeed { get; set; }
        public float HealthRatio { get; set; }
        public float BonusAttackDamage { get; set; }
        public float BonusAttackSpeed { get; set; }
        public float ManaPerAttack { get; set; }
        public float _3c4f17cb { get; set; }
        public float _48d42308 { get; set; }
        public float AmountIncrease { get; set; }
        public float FighterAS { get; set; }
        public float FighterVamp { get; set; }
        public float AP { get; set; }
        public float BonusAP { get; set; }
        public float TeamwideAP { get; set; }
        public float BonusDamage { get; set; }
        public float BonusHealth { get; set; }
        public float InitialMana { get; set; }
        public float StackingMana { get; set; }
        public float BONUS_AD_AP { get; set; }
        public float BONUS_HEALTH { get; set; }
        public float FIRST_ROLL_BONUS { get; set; }
        public float _6f204280 { get; set; }
        public float _1Star { get; set; }
        public float _2Star { get; set; }
        public float _3Star { get; set; }
        public float BonusMaxHealth { get; set; }
        public object ManaPerSecond { get; set; }
        public float _158db106 { get; set; }
        public float BONUS_DAMAGE { get; set; }
        public float _744944d9 { get; set; }
        public object d1eaafe0 { get; set; }
        public float MaxStacks { get; set; }
        public float PercentAS { get; set; }
        public float TeamwideAttackSpeed { get; set; }
        public float CRIT_DAMAGE { get; set; }
        public float CRIT_PERCENT { get; set; }
        public float BaseBonus { get; set; }
        public float BonusPerSecond { get; set; }
        public float JumpDamage { get; set; }
        public float StunDuration { get; set; }
        public float StunRange { get; set; }
        public object BonusResists { get; set; }
        public float Level { get; set; }
        public float de1b2c92 { get; set; }
        public float Healing { get; set; }
        public float HexRadius { get; set; }
        public float TickRate { get; set; }
        public float _11b35e1c { get; set; }
        public float DOTPercent { get; set; }
        public float DamageDecrease { get; set; }
        public float Duration { get; set; }
        public float PercentAD { get; set; }
        public float PercentADEmpowered { get; set; }
        public float EDMstats { get; set; }
        public float _1d0f36aa { get; set; }
        public float _34753da8 { get; set; }
        public float _52707149 { get; set; }
        public float b7559eb7 { get; set; }
        public float d8f28e45 { get; set; }
        public float d9fae949 { get; set; }
        public float f40f819b { get; set; }
        public float fb62799b { get; set; }
        public float EDMtimereduction { get; set; }
        public float Attack_Speed { get; set; }
        public float Kill_Bonus { get; set; }
        public float Kill_Count { get; set; }
        public float _0082059a { get; set; }
        public float BonusArmor { get; set; }
        public float a624ed1a { get; set; }
    }

    public class Set11
    {
        public Champion4[] champions { get; set; }
        public string name { get; set; }
        public Trait4[] traits { get; set; }
    }

    public class Champion4
    {
        public Ability4 ability { get; set; }
        public string apiName { get; set; }
        public string characterName { get; set; }
        public int cost { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string squareIcon { get; set; }
        public Stats4 stats { get; set; }
        public string tileIcon { get; set; }
        public string[] traits { get; set; }
    }

    public class Ability4
    {
        public string desc { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public Variable4[] variables { get; set; }
    }

    public class Variable4
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    public class Stats4
    {
        public float? armor { get; set; }
        public float? attackSpeed { get; set; }
        public float? critChance { get; set; }
        public float critMultiplier { get; set; }
        public float? damage { get; set; }
        public float? hp { get; set; }
        public float initialMana { get; set; }
        public float? magicResist { get; set; }
        public float mana { get; set; }
        public float range { get; set; }
    }

    public class Trait4
    {
        public string apiName { get; set; }
        public string desc { get; set; }
        public Effect4[] effects { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public class Effect4
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public Variables4 variables { get; set; }
    }

    public class Variables4
    {
        public float DamagePercent { get; set; }
        public float HealingPercent { get; set; }
        public float NumInstances { get; set; }
        public float NumSpectres { get; set; }
        public float TickRate { get; set; }
        public object Heal { get; set; }
        public object WinPenalty { get; set; }
        public float _02dd7588 { get; set; }
        public float _03dd771b { get; set; }
        public float _04dd78ae { get; set; }
        public float _05dd7a41 { get; set; }
        public float _06dd7bd4 { get; set; }
        public float _07dd7d67 { get; set; }
        public float _1483b8b4 { get; set; }
        public string _15b17b97 { get; set; }
        public object _5da364e1 { get; set; }
        public object _5ec17b88 { get; set; }
        public float _7b8c990e { get; set; }
        public float ac1f138b { get; set; }
        public float _034c4dbb { get; set; }
        public float _2c6cd0ff { get; set; }
        public float _6f3d98c0 { get; set; }
        public float _73f5f8da { get; set; }
        public float _91da68d9 { get; set; }
        public float _9e4b847c { get; set; }
        public float ce0fa894 { get; set; }
        public object BleedDamage { get; set; }
        public float CritChance { get; set; }
        public float Duration { get; set; }
        public object DesireExecuteRewardPercent { get; set; }
        public float DesireExecuteThreshhold { get; set; }
        public float ShieldAmount { get; set; }
        public float DesireExecuteRewardPercentHR { get; set; }
        public float b84914bf { get; set; }
        public float AP { get; set; }
        public float HealthPerCompost { get; set; }
        public float HealthPerCompostHR { get; set; }
        public float StartingHealth { get; set; }
        public float StartingHealthHR { get; set; }
        public float APAmount { get; set; }
        public float Omnivamp { get; set; }
        public float ArcanistAbilityPower { get; set; }
        public float TeamAbilityPower { get; set; }
        public float PercentBuff { get; set; }
        public object _20436879 { get; set; }
        public float _5ff50860 { get; set; }
        public float PercentDamageToHeal { get; set; }
        public float Resists { get; set; }
        public string b11aeccf { get; set; }
        public float BaseAmountXP { get; set; }
        public float BaseDamageAmp { get; set; }
        public float DamageAmpPerLevel { get; set; }
        public float HRGold { get; set; }
        public float ca5fd6df { get; set; }
        public float HeavenlyBonus { get; set; }
        public float _13f889ae { get; set; }
        public float _19e47528 { get; set; }
        public float _26ac6bc4 { get; set; }
        public float _3c9e3624 { get; set; }
        public float _414a2beb { get; set; }
        public float _4803a4eb { get; set; }
        public float _912546f4 { get; set; }
        public float a8a84fe9 { get; set; }
        public float f82ecbac { get; set; }
        public float AS { get; set; }
        public float DR { get; set; }
        public float AttackSpeedPercent { get; set; }
        public object DamageReduction { get; set; }
        public float MaxStacks { get; set; }
        public float ASDuration { get; set; }
        public float AttackSpeedBuff { get; set; }
        public float FirstDelay { get; set; }
        public float TrueDamageHPRatio { get; set; }
        public float _81ce23cf { get; set; }
        public float StunDuration { get; set; }
        public float BonusPercentHealth { get; set; }
        public float RefreshSeconds { get; set; }
        public object SlamPercentHealth { get; set; }
        public float TeamBonusHealth { get; set; }
        public float MaxBounces { get; set; }
        public float PercentDamage { get; set; }
        public float BondIncreasePercent { get; set; }
        public float PairHPBonus { get; set; }
        public float _55f4e448 { get; set; }
        public float _89fffd48 { get; set; }
        public object f75cc2d4 { get; set; }
        public float InvokerMana { get; set; }
        public string TeamAP { get; set; }
        public float TeamMana { get; set; }
        public float CastCount { get; set; }
        public float HexRangeIncrease { get; set; }
        public float PercentDamageIncrease { get; set; }
        public object _7db0ae46 { get; set; }
        public float HealthPct { get; set; }
        public float Multiplier { get; set; }
        public float PrismaticMultiplier { get; set; }
        public string OmnivampPercent { get; set; }
        public float RevivePercent { get; set; }
        public float DRPercent { get; set; }
        public float StartOfCombatDRPercent { get; set; }
        public float BonusPercent { get; set; }
        public float Defenses { get; set; }
        public float _2af8e84f { get; set; }
        public float BonusASPerStage { get; set; }
        public float Health { get; set; }
        public float _3609554d { get; set; }
        public float _6cf32d7f { get; set; }
        public float _8f92bd7b { get; set; }
        public float a4d5374e { get; set; }
        public float b0332b0a { get; set; }
        public float b7c5b67d { get; set; }
        public float cdd2f157 { get; set; }
        public float de1b2c92 { get; set; }
    }

    public class Item1
    {
        public string apiName { get; set; }
        public string[] associatedTraits { get; set; }
        public string[] composition { get; set; }
        public string desc { get; set; }
        public Effects6 effects { get; set; }
        public object from { get; set; }
        public string icon { get; set; }
        public object id { get; set; }
        public string[] incompatibleTraits { get; set; }
        public string name { get; set; }
        public bool unique { get; set; }
    }

    public class Effects6
    {
        public float Mana { get; set; }
        public object AD { get; set; }
        public object AS { get; set; }
        public float MagicResist { get; set; }
        public float Health { get; set; }
        public float CritChance { get; set; }
        public float DodgeChance { get; set; }
        public float Armor { get; set; }
        public object AP { get; set; }
        public float AbilityPowerRatio { get; set; }
        public float AttackSpeedRatio { get; set; }
        public float HealRatio { get; set; }
        public float Threshold { get; set; }
        public float AttackSpeed { get; set; }
        public float GoldChance { get; set; }
        public float HealthThreshold { get; set; }
        public float goldgenerated { get; set; }
        public object NumItems { get; set; }
        public float a416e152 { get; set; }
        public float NumOfDummies { get; set; }
        public float NumOfItems { get; set; }
        public float PlayerCombatRounds { get; set; }
        public float InitialCost { get; set; }
        public float MaxCost { get; set; }
        public float increase { get; set; }
        public float AugmentGold { get; set; }
        public float BonusHP { get; set; }
        public float SharedHP { get; set; }
        public object NumComponents { get; set; }
        public object NumReforgers { get; set; }
        public float Experience { get; set; }
        public float BonusAP { get; set; }
        public float Rerolls { get; set; }
        public float XP { get; set; }
        public float GoldAmount { get; set; }
        public float lossxp { get; set; }
        public float winxp { get; set; }
        public object Gold { get; set; }
        public float NumLeveledUpShops { get; set; }
        public float BonusAD { get; set; }
        public float BaseAS { get; set; }
        public float IncreasePerRound { get; set; }
        public float BaseRegen { get; set; }
        public float EnhancedRegen { get; set; }
        public float Frequency { get; set; }
        public float BonusHealth { get; set; }
        public float BonusStats { get; set; }
        public float StackingResistances { get; set; }
        public float BaseBonusDamage { get; set; }
        public float BonusDamagePer3Star { get; set; }
        public float BonusAS { get; set; }
        public float StackingAS { get; set; }
        public float CritDamage { get; set; }
        public float _4218018d { get; set; }
        public float _4e5d5b1a { get; set; }
        public float _6440a596 { get; set; }
        public float _723ebcb7 { get; set; }
        public float _872f5162 { get; set; }
        public float a4ec31c7 { get; set; }
        public float dce94460 { get; set; }
        public float eea984d4 { get; set; }
        public float fbf16f33 { get; set; }
        public float fdccad91 { get; set; }
        public float MaxGold { get; set; }
        public float MinGold { get; set; }
        public float _0fb1f1e5 { get; set; }
        public float _4e351fc8 { get; set; }
        public float StackCap { get; set; }
        public float TurnLimit { get; set; }
        public float startingmana { get; set; }
        public float HealthPercent { get; set; }
        public float Delay { get; set; }
        public float Duration { get; set; }
        public float GrievousWoundsPercent { get; set; }
        public float HexRadius { get; set; }
        public float Stage2Damage { get; set; }
        public float Stage6Damage { get; set; }
        public float _999c56da { get; set; }
        public float ba1a01d7 { get; set; }
        public float d5e0f4a9 { get; set; }
        public float RangeMax { get; set; }
        public float Numberofcombats { get; set; }
        public float RefreshCost { get; set; }
        public float Tier1Rolls { get; set; }
        public float DamageRatio { get; set; }
        public float MaxBonusDamage { get; set; }
        public float MinBonusDamage { get; set; }
        public float MissingHealthPercent { get; set; }
        public float CombatNum { get; set; }
        public float StartingBonusMana { get; set; }
        public float TakedownBonusMana { get; set; }
        public float ac78e3c6 { get; set; }
        public float DamageReduction { get; set; }
        public float DamageAmp { get; set; }
        public float AttackSpeedBoost { get; set; }
        public float AttackSpeedDuration { get; set; }
        public float CombatDuration { get; set; }
        public float Shield { get; set; }
        public float MaxShield { get; set; }
        public float MinShield { get; set; }
        public float _54b4ed36 { get; set; }
        public float ShieldRatio { get; set; }
        public float BonusResistances { get; set; }
        public float BaseDamage { get; set; }
        public float BonusDamage { get; set; }
        public float ManaThreshold { get; set; }
        public float BonusDamageDealt { get; set; }
        public float DamageCap { get; set; }
        public float GoldThreshold { get; set; }
        public float ManaReduction { get; set; }
        public float PercentShare { get; set; }
        public float UnitsPerGold { get; set; }
        public float ArmorAmount { get; set; }
        public float MRAmount { get; set; }
        public float RoundsPerRefresh { get; set; }
        public float BaseExecuteThreshold { get; set; }
        public float StackingExecuteThreshold { get; set; }
        public float Healing { get; set; }
        public float HPPercent { get; set; }
        public float HealthPerStack { get; set; }
        public float StartingHealth { get; set; }
        public float secondspertrigger { get; set; }
        public float AttackCadence { get; set; }
        public float MaxTurretDamage { get; set; }
        public float MinTurretDamage { get; set; }
        public float TooltipTimer { get; set; }
        public float CritConversion { get; set; }
        public float MaxAP { get; set; }
        public float StackingAP { get; set; }
        public float ProcChance { get; set; }
        public float PlayerCombatNum { get; set; }
        public float ArmoryChoiceCount { get; set; }
        public float BaselineOmnivamp { get; set; }
        public float RogueOmnivamp { get; set; }
        public float NumTraitsPerExp { get; set; }
        public float HealthRatio { get; set; }
        public float b93c067c { get; set; }
        public float RollCount { get; set; }
        public float RerollAmount { get; set; }
        public float UnitCost { get; set; }
        public float GoldAmount1 { get; set; }
        public float GoldAmount2 { get; set; }
        public float GoldAmount3 { get; set; }
        public float AttackSpeedIncreaseRatio { get; set; }
        public float OverchargeAttackSpeedIncreaseRatio { get; set; }
        public float OverchargePercentMaxHealthHeal { get; set; }
        public float PercentMaxHealthHeal { get; set; }
        public float BonusPercentDamage { get; set; }
        public float BonusPercentDamageReduction { get; set; }
        public float OverchargePercentMaxHPHeal { get; set; }
        public float PercentMaxHPHeal { get; set; }
        public float TimeToHeal { get; set; }
        public float c58d94cc { get; set; }
        public float ef19dd54 { get; set; }
        public float IncreasePercent { get; set; }
        public float PercentAD1 { get; set; }
        public float PercentAD2 { get; set; }
        public float PercentAD3 { get; set; }
        public float BeamAmount1 { get; set; }
        public float BeamAmount2 { get; set; }
        public float BeamAmount3 { get; set; }
        public float DamageAmp1 { get; set; }
        public float DamageAmp2 { get; set; }
        public float DamageAmp3 { get; set; }
        public float ManaShare { get; set; }
        public float BaseExplosionRadius { get; set; }
        public float BonusMaxHealthPercent { get; set; }
        public float ExplosionMaxHealthPercent { get; set; }
        public float OverchargeExplosionRadius { get; set; }
        public float _291091d7 { get; set; }
        public float BurnPct1 { get; set; }
        public float BurnPct2 { get; set; }
        public float BurnPct3 { get; set; }
        public float Damage1 { get; set; }
        public float Damage2 { get; set; }
        public float Damage3 { get; set; }
        public float WoundsPct { get; set; }
        public float ApplicationDuration { get; set; }
        public float DamageIncreasePercent { get; set; }
        public float OverchargePlagueDuration { get; set; }
        public float OverchargePlagueMaxHealthDPS { get; set; }
        public float PlagueDuration { get; set; }
        public float RepairTime { get; set; }
        public float Resists1 { get; set; }
        public float Resists2 { get; set; }
        public float Resists3 { get; set; }
        public float BonusOmnivamp { get; set; }
        public float OverchargeEffectIncreaseRatio { get; set; }
        public float ChanceToTriggerAttack { get; set; }
        public float NumAdditionalAttacks { get; set; }
        public float OverchargePercentBonusDamage { get; set; }
        public float ShredPercent1 { get; set; }
        public float ShredPercent2 { get; set; }
        public float ShredPercent3 { get; set; }
        public float BonusAttackSpeed { get; set; }
        public float EggTurns { get; set; }
        public string ecb4463d { get; set; }
        public float NumRounds { get; set; }
        public float NumUnits { get; set; }
        public float HealthPerUnit { get; set; }
        public float Tier { get; set; }
        public float GoldPerTurn { get; set; }
        public float GoldThreshhold { get; set; }
        public object Heal { get; set; }
        public object Cost { get; set; }
        public float InterestCap { get; set; }
        public object HP { get; set; }
        public float effectincrease { get; set; }
        public float MagicDamage1 { get; set; }
        public float MagicDamage2 { get; set; }
        public float MagicDamage3 { get; set; }
        public float MagicDamage4 { get; set; }
        public float _26a9a9b1 { get; set; }
        public float MaxHealthPerSecond { get; set; }
        public float NumDummies { get; set; }
        public float Stun { get; set; }
        public float f2863276 { get; set; }
        public float NumGloves { get; set; }
        public float MR { get; set; }
        public float Reforgers { get; set; }
        public float _4f839cbf { get; set; }
        public float MoveSpeed { get; set; }
        public float TooltipSizeScale { get; set; }
        public float _858a62b6 { get; set; }
        public float NumSpatulas { get; set; }
        public float EnemyGold { get; set; }
        public float YourGold { get; set; }
        public float Omnivamp { get; set; }
        public float Resists { get; set; }
        public float InitialGold { get; set; }
        public float ChampionTier { get; set; }
        public float NumCopies { get; set; }
        public float BonusGoldTOOLTIPONLY { get; set; }
        public float FreeRerolls { get; set; }
        public float _7da8363b { get; set; }
        public float BottomHalf { get; set; }
        public float LoserBoost { get; set; }
        public float UpperHalf { get; set; }
        public float WinningStatBoost { get; set; }
        public float NumDice { get; set; }
        public float BaseHP { get; set; }
        public float BonusHPPerMissingHealth { get; set; }
        public float NumOfEmblems { get; set; }
        public float NumTakedowns { get; set; }
        public float BenchSlots { get; set; }
        public float EXP { get; set; }
        public float NumTomes { get; set; }
        public float ExpBonus { get; set; }
        public float LevelReq { get; set; }
        public float DamageReductionPercent { get; set; }
        public float RequiredHealth { get; set; }
        public float Interval { get; set; }
        public float ManaRegen { get; set; }
        public float Units { get; set; }
        public float roundsofbonusitems { get; set; }
        public float MaxStacks { get; set; }
        public float Missinghealth { get; set; }
        public float Stats { get; set; }
        public float _379448fe { get; set; }
        public float NumChamps { get; set; }
        public float Damage4 { get; set; }
        public float ICD { get; set; }
        public float ManaGain { get; set; }
        public float Damage { get; set; }
        public float LootDropChance { get; set; }
        public float ac7ef35a { get; set; }
        public float TotalBurnPercent { get; set; }
        public float ShredPercentage { get; set; }
        public float SunderPercentage { get; set; }
        public float ManaRestore { get; set; }
        public float ShieldAmount1 { get; set; }
        public float ShieldAmount2 { get; set; }
        public float ShieldAmount3 { get; set; }
        public float ShieldAmount4 { get; set; }
        public float RoundsToSkip { get; set; }
        public float HealthCost { get; set; }
        public float anvils { get; set; }
        public object XPNow { get; set; }
        public float components { get; set; }
        public float HealthReduction { get; set; }
        public float TeamSize { get; set; }
        public float _521fb564 { get; set; }
        public float MaxHealthShield { get; set; }
        public float ShieldDuration { get; set; }
        public float BonusHPPer5MissingHealth { get; set; }
        public float OmnivampPercentPer5MissingHealth { get; set; }
        public float DropChance { get; set; }
        public float ShieldHealth { get; set; }
        public float HPBonus { get; set; }
        public float StartingStacks { get; set; }
        public float AS1 { get; set; }
        public float AS2 { get; set; }
        public float AS3 { get; set; }
        public float AS4 { get; set; }
        public float HP1 { get; set; }
        public float HP2 { get; set; }
        public float HP3 { get; set; }
        public float HP4 { get; set; }
        public float BurnPercent { get; set; }
        public float HealingReductionPct { get; set; }
        public float InitialXP { get; set; }
        public float MissingHPHeal { get; set; }
        public float HealPercent { get; set; }
        public float StartingAP { get; set; }
        public float _2b33ebd5 { get; set; }
        public float tier1champs { get; set; }
        public float a9ad6d1b { get; set; }
        public float MaxComponents { get; set; }
        public float NumStages { get; set; }
        public float MaxArmySizeIncrease { get; set; }
        public float PlayerCombatDamageIncrease { get; set; }
        public float InstantGold { get; set; }
        public float RoundGold { get; set; }
        public float WinsNeeded { get; set; }
        public float _5efd6ee0 { get; set; }
        public float LesserDuplicatorAmount { get; set; }
        public float NumCompletedItems { get; set; }
        public float RerollPercent { get; set; }
        public object NumRemovers { get; set; }
        public float _0d14760d { get; set; }
        public float _82aeb8a7 { get; set; }
        public float tooltipincreaseddamage1 { get; set; }
        public float tooltipincreaseddamage2 { get; set; }
        public float RoundsPerComponent { get; set; }
        public float AuraIncreasePercent { get; set; }
        public float Numrolls { get; set; }
        public float MaxHealthThreshold { get; set; }
        public float PercentMaxHealthDamage { get; set; }
        public float goldrequired { get; set; }
        public float AscendedAmpTOOLTIPONLY { get; set; }
        public float HealShieldIncrease { get; set; }
        public float HealthCap { get; set; }
        public float RollNumber { get; set; }
        public float SpreadTargets { get; set; }
        public float SpreadTimer { get; set; }
        public float FutureChampionCount { get; set; }
        public float IncreaseBy { get; set; }
        public float NumUntilIncrease { get; set; }
        public string StartingCost { get; set; }
        public float MinInterest { get; set; }
        public float XPPerGold { get; set; }
        public float ArmorPenPercent { get; set; }
        public float HealReductionPercent { get; set; }
        public object HexRangeIncrease { get; set; }
        public float NumItemAnvils { get; set; }
        public float levelreqa { get; set; }
        public float levelreqb { get; set; }
        public float levelreqc { get; set; }
        public float levelreqd { get; set; }
        public float UnitTier { get; set; }
        public float rounds { get; set; }
        public object _4a99a5b2 { get; set; }
        public float ADPerStarLevel { get; set; }
        public float c56ea2ab { get; set; }
        public float BaseDamageAmp { get; set; }
        public float FullDamageAmp { get; set; }
        public float AbilityPower { get; set; }
        public float AttackDamage { get; set; }
        public float _9652277e { get; set; }
        public float Conversion { get; set; }
        public float StartingAD { get; set; }
        public float HealthPerGold { get; set; }
        public object NumFullItems { get; set; }
        public object _466ef38d { get; set; }
        public float BonusMovementSpeed { get; set; }
        public float PercentMana { get; set; }
        public float c90c2591 { get; set; }
        public float RandomComponents { get; set; }
        public float DR { get; set; }
        public float NumAnvils { get; set; }
        public float AoEDamage { get; set; }
        public float AttackSpeedAmount { get; set; }
        public object HealAmount { get; set; }
        public float PercentHealthShield { get; set; }
        public float _00ac4fc9 { get; set; }
        public float _2d7e43a8 { get; set; }
        public float _3ba78496 { get; set; }
        public float _5d8ecbba { get; set; }
        public string _9a186b7d { get; set; }
        public float NumAttacks { get; set; }
        public float _04209718 { get; set; }
        public float MaxHealthDmg { get; set; }
        public float MaxHealthPct { get; set; }
        public float DefenseRatio { get; set; }
        public float SizeIncrease { get; set; }
        public float ExtraBounces { get; set; }
        public float numtg { get; set; }
        public float _5edfa63d { get; set; }
        public float _5f6ff20a { get; set; }
        public float _8c58ac06 { get; set; }
        public float _8f15cad2 { get; set; }
        public float healamp { get; set; }
        public float radius { get; set; }
        public float TempDamageReduction { get; set; }
        public float IncRange { get; set; }
        public float Level { get; set; }
        public float BaseRerolls { get; set; }
        public float BonusRerolls { get; set; }
        public float _6d4321f7 { get; set; }
        public float HealRate { get; set; }
        public float BonusHaunts { get; set; }
        public float TakeDowns { get; set; }
        public float APtoShieldRatio { get; set; }
        public float Distance { get; set; }
        public float BonusGold { get; set; }
        public float DeathBonus { get; set; }
        public float _178cb7b0 { get; set; }
        public float Crit { get; set; }
        public float RoundStacks { get; set; }
        public float AttackSpeedPerStack { get; set; }
        public float _7f8afef1 { get; set; }
        public float HexRange { get; set; }
        public float BaseAD { get; set; }
        public float BaseHeal { get; set; }
        public float BaseSP { get; set; }
        public float BonusSP { get; set; }
        public float _693a77ae { get; set; }
        public float a60806db { get; set; }
        public float LargeBonusPct { get; set; }
        public float GoldReward { get; set; }
        public float cd5eb5cd { get; set; }
        public float BonusResists { get; set; }
        public float ShieldValue { get; set; }
        public float AoEDamageReduction { get; set; }
        public float HealTickRate { get; set; }
        public float MaxHeal { get; set; }
        public float MissingHealthHeal { get; set; }
        public float BurnDuration { get; set; }
        public float MonsterCap { get; set; }
        public float BonusPercentHP { get; set; }
        public float BaseDamageReduction { get; set; }
        public float EmpowerDamageReduction { get; set; }
        public float ThresholdForEmpower { get; set; }
        public float CritDamageToGive { get; set; }
        public object HealthRegenInterval { get; set; }
        public object MaxHealthRegen { get; set; }
        public float PercentHealthDamage { get; set; }
        public float PercentMaxHP { get; set; }
        public float DamageAmpPct { get; set; }
        public float MRShred { get; set; }
        public float ManaRatio { get; set; }
        public float ASTotalDuration { get; set; }
        public float ProcAttackSpeed { get; set; }
        public float ProcInterval { get; set; }
        public float SpellShieldDuration { get; set; }
        public float _1StarBounces { get; set; }
        public float MRShredDuration { get; set; }
        public float _12a15e9e { get; set; }
        public float _15144cec { get; set; }
        public float _79e2ec7b { get; set; }
        public float ShieldHealthPercent { get; set; }
        public float TakedownTimer { get; set; }
        public float APPerInterval { get; set; }
        public float IntervalSeconds { get; set; }
        public float TicksPerSecond { get; set; }
        public float _1StarAoEDamage { get; set; }
        public float _2StarAoEDamage { get; set; }
        public float _3StarAoEDamage { get; set; }
        public float AutoDamageReduction { get; set; }
        public float b5c2a66b { get; set; }
        public float SummonedStatReduction { get; set; }
        public float _50a0dbb5 { get; set; }
        public float ef0bb7c2 { get; set; }
        public float AllyBonusMana { get; set; }
        public float CostIncrease { get; set; }
        public float _4516a18d { get; set; }
        public float AdditionalTargets { get; set; }
        public float MultiplierForDamage { get; set; }
        public float AllyBonusAS { get; set; }
        public float BanishDuration { get; set; }
        public float ADBuff { get; set; }
        public float APBuff { get; set; }
        public float TraitMultiplier { get; set; }
        public float LifeSteal { get; set; }
        public float ArmorBreakDuration { get; set; }
        public float ArmorReductionPercent { get; set; }
        public float _1StarShieldValue { get; set; }
        public float _2StarShieldValue { get; set; }
        public float _3StarShieldValue { get; set; }
        public float BonusAllyHealth { get; set; }
        public float c78af25f { get; set; }
        public float BonusADToGive { get; set; }
        public float BonusMaxHealthPerc { get; set; }
        public float HealthThreshold2 { get; set; }
        public float MissingHealthRestore { get; set; }
        public float StealthDuration { get; set; }
        public float BonusResistsAtStackCap { get; set; }
        public float StackingAD { get; set; }
        public float StackingSP { get; set; }
        public float ChillDuration { get; set; }
        public float ShieldBonusAP { get; set; }
        public float ShieldSize { get; set; }
        public float ArmorPerEnemy { get; set; }
        public float MRPerEnemy { get; set; }
        public float ChaliceAP { get; set; }
        public float Spellvamp { get; set; }
        public float ASDuration { get; set; }
        public float AttackSpeedToGive { get; set; }
        public float FlatManaRestore { get; set; }
        public float ARReductionAmount { get; set; }
        public float BonusResistDuration { get; set; }
        public float BackRowBonusAP { get; set; }
        public float FrontLineManaPerHit { get; set; }
        public float FrontRowBonusResists { get; set; }
        public float ManaPerTickrate { get; set; }
        public float ManaTickrate { get; set; }
        public float TotalAPBonus { get; set; }
        public float OrbsToGive { get; set; }
        public float ItemsToGive { get; set; }
        public float b2630e29 { get; set; }
        public float newfrequency { get; set; }
        public float b37d8824 { get; set; }
        public float cleave { get; set; }
        public float firstBreakpoint { get; set; }
        public float secondBreakpoint { get; set; }
        public float thirdBreakpoint { get; set; }
        public float ADPercent { get; set; }
        public float BonusAttackThreshold { get; set; }
        public float percenteffect { get; set; }
        public float BaseDropChance { get; set; }
        public float ExecuteThreshold { get; set; }
        public float LevelScalar { get; set; }
        public float ShredSunder { get; set; }
        public float HealthShieldPercent { get; set; }
        public float percent { get; set; }
        public float TauntInterval { get; set; }
        public float NewMaxStacks { get; set; }
        public float DamagePercent { get; set; }
        public float BonusKillGold { get; set; }
        public float MaxBonusTOOLTIPONLY { get; set; }
        public float MinBonusTOOLTIPONLY { get; set; }
        public float _2fbb7884 { get; set; }
        public float _30bb7a17 { get; set; }
        public string _32bb7d3d { get; set; }
        public float HLAttackspeed { get; set; }
        public float HLHealth { get; set; }
        public float Hex { get; set; }
        public float ImprovedHex { get; set; }
        public float TimeInCombat { get; set; }
        public float DiscoRadius { get; set; }
        public float newtickrate { get; set; }
        public float ImmuneDuration { get; set; }
        public string _63ce3562 { get; set; }
        public string e7bc3c63 { get; set; }
        public float RoundsToRegain { get; set; }
        public float ExtraHealth { get; set; }
        public float SilenceDuration { get; set; }
        public float _2275757b { get; set; }
        public float BuffAttackSpeed { get; set; }
        public float ProcADPercent { get; set; }
        public float BonusHearts { get; set; }
        public float WinPenalty { get; set; }
        public float HPRegen { get; set; }
        public float ProcRate { get; set; }
        public float ManaDuration { get; set; }
        public float AbilityPowerGoldMax { get; set; }
        public float AbilityPowerPerGold { get; set; }
        public float OnKillProcChance { get; set; }
        public float OnKillProcGold { get; set; }
        public float GoldGranted { get; set; }
        public float StackLimit { get; set; }
        public float BaseHealthPerStack { get; set; }
        public float BaseResistsPerStack { get; set; }
        public float GoldAtFullStacks { get; set; }
        public float AttackSpeedGoldLimit { get; set; }
        public float AttackSpeedPerGold { get; set; }
        public float ChanceToProc { get; set; }
        public float GoldPerProc { get; set; }
        public float _46736b3f { get; set; }
        public float b38e1643 { get; set; }
        public float BonusDamagePerGold { get; set; }
        public float GoldLimit { get; set; }
        public float ProcTimeInSeconds { get; set; }
        public float AttackDamageGoldLimit { get; set; }
        public float AttackDamagePerGold { get; set; }
        public float CashoutGold { get; set; }
        public float CashoutStacks { get; set; }
        public float StacksPerAttack { get; set; }
        public string _08083372 { get; set; }
        public float fd493b8a { get; set; }
        public float BaseDamageImmunityTime { get; set; }
        public float GoldPerImmunityProc { get; set; }
        public float HPThreshold1 { get; set; }
        public float _3205531e { get; set; }
        public float AttackGoldMultiplier { get; set; }
        public float SecondsForEmpoweredAttack { get; set; }
        public float ManaIncrease { get; set; }
        public float DamageAmpPercent { get; set; }
        public float ResistPercent { get; set; }
        public float _63a4b712 { get; set; }
        public float bd7eea9a { get; set; }
        public float d76b8ef7 { get; set; }
        public float ASAmt { get; set; }
        public float _937db108 { get; set; }
        public float APAmt { get; set; }
        public float _71bc3700 { get; set; }
        public float HealthRestore { get; set; }
        public float StasisDuration { get; set; }
        public float _6688a0d5 { get; set; }
        public float BuffDuration { get; set; }
        public float StunDuration { get; set; }
        public float AllyShieldRatio { get; set; }
        public float HealthShieldRatio { get; set; }
        public float AttackSpeedPercent { get; set; }
        public float BonusRatio { get; set; }
        public float PercentHealthRegen { get; set; }
        public float ProcDamage { get; set; }
        public float bf4b1194 { get; set; }
        public float c14b14ba { get; set; }
        public float c24b164d { get; set; }
        public float FreezeDuration { get; set; }
        public float _0cc88d45 { get; set; }
        public float AttackSpeedSlowPercent { get; set; }
        public float FreezeCooldown { get; set; }
        public float NumApplications { get; set; }
        public float SlowDuration { get; set; }
        public float _0e4779e5 { get; set; }
        public float Shred { get; set; }
        public float TeamAD { get; set; }
        public float TeamAP { get; set; }
        public float MaxHealthHeal { get; set; }
        public float PostDeathDuration { get; set; }
        public float TOOLTIPEmpoweredHeal { get; set; }
        public float _484836f3 { get; set; }
        public float _98ac43ce { get; set; }
        public float a56e0a21 { get; set; }
        public float ManaOnTakedown { get; set; }
        public float BurnAmount { get; set; }
        public float _1611482f { get; set; }
        public float ff22d532 { get; set; }
        public string _55ce8055 { get; set; }
        public float d0fcc895 { get; set; }
        public float InvulnDuration { get; set; }
        public float PercentHealthThreshold { get; set; }
        public string TooltipStartingCharge { get; set; }
        public float ADandAPPerTick { get; set; }
        public float HealingPercentPerTickPerStage { get; set; }
        public float PercentDamageIncrease { get; set; }
        public float BonusAttackDamage { get; set; }
        public float BonusPercentHealth { get; set; }
        public float _32f90193 { get; set; }
        public float BleedDuration { get; set; }
        public float IgnorePainPercent { get; set; }
        public float fe9818ef { get; set; }
        public float _9f5117db { get; set; }
        public string d357c9f2 { get; set; }
        public float BaseAmp { get; set; }
        public float BonusAmp { get; set; }
        public float BonusDefense { get; set; }
        public float cb57edb0 { get; set; }
        public float ASBuff { get; set; }
        public float BonusInitialMana { get; set; }
        public float _9fd37c1c { get; set; }
        public float ExecutePercent { get; set; }
        public float _1bb18b94 { get; set; }
    }

    public class Setdata
    {
        public Champion5[] champions { get; set; }
        public string mutator { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public Trait5[] traits { get; set; }
    }

    public class Champion5
    {
        public Ability5 ability { get; set; }
        public string apiName { get; set; }
        public string characterName { get; set; }
        public int cost { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string squareIcon { get; set; }
        public Stats5 stats { get; set; }
        public string tileIcon { get; set; }
        public string[] traits { get; set; }
    }

    public class Ability5
    {
        public string desc { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public Variable5[] variables { get; set; }
    }

    public class Variable5
    {
        public string name { get; set; }
        public float[] value { get; set; }
    }

    public class Stats5
    {
        public float? armor { get; set; }
        public float? attackSpeed { get; set; }
        public float? critChance { get; set; }
        public float critMultiplier { get; set; }
        public float? damage { get; set; }
        public float? hp { get; set; }
        public float initialMana { get; set; }
        public float? magicResist { get; set; }
        public float mana { get; set; }
        public float range { get; set; }
    }

    public class Trait5
    {
        public string apiName { get; set; }
        public string desc { get; set; }
        public Effect5[] effects { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public class Effect5
    {
        public int maxUnits { get; set; }
        public int minUnits { get; set; }
        public int style { get; set; }
        public Variables5 variables { get; set; }
    }

    public class Variables5
    {
        public float EmblemBonus { get; set; }
        public float Mana { get; set; }
        public float NumberOfSpirits { get; set; }
        public float SpiritDuration { get; set; }
        public float TooltipBonus { get; set; }
        public float _18bfc1ac { get; set; }
        public float _1b8cd16a { get; set; }
        public float _27b17444 { get; set; }
        public float _3fc62f6f { get; set; }
        public float _4df03474 { get; set; }
        public float _53912082 { get; set; }
        public float _7d34708f { get; set; }
        public float b9a6ee1b { get; set; }
        public float eb0c521b { get; set; }
        public float ed124bdb { get; set; }
        public float f6b4b588 { get; set; }
        public float BonusDefenses { get; set; }
        public float NumElites { get; set; }
        public float BonusCasts { get; set; }
        public object DamageReduction { get; set; }
        public object ManaPerAuto { get; set; }
        public float BonusAP { get; set; }
        public float HealthPct { get; set; }
        public float TargetNum { get; set; }
        public float a34f32df { get; set; }
        public float Duration { get; set; }
        public float MaxDR { get; set; }
        public float MinDR { get; set; }
        public float BonusAS { get; set; }
        public float BurstDuration { get; set; }
        public float IncreasePct { get; set; }
        public float BonusArmor { get; set; }
        public float BonusMR { get; set; }
        public float BonusPercent { get; set; }
        public float _09b7d38c { get; set; }
        public float HealShieldIncrease { get; set; }
        public float BonusPercentHealth { get; set; }
        public float TeamFlatHealth { get; set; }
        public float MaxStacks { get; set; }
        public float PercentAD { get; set; }
        public object AscensionStrengthBoost { get; set; }
        public float BonusASPercent { get; set; }
        public float BonusHealthPercent { get; set; }
        public float HealthRegen { get; set; }
        public float PulsePeriod { get; set; }
        public float SecondsToAscend { get; set; }
        public float e3dc0fc2 { get; set; }
        public float AttackSpeed { get; set; }
        public object _7714a401 { get; set; }
        public float af532c9d { get; set; }
        public float AD { get; set; }
        public float AP { get; set; }
        public float BonusRatio { get; set; }
        public float Health { get; set; }
        public float BonusRange { get; set; }
        public float DamageAmp { get; set; }
        public float ShotFrequency { get; set; }
        public object BleedDuration { get; set; }
        public object BleedPct { get; set; }
        public float HealthThreshold { get; set; }
        public float HexRange { get; set; }
        public float StealthDuration { get; set; }
        public float PercentBonusMaxHealth { get; set; }
        public float PercentHealthHeal { get; set; }
        public float PercentHealthMagicDamage { get; set; }
        public float _05b87026 { get; set; }
        public object dbf68e4f { get; set; }
        public float BonusDamageBase { get; set; }
        public float Omnivamp { get; set; }
        public float ElectricCapstoneAmp { get; set; }
        public float ElectricStunDuration { get; set; }
        public float FireBurnPercent { get; set; }
        public float FireCapstoneBurnPercent { get; set; }
        public float FireCapstoneDamagePercent { get; set; }
        public float FireDamagePercent { get; set; }
        public float FireDuration { get; set; }
        public float IceBlockDuration { get; set; }
        public float IceCapstoneHealthPercentDamage { get; set; }
        public float IceHealPercent { get; set; }
        public float IceHealthThreshold { get; set; }
        public float NumberOfHexes { get; set; }
        public float StoneBuffDuration { get; set; }
        public float StoneCapstoneHeal { get; set; }
        public float StoneDamageReduction { get; set; }
        public float WindAS { get; set; }
        public float WindBuffDuration { get; set; }
        public float WindCapstoneAS { get; set; }
        public float WindCapstoneBuffDuration { get; set; }
        public float WoodBonusHealth { get; set; }
        public float WoodBonusHealthHR { get; set; }
        public float WoodCapstoneStatGrowth { get; set; }
        public float WoodCapstoneTicRate { get; set; }
        public float WoodPercentHealth { get; set; }
        public float dd25bb1b { get; set; }
        public float ShieldDuration { get; set; }
        public float ShieldHP { get; set; }
        public float BarrageInterval { get; set; }
        public float Damage { get; set; }
        public float DamagePercent { get; set; }
        public object SplashPercent { get; set; }
        public float _2aeb6df5 { get; set; }
        public float BonusAttackSpeed { get; set; }
        public float DodgeChance { get; set; }
        public float DodgeDuration { get; set; }
        public float ManaReduction { get; set; }
        public float _25ec78e1 { get; set; }
        public float c235f1f1 { get; set; }
        public float eae1472b { get; set; }
        public float PercentHealthAPPerStarLevel { get; set; }
        public float a4dcb3da { get; set; }
        public object SelfBonusMana { get; set; }
        public object TeamAP { get; set; }
        public float TeamMana { get; set; }
        public float TickRate { get; set; }
        public float DamageInstances { get; set; }
        public float ManaRegen { get; set; }
        public float MaxHealthShield { get; set; }
        public float GoldCost { get; set; }
        public float _8063e2fe { get; set; }
        public float db5e6ace { get; set; }
        public float BaseCritChance { get; set; }
        public float CritDmg { get; set; }
        public float DelayTime { get; set; }
        public float PercentHealthDamage { get; set; }
        public float ShredSunder { get; set; }
        public float _81ce23cf { get; set; }
        public float StunDuration { get; set; }
        public object WeaponEffectBonus { get; set; }
        public float _86ee85af { get; set; }
        public float PercentDamageIncrease { get; set; }
        public float HealPercent { get; set; }
        public float MagicResist { get; set; }
        public float ShieldAmount { get; set; }
        public float CoinDropChance { get; set; }
        public object ItemDropChance { get; set; }
        public float ADandSP { get; set; }
        public float HealOrDamageAmount { get; set; }
        public object ManaPerSecond { get; set; }
        public float ManaCostReduction { get; set; }
        public float ExtraAttacks { get; set; }
        public float ProcChance { get; set; }
        public float Frequency { get; set; }
        public float PercentAttackSpeed { get; set; }
        public float Armor { get; set; }
        public float ShieldPercent { get; set; }
        public float ManaRestore { get; set; }
        public float BonusHealth { get; set; }
        public float ADAmp { get; set; }
        public float HealthAmp { get; set; }
        public float PercentHealth { get; set; }
        public float EjectedPilotHealthPercent { get; set; }
        public float _092d19fb { get; set; }
        public float _5dd40675 { get; set; }
        public float _952c9d9c { get; set; }
        public float d13e2b40 { get; set; }
        public string dc3931d7 { get; set; }
        public float ed41c244 { get; set; }
        public float CostIncreasePercent { get; set; }
        public float AdditionalAttacks { get; set; }
        public float AttackSpeedPercent { get; set; }
        public float _650d33c0 { get; set; }
        public float HealingPercent { get; set; }
        public float NumInstances { get; set; }
        public float NumSpectres { get; set; }
        public object Heal { get; set; }
        public object WinPenalty { get; set; }
        public float _02dd7588 { get; set; }
        public float _03dd771b { get; set; }
        public float _04dd78ae { get; set; }
        public float _05dd7a41 { get; set; }
        public float _06dd7bd4 { get; set; }
        public float _07dd7d67 { get; set; }
        public float _1483b8b4 { get; set; }
        public string _15b17b97 { get; set; }
        public object _5da364e1 { get; set; }
        public object _5ec17b88 { get; set; }
        public float _7b8c990e { get; set; }
        public float ac1f138b { get; set; }
        public float _034c4dbb { get; set; }
        public float _2c6cd0ff { get; set; }
        public float _6f3d98c0 { get; set; }
        public float _73f5f8da { get; set; }
        public float _91da68d9 { get; set; }
        public float _9e4b847c { get; set; }
        public float ce0fa894 { get; set; }
        public object BleedDamage { get; set; }
        public float CritChance { get; set; }
        public object DesireExecuteRewardPercent { get; set; }
        public float DesireExecuteThreshhold { get; set; }
        public float DesireExecuteRewardPercentHR { get; set; }
        public float b84914bf { get; set; }
        public float HealthPerCompost { get; set; }
        public float HealthPerCompostHR { get; set; }
        public float StartingHealth { get; set; }
        public float StartingHealthHR { get; set; }
        public float APAmount { get; set; }
        public float ArcanistAbilityPower { get; set; }
        public float TeamAbilityPower { get; set; }
        public float PercentBuff { get; set; }
        public object _20436879 { get; set; }
        public float _5ff50860 { get; set; }
        public float PercentDamageToHeal { get; set; }
        public float Resists { get; set; }
        public string b11aeccf { get; set; }
        public float BaseAmountXP { get; set; }
        public float BaseDamageAmp { get; set; }
        public float DamageAmpPerLevel { get; set; }
        public float HRGold { get; set; }
        public float ca5fd6df { get; set; }
        public float HeavenlyBonus { get; set; }
        public float _13f889ae { get; set; }
        public float _19e47528 { get; set; }
        public float _26ac6bc4 { get; set; }
        public float _3c9e3624 { get; set; }
        public float _414a2beb { get; set; }
        public float _4803a4eb { get; set; }
        public float _912546f4 { get; set; }
        public float a8a84fe9 { get; set; }
        public float f82ecbac { get; set; }
        public float AS { get; set; }
        public float DR { get; set; }
        public float ASDuration { get; set; }
        public float AttackSpeedBuff { get; set; }
        public float FirstDelay { get; set; }
        public float TrueDamageHPRatio { get; set; }
        public float RefreshSeconds { get; set; }
        public object SlamPercentHealth { get; set; }
        public float TeamBonusHealth { get; set; }
        public float MaxBounces { get; set; }
        public float PercentDamage { get; set; }
        public float BondIncreasePercent { get; set; }
        public float PairHPBonus { get; set; }
        public float _55f4e448 { get; set; }
        public float _89fffd48 { get; set; }
        public object f75cc2d4 { get; set; }
        public float InvokerMana { get; set; }
        public float CastCount { get; set; }
        public float HexRangeIncrease { get; set; }
        public object _7db0ae46 { get; set; }
        public float Multiplier { get; set; }
        public float PrismaticMultiplier { get; set; }
        public string OmnivampPercent { get; set; }
        public float RevivePercent { get; set; }
        public float DRPercent { get; set; }
        public float StartOfCombatDRPercent { get; set; }
        public float Defenses { get; set; }
        public float _2af8e84f { get; set; }
        public float BonusASPerStage { get; set; }
        public float _3609554d { get; set; }
        public float _6cf32d7f { get; set; }
        public float _8f92bd7b { get; set; }
        public float a4d5374e { get; set; }
        public float b0332b0a { get; set; }
        public float b7c5b67d { get; set; }
        public float cdd2f157 { get; set; }
        public float de1b2c92 { get; set; }
        public float ExtraTargetsHit { get; set; }
        public float ProcPercent { get; set; }
        public float f768e185 { get; set; }
        public float MissPercent { get; set; }
        public float AttackSpeedReductionPercent { get; set; }
        public float DebuffDuration { get; set; }
        public float HexSize { get; set; }
        public float a004f927 { get; set; }
        public float AttackDamage { get; set; }
        public float DamageReductionPercent { get; set; }
        public float BlockAmount { get; set; }
        public float DamageMultiplier { get; set; }
        public float HPPercent { get; set; }
        public float ADValue { get; set; }
        public float APValue { get; set; }
        public float BuffDuration { get; set; }
        public float DelayBetweenBuffs { get; set; }
        public float InitialDelay { get; set; }
        public float ManaDrainBurn { get; set; }
        public float ManaDrainDrain { get; set; }
        public float ManaDrainProcChance { get; set; }
        public float CritAmpPercent { get; set; }
        public float CritChanceAmpPercent { get; set; }
        public float BonusOmnivamp { get; set; }
        public float RespawnTimer { get; set; }
        public float HealthBonus { get; set; }
        public float OmnivampBonus { get; set; }
        public float NumHighScores { get; set; }
        public float _07d8a23c { get; set; }
        public float _1898a704 { get; set; }
        public float _23107b0a { get; set; }
        public float _32c611e7 { get; set; }
        public float _32f494a9 { get; set; }
        public float _3ac63386 { get; set; }
        public float _4e4bda72 { get; set; }
        public float _4ff425ef { get; set; }
        public float _57358459 { get; set; }
        public float _5bf0a783 { get; set; }
        public float _5bf63cb6 { get; set; }
        public float _711044ee { get; set; }
        public float _73092577 { get; set; }
        public float _7422b321 { get; set; }
        public float _7741f7e8 { get; set; }
        public float _83f7600e { get; set; }
        public float _849cb125 { get; set; }
        public float c876dba0 { get; set; }
        public float cb973c66 { get; set; }
        public float cb98e839 { get; set; }
        public float e291f403 { get; set; }
        public float f20af5b5 { get; set; }
        public object HeartKeepPercentage { get; set; }
        public float PercentHeartRate { get; set; }
        public float RoundCount { get; set; }
        public float RoundCount_HR { get; set; }
        public float _035b49c7 { get; set; }
        public float _0ed79bac { get; set; }
        public float _1aba31d0 { get; set; }
        public float _270aa35b { get; set; }
        public float _2f144a72 { get; set; }
        public float _3b93f5f0 { get; set; }
        public float _3d93f916 { get; set; }
        public float _3e93faa9 { get; set; }
        public float _3f93fc3c { get; set; }
        public float _4093fdcf { get; set; }
        public float _56e499e0 { get; set; }
        public float _5f254a07 { get; set; }
        public float _776acd0e { get; set; }
        public object _7e97c18b { get; set; }
        public float _877a0743 { get; set; }
        public float _989d8904 { get; set; }
        public float a0fc9505 { get; set; }
        public float a4f2dc1d { get; set; }
        public float c83c7511 { get; set; }
        public float cd492c59 { get; set; }
        public float d0ba644e { get; set; }
        public float d2e59737 { get; set; }
        public float e4b74e78 { get; set; }
        public float ef5a2d30 { get; set; }
        public float f05a2ec3 { get; set; }
        public float f45a350f { get; set; }
        public float f55a36a2 { get; set; }
        public float f65a3835 { get; set; }
        public float PercentHealthThreshold { get; set; }
        public float ShieldPercentAmount { get; set; }
        public float AssassinGoldPerKill { get; set; }
        public float NumOfKills { get; set; }
        public float RhaastPlayerHealthPerKill { get; set; }
        public float NumOfAllies { get; set; }
        public float ADRatio { get; set; }
        public float HealthRatio { get; set; }
        public float BonusAttackDamage { get; set; }
        public float ManaPerAttack { get; set; }
        public float _3c4f17cb { get; set; }
        public float _48d42308 { get; set; }
        public float AmountIncrease { get; set; }
        public float FighterAS { get; set; }
        public float FighterVamp { get; set; }
        public float TeamwideAP { get; set; }
        public float BonusDamage { get; set; }
        public float InitialMana { get; set; }
        public float StackingMana { get; set; }
        public float BONUS_AD_AP { get; set; }
        public float BONUS_HEALTH { get; set; }
        public float FIRST_ROLL_BONUS { get; set; }
        public float _6f204280 { get; set; }
        public float _1Star { get; set; }
        public float _2Star { get; set; }
        public float _3Star { get; set; }
        public float BonusMaxHealth { get; set; }
        public float _158db106 { get; set; }
        public float BONUS_DAMAGE { get; set; }
        public float _744944d9 { get; set; }
        public object d1eaafe0 { get; set; }
        public float PercentAS { get; set; }
        public float TeamwideAttackSpeed { get; set; }
        public float CRIT_DAMAGE { get; set; }
        public float CRIT_PERCENT { get; set; }
        public float BaseBonus { get; set; }
        public float BonusPerSecond { get; set; }
        public float JumpDamage { get; set; }
        public float StunRange { get; set; }
        public object BonusResists { get; set; }
        public float Level { get; set; }
        public float Healing { get; set; }
        public float HexRadius { get; set; }
        public float _11b35e1c { get; set; }
        public float DOTPercent { get; set; }
        public float DamageDecrease { get; set; }
        public float PercentADEmpowered { get; set; }
        public float EDMstats { get; set; }
        public float _1d0f36aa { get; set; }
        public float _34753da8 { get; set; }
        public float _52707149 { get; set; }
        public float b7559eb7 { get; set; }
        public float d8f28e45 { get; set; }
        public float d9fae949 { get; set; }
        public float f40f819b { get; set; }
        public float fb62799b { get; set; }
        public float EDMtimereduction { get; set; }
        public float Attack_Speed { get; set; }
        public float Kill_Bonus { get; set; }
        public float Kill_Count { get; set; }
        public float _0082059a { get; set; }
        public float a624ed1a { get; set; }
    }

}
