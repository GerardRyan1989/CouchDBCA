using CouchDBCA;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientView
    {

        public async Task<List<Car>> getView(string make, string model)
        {
            ViewQueryResponse<Car[]> response;
            string[] keys = new string[2];

            keys[0] = make;
            keys[1] = model;

            List<Car> cars = new List<Car>();

            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {
                var query = new QueryViewRequest("carViews", "byMake").Configure(querie => querie.Keys<string[]>(keys).IncludeDocs(true)
               .Reduce(false));

                response = await db.Views.QueryAsync<Car[]>(query);

                for (int i = 0; i < response.RowCount; i++)
                {
                    cars.Add(JsonConvert.DeserializeObject<Car>(response.Rows[i].IncludedDoc));
                }

                var result = cars;

                return result;
            }

            
        }
       
    }
}
