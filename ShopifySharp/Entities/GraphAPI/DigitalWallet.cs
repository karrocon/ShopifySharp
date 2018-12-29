using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DigitalWallet
    {
        ANDROID_PAY,
        APPLE_PAY,
        GOOGLE_PAY,
        SHOPIFY_PAY
    }
}