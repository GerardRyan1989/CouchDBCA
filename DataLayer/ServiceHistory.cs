using Newtonsoft.Json;
using System;

namespace DataLayer
{
    public class ServiceHistory
    {
        [JsonProperty("garageName")]
        public string GarageName { get; set; }

        [JsonProperty("milesServiceAt")]
        public string MilesServicedAt { get; set; }

        [JsonProperty("dateServiced")]
        public DateTime ServiceDate { get; set; }


        public ServiceHistory(string gar, string miles, DateTime serv)
        {
            this.GarageName = gar;
            this.MilesServicedAt = miles;
            this.ServiceDate= serv;
        }
    }
}
