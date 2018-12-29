using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CollectionRule
    {
        public CollectionRuleColumn? Column { get; set; }
        public string Condition { get; set; }
        public CollectionRuleRelation? Relation { get; set; }
    }
}