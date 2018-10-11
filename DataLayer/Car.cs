using DataLayer;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CouchDBCA
{
    public class Car
    {
        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("_rev")]
        public string _rev { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("engineSize")]
        public double EngineSize { get; set; }

        [JsonProperty("fuelType")]
        public string FuelType { get; set; }

        [JsonProperty("transmission")]
        public string Transmission { get; set; }

        [JsonProperty("extras")]
        public List<string> Extras { get; set; }

        [JsonProperty("safetyRating")]
        public int SafetyRating { get; set; }

        [JsonProperty("salesPrice")]
        public int SalesPrices { get; set; }

        [JsonProperty("numberOfPreviousOwners")]
        public int numofOwners { get; set; }

        [JsonProperty("mileage")]
        public int mileage { get; set; }

        [JsonProperty("previousOwner")]
        public PreviousOwners PrevOwner { get; set; }

        [JsonProperty("serviceHistory")]
        public List<ServiceHistory> ServHistory{get; set;}
    }
}
