using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFTWebApp.Core.Models
{
    public class TraitBreakpoint : BaseEntity
    {
        [JsonPropertyName("apiName")]
        public string ApiName { get; set; }

        [JsonPropertyName("desc")]
        public string? Description { get; set; }

        [JsonPropertyName("effects")]
        public Effects[] Effects { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
