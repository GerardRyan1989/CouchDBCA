﻿using CouchDBCA;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestClientGet
    {
        public async Task<Person> GetObject(string id)
        {
            using (var db = new MyCouchStore("http://localhost:5984", "cars"))
            {
               
                var response = await db.GetByIdAsync<Person>(id);

                return response;

            }
        }
    }

    
}
