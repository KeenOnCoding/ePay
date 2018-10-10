using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class Source
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("address_city")]
        public object AddressCity { get; set; }

        [JsonProperty("address_country")]
        public object AddressCountry { get; set; }

        [JsonProperty("address_line1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("address_line1_check")]
        public object AddressLine1Check { get; set; }

        [JsonProperty("address_line2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("address_state")]
        public object AddressState { get; set; }

        [JsonProperty("address_zip")]
        public object AddressZip { get; set; }

        [JsonProperty("address_zip_check")]
        public object AddressZipCheck { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("dynamic_last4")]
        public object DynamicLast4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("tokenization_method")]
        public object TokenizationMethod { get; set; }
    }
}