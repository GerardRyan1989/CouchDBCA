﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ServiceHistory
    {
        [JsonProperty("Garage Name")]
        public string GarageName { get; set; }

        [JsonProperty("Miles Service At")]
        public int MilesServicedAt { get; set; }

        [JsonProperty("Date Serviced")]
        public DateTime ServiceDate { get; set; }


        public ServiceHistory(string gar, int miles, DateTime serv)
        {
            this.GarageName = gar;
            this.MilesServicedAt = miles;
            this.ServiceDate= serv;
        }
    }
}
