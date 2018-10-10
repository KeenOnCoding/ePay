using Newtonsoft.Json;

namespace ePay.Models
{
    public class AssignedTo
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
        public bool has_completed { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}