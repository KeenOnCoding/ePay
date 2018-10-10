﻿using Newtonsoft.Json;

namespace ePay.Models
{
    public class CreatedBy
    {
        [JsonProperty("id")]
        public string Id
        { get; set; }

        [JsonProperty("email")]
        public string Email
        { get; set; }

        [JsonProperty("first_name")]
        public string FirstName
        { get; set; }

        [JsonProperty("last_name")]
        public string LastName
        { get; set; }

        [JsonProperty("avatar")]
        public object Avatar
        { get; set; }
    }
}