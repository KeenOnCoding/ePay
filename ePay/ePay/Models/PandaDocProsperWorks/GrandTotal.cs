using Newtonsoft.Json;

namespace ePay.Models
{
    public class GrandTotal
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}