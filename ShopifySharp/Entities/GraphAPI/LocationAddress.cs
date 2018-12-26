using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class LocationAddress
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public IEnumerable<string> Formatted { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string ProvinceCode { get; set; }
        public string Zip { get; set; }
    }
}