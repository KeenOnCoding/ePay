using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class Metadata
    {
        [JsonProperty("pandadoc_document_payment_action_id")]
        public string PandadocDocumentPaymentActionId { get; set; }

        [JsonProperty("pandadoc_document_reference")]
        public string PandadocDocumentReference { get; set; }
    }
}