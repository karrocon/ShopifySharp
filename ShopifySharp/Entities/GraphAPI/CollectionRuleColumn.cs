using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CollectionRuleColumn
    {
        TAG,
        TITLE,
        TYPE,
        VARIANT_COMPARE_AT_PRICE,
        VARIANT_INVENTORY,
        VARIANT_PRICE,
        VARIANT_TITLE,
        VARIANT_WEIGHT,
        VENDOR
    }
}