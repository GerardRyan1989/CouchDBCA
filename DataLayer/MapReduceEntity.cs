using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MapReduceEntity
    {
        [JsonProperty("id")]
        public string id;

        [JsonProperty("includedDoc")]
        public string IncludedDoc;

        [JsonProperty("Key")]
        public object key;

        [JsonProperty("value")]
        public int value;
    }
}
