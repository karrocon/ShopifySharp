using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CollectionRuleSet
    {
        public bool? AppliedDisjunctively { get; set; }
        public IEnumerable<CollectionRule> Rules { get; set; }
    }
}