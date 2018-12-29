using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ResourceFeedback
    {
        public IEnumerable<AppFeedback> Details { get; set; }
        public string Summary { get; set; }
    }
}