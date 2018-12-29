using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetafieldValueType
    {
        INTEGER,
        JSON_STRING,
        STRING
    }
}