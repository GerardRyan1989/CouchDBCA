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
            try
            {
                using (var db = new MyCouchClient("http://localhost:5984", "cars"))
                {
                    var response = await db.Entities.PostAsync(car);
                }
            }
            catch(Exception ex){
               
            }
           
        }
    }


}
