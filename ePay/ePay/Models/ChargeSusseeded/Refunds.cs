﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace ePay.ChargeSusseeded
{
    public class Refunds
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public List<object> Data { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}