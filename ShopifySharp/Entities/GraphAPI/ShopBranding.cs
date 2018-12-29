using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopBranding
    {
        ROGERS,
        SHOPIFY,
        SHOPIFY_GOLD,
        SHOPIFY_PLUS
    }
}