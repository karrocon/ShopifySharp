using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CollectionRuleRelation
    {
        CONTAINS,
        ENDS_WITH,
        EQUALS,
        GREATER_THAN,
        LESS_THAN,
        NOT_CONTAINS,
        NOT_EQUALS,
        STARTS_WITH
    }
}