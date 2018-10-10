using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class Request
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idempotency_key")]
        public object IdempotencyKey { get; set; }
    }
}