using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class MailingAddress : INode
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public CountryCode? CountryCodeV2 { get; set; }
        public string FirstName { get; set; }
        public IEnumerable<string> Formatted { get; set; }
        public string FormattedArea { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public string LastName { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string ProvinceCode { get; set; }
        public string Zip { get; set; }
    }
}