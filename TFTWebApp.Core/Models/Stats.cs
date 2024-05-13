using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{
    public class Stats : BaseEntity
    {
        [JsonPropertyName("armor")]
        public float? Armor { get; set; }
        [JsonPropertyName("attackSpeed")]
        public float? AttackSpeed { get; set; }
        [JsonPropertyName("critChance")]
        public float? CritChance { get; set; }
        [JsonPropertyName("critMultiplier")]
        public float CritMultiplier { get; set; }
        [JsonPropertyName("damage")]
        public float? Damage { get; set; }
        [JsonPropertyName("hp")]
        public float? Hp { get; set; }
        [JsonPropertyName("initialMana")]
        public float InitialMana { get; set; }
        [JsonPropertyName("magicResist")]
        public float? MagicResist { get; set; }
        [JsonPropertyName("mana")]
        public float Mana { get; set; }
        [JsonPropertyName("range")]
        public float Range { get; set; }
    }
}
