using Newtonsoft.Json;

namespace ePay.Models
{
    public class Template
    {
        [JsonProperty("id")]
        public string Id
        { get; set; }

        [JsonProperty("name")]
        public string Name
        { get; set; }
    }
}