using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketingTactic
    {
        ABANDONED_CART,
        AD,
        AFFILIATE,
        DIRECT,
        LINK,
        LOYALTY,
        MESSAGE,
        NEWSLETTER,
        NOTIFICATION,
        POST,
        RETARGETING,
        SEO,
        STOREFRONT_APP,
        TRANSACTIONAL
    }
}