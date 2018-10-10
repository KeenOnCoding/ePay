using Newtonsoft.Json;

namespace ePay.Models
{
    public class Options
    {
        [JsonProperty("optional")]
        public bool? Optional { get; set; } = null;

        [JsonProperty("optional_selected")]
        public bool? OptionalSelected { get; set; } = null;

        [JsonProperty("multichoice_enabled")]
        public bool? MultichoiceEnabled { get; set; } = null;

        [JsonProperty("multichoice_selected")]
        public bool? MultichoiceSelected { get; set; } = null;
    }
}