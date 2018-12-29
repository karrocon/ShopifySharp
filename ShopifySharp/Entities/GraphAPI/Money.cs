using Newtonsoft.Json;

namespace ShopifySharp.Graph
{
    public class Money
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("currencyCode")]
        public CurrencyCode CurrencyCode { get; set; }
    }
}