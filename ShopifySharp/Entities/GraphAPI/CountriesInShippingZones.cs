using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class CountriesInShippingZones
    {
        public IEnumerable<CountryCode> CountryCodes { get; set; }
        public bool IncludeRestOfWorld { get; set; }
    }
}