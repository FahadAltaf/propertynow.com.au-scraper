using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertynow.com.au_scraper
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Category
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ContactDetail
    {
        
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class DisplayValue
    {
        public string value { get; set; }
        public Range range { get; set; }
    }

    public class Feature
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string name { get; set; }
    }

    public class HydraMember
    {
       
        public Property property { get; set; }
        
        public ContactDetail contactDetail { get; set; }

    }

    public class HydraView
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }

        [JsonProperty("hydra:first")]
        public string hydrafirst { get; set; }

        [JsonProperty("hydra:last")]
        public string hydralast { get; set; }

        [JsonProperty("hydra:next")]
        public string hydranext { get; set; }
    }

    public class ListingAsset
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string url { get; set; }
        public string file { get; set; }
        public string format { get; set; }
        public int ordering { get; set; }
        public string path { get; set; }
    }

    public class ListingOpen
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public DateTime startAt { get; set; }
        public DateTime endAt { get; set; }
        public bool recurring { get; set; }
    }

    public class ListingPropertyDetail
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }

    public class MainImage
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string url { get; set; }
        public string file { get; set; }
        public string format { get; set; }
        public int ordering { get; set; }
        public string path { get; set; }
    }

    public class Pricing
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string displayType { get; set; }
        public DisplayValue displayValue { get; set; }
    }

    public class Property
    {
        
        public string displayAddress { get; set; }
    }

    public class PropertyType
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Range
    {
        public string max { get; set; }
        public string min { get; set; }
    }

    public class Root
    {
     

        [JsonProperty("hydra:member")]
        public List<HydraMember> hydramember { get; set; }

    }

    public class StatementOfInformation
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string url { get; set; }
        public string file { get; set; }
        public string format { get; set; }
        public int ordering { get; set; }
        public string path { get; set; }
    }


    public class DataModel
    {
        public string PropertyAddress { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
    }


}
