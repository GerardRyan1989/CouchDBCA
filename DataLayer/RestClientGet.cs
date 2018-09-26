using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientGet
    {
        public async Task<Person> GetObject()
        {
            using (var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
                var person = new Person()
                {
                    name = "ger",
                    age = "28"
                };


                var response = await db.GetByIdAsync<Person>("5f9af3224b90c15568d982b820000562");

                Console.Write(response.ToString());

                return response;

            }
        }
    }

    
}
