using MyCouch;
using System;


namespace DataLayer
{
    public class RestClientDelete
    {
        public async void DeleteObject(string _id, string _rev)
        {
            using (var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
                
                var response = await db.DeleteAsync(_id , _rev);

                Console.Write(response.ToString());

            }
        }
    }
}
