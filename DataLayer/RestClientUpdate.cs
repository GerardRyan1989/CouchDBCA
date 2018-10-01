using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using DataLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
