using Newtonsoft.Json;

namespace ePay.ChargeSusseeded
{
    public class MyObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("application_fee")]
        public object ApplicationFee { get; set; }

        [JsonProperty("balance_transaction")]
        public string BalanceTransaction { get; set; }

        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("destination")]
        public object Destination { get; set; }

        [JsonProperty("dispute")]
        public object Dispute { get; set; }

        [JsonProperty("failure_code")]
        public object FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public object FailureMessage { get; set; }

        [JsonProperty("fraud_details")]
        public FraudDetails FraudDetails { get; set; }

        [JsonProperty("invoice")]
        public object Invoice { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("on_behalf_of")]
        public object OnBehalfOf { get; set; }

        [JsonProperty("order")]
        public object Order { get; set; }

        [JsonProperty("outcome")]
        public Outcome Outcome { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public Refunds Refunds { get; set; }

        [JsonProperty("review")]
        public object Review { get; set; }

        [JsonProperty("shipping")]
        public object Shipping { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("source_transfer")]
        public object SourceTransfer { get; set; }

        [JsonProperty("statement_descriptor")]
        public object StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transfer_group")]
        public object TransferGroup { get; set; }
    }
}