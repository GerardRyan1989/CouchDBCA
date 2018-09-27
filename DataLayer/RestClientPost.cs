using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class RestClientPost
    {
       public RestClientPost()
       {

       }

       public async void postObject()
       {
            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {

                List<string> personchar = new List<string>();
                personchar.Add("Happy");
                personchar.Add("Tall");
                personchar.Add("Skinny");
                personchar.Add("Random");


                var person = new Person()
                {
                    _id = "95-c-18337",
                    name = "ger",
                    age = "28",
                    characteristics = personchar,
                    personcar = new Car
                    {
                        make = "toyota",
                        engineSize = 2.0,
                        fuelType = "Diesel"
                    }
                    
                };

                var response = await db.Entities.PostAsync(person);
               
                Console.Write(response.ToString());

            }
        }
    }


}
