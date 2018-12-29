using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopCustomerAccountsSetting
    {
        DISABLED,
        OPTIONAL,
        REQUIRED
    }
}