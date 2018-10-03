using CouchDBCA;
using MyCouch;
using System;

namespace DataLayer
{
    public class RestClientPost
    {
       public RestClientPost()
       {

       }

       public async void postObject(Car car)
       {
            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {
                var response = await db.Entities.PostAsync(car);
               
                Console.Write(response.ToString());
            }
        }
    }


}
