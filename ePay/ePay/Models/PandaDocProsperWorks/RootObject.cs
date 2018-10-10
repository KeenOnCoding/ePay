using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ePay.Models
{
    public class RootObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("autonumbering_sequence_name_prefix")]
        public string AutonumberingSequenceNamePrefix { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("created_by")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("tokens")]
        public List<Token> Tokens { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty("pricing")]
        public Pricing Pricing { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("recipients")]
        public List<Recipient> Recipients { get; set; }

        [JsonProperty("sent_by")]
        public SentBy SentBy { get; set; }

        [JsonProperty("grand_total")]
        public GrandTotal GrandTotal { get; set; }
    }
}