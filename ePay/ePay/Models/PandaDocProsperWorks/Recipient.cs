using Newtonsoft.Json;

namespace ePay.Models
{
    public class Recipient
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("recipient_type")]
        public string RecipientType { get; set; }

        [JsonProperty("has_completed")]
        public bool HasCompleted { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}