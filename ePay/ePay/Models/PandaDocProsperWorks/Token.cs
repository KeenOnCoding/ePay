using Newtonsoft.Json;

namespace ePay.Models
{
    public class Token
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}