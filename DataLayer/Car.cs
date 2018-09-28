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

        [JsonProperty("Engine Size")]
        public double EngineSize { get; set; }

        [JsonProperty("Transmission")]
        public string Transmission { get; set; }

        [JsonProperty("Extras")]
        public List<string> Extras { get; set; }

        [JsonProperty("Safety Rating")]
        public int SafetyRating { get; set; }

        [JsonProperty("Number of Previous Owners")]
        public int numofOwners { get; set; }

        [JsonProperty("Previous Owner")]
        public PreviousOwners PrevOwner { get; set; }

        [JsonProperty("Service History")]
        public List<ServiceHistory> ServHistory{get; set;}

    }
}
