using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{
    public class Ability : BaseEntity
    {
        [JsonPropertyName("desc")]
        public string Description { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("variables")]
        public List<Variables> Variables { get; set; }
    }
}
