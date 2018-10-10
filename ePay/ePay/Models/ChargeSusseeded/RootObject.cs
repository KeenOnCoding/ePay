using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class RootObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("pending_webhooks")]
        public int PendingWebhooks { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}