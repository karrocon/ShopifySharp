using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class AppFeedback
    {
        public App App { get; set; }
        public Link Link { get; set; }
        public IEnumerable<UserError> Messages { get; set; }
    }
}