using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeightUnit
    {
        GRAMS,
        KILOGRAMS,
        OUNCES,
        POUNDS
    }
}