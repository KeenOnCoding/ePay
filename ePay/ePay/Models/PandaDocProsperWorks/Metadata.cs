using Newtonsoft.Json;

namespace ePay.Models
{
    public class Metadata
    {
        [JsonProperty("prosperworks.contact_id")]
        public string ProsperworkscontactId { get; set; } = null;

        [JsonProperty("prosperworks.company_id")]
        public string ProsperworkscompanyId { get; set; } = null;

        [JsonProperty("prosperworks.deal_id")]
        public string ProsperworksdealId { get; set; } = null;
    }
}