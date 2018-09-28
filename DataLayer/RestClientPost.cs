using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using DataLayer;

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

                List<string> extras = new List<string>();
                extras.Add("Alloy Wheels");
                extras.Add("Leather Seats");
                extras.Add("Sun Roof");
                extras.Add("Tinted Windows");

                List<ServiceHistory> services = new List<ServiceHistory>();
                services.Add(new ServiceHistory("Ryans", 10000, DateTime.Now));
                services.Add(new ServiceHistory("Ryans", 20000, DateTime.Now));
                services.Add(new ServiceHistory("Ryans", 30000, DateTime.Now));
                services.Add(new ServiceHistory("Ryans", 40000, DateTime.Now));


                var car = new Car()
                {
                    _id = "95-C-18337",
                    Make = "Ferrari",
                    Model = "F50-Spider",
                    EngineSize = 3.5,
                    Extras = extras,
                    numofOwners = 5,
                    PrevOwner = new PreviousOwners
                    {
                        Name = "Gerard Ryan",
                        Address = "11 Feale Drive Listowel Co.Kerry",
                        YearsOwned = 2
                    },
                    Transmission = "Manual",
                    SafetyRating = 5,
                    ServHistory = services
                 };

                var response = await db.Entities.PostAsync(car);
               
                Console.Write(response.ToString());

            }
        }
    }


}
