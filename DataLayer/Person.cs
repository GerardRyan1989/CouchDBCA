using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouchDBCA
{
    public class Person
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("age")]
        public string age { get; set; }


        [JsonProperty("characterisitics")]
        public List<string> characteristics { get; set; }

        [JsonProperty("personCar")]
        public Car personcar { get; set; }

        //[JsonProperty("")]
        //[JsonProperty("")]
        //[JsonProperty("")]
        //[JsonProperty("")]
        //
        //[JsonProperty("")]
        //[JsonProperty("")]
        //[JsonProperty("")]
        //[JsonProperty("")]
        //[JsonProperty("")]



    }
}
