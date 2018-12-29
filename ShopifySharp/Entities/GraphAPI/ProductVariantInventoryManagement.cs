using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductVariantInventoryManagement
    {
        FULFILLMENT_SERVICE,
        NOT_MANAGED,
        SHOPIFY
    }
}