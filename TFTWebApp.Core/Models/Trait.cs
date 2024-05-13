
using System.Text.Json.Serialization;

namespace TFTWebApp.Core.Models
{
    public class Trait : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public List<Champion>? Champions { get; set; }
    }
}
