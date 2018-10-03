using CouchDBCA;
using MyCouch;
using System;

namespace DataLayer
{
    public class RestClientUpdate
    {
        public async void ObjectUpdate(Car car)
        {
         
          using (var db = new MyCouchClient("http://localhost:5984", "cars"))
          {      
              var response = await db.Entities.PutAsync(car);
        
              Console.Write(response.ToString());     
           }
        }
    }
}
