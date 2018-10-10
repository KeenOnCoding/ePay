using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class Outcome
    {
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        [JsonProperty("reason")]
        public object Reason { get; set; }

        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }

        [JsonProperty("seller_message")]
        public string SellerMessage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}