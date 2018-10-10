using Newtonsoft.Json;
using System.Collections.Generic;

namespace ePay.Models
{
    public class Table
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("is_included_in_total")]
        public bool IsIncludedInTotal { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; } = new Summary();

        [JsonProperty("items")]
        public List<Item> Items { get; set; } = new List<Item>();
    }
}