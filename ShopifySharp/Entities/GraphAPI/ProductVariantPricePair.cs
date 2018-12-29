using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ProductVariantPricePair
    {
        public Money CompareAtPrice { get; set; }
        public Money Price { get; set; }
    }
}