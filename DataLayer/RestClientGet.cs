using CouchDBCA;
using MyCouch;

using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientGet
    {
        public async Task<Car> GetObject(string id)
        {
            using (var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
           
            var response = await db.GetByIdAsync<Car>(id);
    
            return response;
    
            }
        }


    public async Task<Car> carSearch(string make, string model)
    {
            using(var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
          
                var response = await db.GetByIdAsync<Car>(model);
   
                return response;
   
            }

     }
    }

    
}
