using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class Data
    {
        [JsonProperty("object")]
        public MyObject Object { get; set; }
    }
}