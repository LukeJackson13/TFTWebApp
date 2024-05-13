using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFTWebApp.Core.Models
{
    public class Item : BaseEntity
    {
        [JsonPropertyName("apiName")]
        public string ApiName { get; set; }
        [JsonPropertyName("associatedTraits")]
        public string[] AssociatedTraits { get; set; }
        [JsonPropertyName("composition")]
        public string[] Composition { get; set; }
        [JsonPropertyName("desc")]
        public string Description { get; set; }
        [JsonPropertyName("effects")]
        public Effects6 Effects { get; set; }
        [JsonPropertyName("from")]
        public object From { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("id")]
        public object Id { get; set; }
        [JsonPropertyName("incompatibleTraits")]
        public string[] IncompatibleTraits { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("unique")]
        public bool Unique { get; set; }
    }
}
