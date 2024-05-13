using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFTWebApp.Core.Models
{
    public class Effects :BaseEntity
    {
        [JsonPropertyName("maxUnits")]
        public int MaxUnits { get; set; }
        [JsonPropertyName("minUnits")]
        public int MinUnits { get; set; }
        [JsonPropertyName("style")]
        public int Style { get; set; }

        [JsonPropertyName("variables")]
        public Variables5 TraitVariables { get; set; }
    }
}
