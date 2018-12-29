using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Money
    {
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
        [JsonProperty("currencyCode")]
        public CurrencyCode? CurrencyCode { get; set; }
    }
}