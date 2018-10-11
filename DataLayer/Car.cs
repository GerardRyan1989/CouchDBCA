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

        [JsonProperty("Make")]
        public string Make { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("EngineSize")]
        public double EngineSize { get; set; }

        [JsonProperty("FuelType")]
        public string FuelType { get; set; }

        [JsonProperty("Transmission")]
        public string Transmission { get; set; }

        [JsonProperty("Extras")]
        public List<string> Extras { get; set; }

        [JsonProperty("SafetyRating")]
        public int SafetyRating { get; set; }

        [JsonProperty("SalesPrice")]
        public int SalesPrices { get; set; }

        [JsonProperty("NumberOfPreviousOwners")]
        public int numofOwners { get; set; }

        [JsonProperty("Mileage")]
        public int mileage { get; set; }

        [JsonProperty("PreviousOwner")]
        public PreviousOwners PrevOwner { get; set; }

        [JsonProperty("ServiceHistory")]
        public List<ServiceHistory> ServHistory{get; set;}
    }
}
