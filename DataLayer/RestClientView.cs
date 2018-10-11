using CouchDBCA;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientView
    {

        public async Task<ViewQueryResponse<Car[]>> getView()
        {
            ViewQueryResponse<Car[]> result;
            using (var db = new MyCouchClient("http://localhost:5984", "cars"))
            {
                var query = new QueryViewRequest("carViews", "byMake").Configure(querie => querie
               .Reduce(false));

                result = await db.Views.QueryAsync<Car[]>(query);
            }

            return result;
        }
       
    }
}
