using Newtonsoft.Json;

namespace ePay.Models
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public object Cost { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public object Discount { get; set; }

        [JsonProperty("tax_first")]
        public object TaxFirst { get; set; }

        [JsonProperty("tax_second")]
        public object TaxSecond { get; set; }

        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; } = new Options();

        [JsonProperty("custom_fields")]
        public CustomFields CustomFields { get; set; } = null;

        [JsonProperty("custom_columns")]
        public CustomColumns CustomColumns { get; set; }
    }
}