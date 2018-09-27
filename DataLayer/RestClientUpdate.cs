using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientUpdate
    {
        public async void ObjectUpdate()
        {
            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {

                List<string> personchar = new List<string>();
                personchar.Add("Happy/Sad");
                personchar.Add("Tall/Small");
                personchar.Add("Skinny/Fat");
                personchar.Add("Random/Chronalogical");


                var person = new Person()
                {
                    _id = "5f9af3224b90c15568d982b820000562",
                    _rev = "1-4f60388fb425e1b400da11815d2321ed",
                    name = "gerard",
                    age = "37",
                    characteristics = personchar,
                    personcar = new Car
                    {
                        make = "toyota MR2",
                        engineSize = 2.0,
                        fuelType = "Diesel"
                    }

                };

                var response = await db.Entities.PutAsync(person);

                Console.Write(response.ToString());

            }
        }
    }
}
