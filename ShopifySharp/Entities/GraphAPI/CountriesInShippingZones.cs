using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CountriesInShippingZones
    {
        public IEnumerable<CountryCode> CountryCodes { get; set; }
        public bool? IncludeRestOfWorld { get; set; }
    }
}