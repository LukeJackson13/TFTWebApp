using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{
    public class Champion : BaseEntity
    {
        [JsonPropertyName("ability")]
        public Ability Ability { get; set; }
        [JsonPropertyName("apiName")]
        public string ApiName { get; set; }
        [JsonPropertyName("characterName")]
        public string CharacterName { get; set; }
        [JsonPropertyName("cost")]
        public int Cost { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("squareIcon")]
        public string SquareIcon { get; set; }
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }
        [JsonPropertyName("tileIcon")]
        public string TileIcon { get; set; }

        public List<Trait> Traits { get; set; }
    }

}
