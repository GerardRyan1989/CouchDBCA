using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientDelete
    {
        public async void DeleteObject()
        {
            using (var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
                
                var response = await db.DeleteAsync("a418b1458d77af73308717839f004ff8", "3-f8306ce81e7fdae544561221f9e49e01");

                Console.Write(response.ToString());

            }
        }
    }
}
