using Newtonsoft.Json;

namespace ePay.Models
{
    public class Field
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("assigned_to")]
        public AssignedTo AssignedTo { get; set; } = new AssignedTo();

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}