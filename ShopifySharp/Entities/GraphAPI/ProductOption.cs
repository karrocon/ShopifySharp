using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ProductOption : INode
    {
        // This should validate as Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Position { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}