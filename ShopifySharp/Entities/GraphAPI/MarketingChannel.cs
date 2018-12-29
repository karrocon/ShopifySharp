using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketingChannel
    {
        DISPLAY,
        EMAIL,
        REFERRAL,
        SEARCH,
        SOCIAL
    }
}