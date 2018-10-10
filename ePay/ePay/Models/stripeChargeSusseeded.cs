using Newtonsoft.Json;

namespace ePay.Models
{
    public class StripeChargeSusseeded
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("pandadoc_document_reference")]
        public string PandadocDocumentReference { get; set; }
    }
}