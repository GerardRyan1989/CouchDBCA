using Newtonsoft.Json;
using System;

namespace DataLayer
{
    public class ServiceHistory
    {
        [JsonProperty("garageName")]
        public string GarageName { get; set; }

        [JsonProperty("milesServiceAt")]
        public int MilesServicedAt { get; set; }

        [JsonProperty("dateServiced")]
        public DateTime ServiceDate { get; set; }


        public ServiceHistory(string gar, int miles, DateTime serv)
        {
            this.GarageName = gar;
            this.MilesServicedAt = miles;
            this.ServiceDate= serv;
        }
    }
}
