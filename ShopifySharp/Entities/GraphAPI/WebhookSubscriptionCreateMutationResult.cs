using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class WebhookSubscriptionCreateMutationResult
    {
        public IEnumerable<UserError> UserErrors { get; set; }
        public WebhookSubscription WebhookSubscription { get; set; }
    }
}