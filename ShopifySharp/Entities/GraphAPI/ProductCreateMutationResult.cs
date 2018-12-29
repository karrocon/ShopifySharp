using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ProductCreateMutationResult
    {
        public Product Product { get; set; }
        public Shop Shop { get; set; }
        public IEnumerable<UserError> UserErrors { get; set; }
    }
}