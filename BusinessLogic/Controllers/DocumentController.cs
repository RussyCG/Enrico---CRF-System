﻿using MongoAccess.DbContext;
using MongoAccess.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controllers
{
    public class DocumentController 
    {
        
        DataBaseContext db = new DataBaseContext();

        //public async Task POST(BsonDocument[] documents)
        //{
        //    List<BsonDocument> docs = documents.ToList();
        //    await db.InsertAsync(docs);
        //}

        public async Task<string> Get()
        {
            var val = await DataBaseContext.GetAllInCollection("test");
            return val[7].ToString();
        }

        public async Task<List<string>> POST(string values) {
            var doc = DataBaseContext.JsonToBson(values);
            await DataBaseContext.InsertSingle("test",doc);
            return await DataBaseContext.ListCollections();
        }
    }
}
