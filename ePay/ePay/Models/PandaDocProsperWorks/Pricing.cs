using Newtonsoft.Json;
using System.Collections.Generic;

namespace ePay.Models
{
    public class Pricing
    {
        [JsonProperty("tables")]
        public List<Table> Tables { get; set; } = new List<Table>();

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}