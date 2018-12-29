using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ProductPriceRange
    {
        public Money MaxVariantPrice { get; set; }
        public Money MinVariantPrice { get; set; }
    }
}