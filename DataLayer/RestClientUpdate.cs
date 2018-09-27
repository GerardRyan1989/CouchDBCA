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
        public async void ObjectUpdate(string id)
        {

            RestClientGet restGet = new RestClientGet();
            var personReturned = await  restGet.GetObject(id);

            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {

                List<string> personchar = new List<string>();
                personchar.Add("Happy/Sad");
                personchar.Add("Tall/Small");
                personchar.Add("Skinny/Fat");
                personchar.Add("Random/Chronalogical");


                var person = new Person()
                {
                    _id = personReturned._id,
                    _rev = personReturned._rev,
                    name = "gerard",
                    age = "37",
                    characteristics = personchar,
                    personcar = new Car
                    {
                        make = "Toyota Levin",
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
