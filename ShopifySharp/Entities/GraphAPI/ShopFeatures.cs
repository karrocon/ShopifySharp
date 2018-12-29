using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ShopFeatures
    {
        public bool? AvalaraAvatax { get; set; }
        public ShopBranding? Branding { get; set; }
        public bool? Captcha { get; set; }
        public bool? CaptchaExternalDomains { get; set; }
        public bool? DynamicRemarketing { get; set; }
        public bool? GiftCards { get; set; }
        public bool? HarmonizedSystemCode { get; set; }
        public bool? LiveView { get; set; }
        public bool? MultiLocation { get; set; }
        public bool? OnboardingVisual { get; set; }
        public bool? Reports { get; set; }
        public bool? ShowMetrics { get; set; }
        public bool? Storefront { get; set; }
    }
}