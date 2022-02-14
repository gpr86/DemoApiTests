using System.Text.Json.Serialization;

namespace DemoApiTests.Models.CoronavirusSamartable
{
    public class Location
    {
        [JsonPropertyName("long")]
        public double Longitude {get;set;}
        public string CountryOrRegion {get;set;}
        public string ProvinceOrState {get;set;}
        public string County {get;set;}
        public string IsoCode {get;set;}
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
    }
}
