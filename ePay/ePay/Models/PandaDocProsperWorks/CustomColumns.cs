using Newtonsoft.Json;

namespace ePay.Models
{
    public class CustomColumns
    {
        [JsonProperty("Period")]
        public string Period { get; set; } = "month";

    }
}