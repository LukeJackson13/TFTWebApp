using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{
    public class Variable : BaseEntity
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public float[] Value { get; set; }
    }
}
