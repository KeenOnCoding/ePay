using Newtonsoft.Json;

namespace ePay.Models
{
    public class Summary
    {
        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }
    }
}