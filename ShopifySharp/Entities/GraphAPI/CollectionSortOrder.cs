using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CollectionSortOrder
    {
        ALPHA_ASC,
        ALPHA_DESC,
        BEST_SELLING,
        CREATED,
        CREATED_DESC,
        MANUAL,
        PRICE_ASC,
        PRICE_DESC
    }
}