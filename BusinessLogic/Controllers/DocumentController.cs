using MongoAccess.DbContext;
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
        //public void async POST(Document Document)
        //{
        //     await 
        //}
        DataBaseContext db = new DataBaseContext();

        //public async Task POST(BsonDocument[] documents)
        //{
        //    List<BsonDocument> docs = documents.ToList();
        //    await db.InsertAsync(docs);
        //}

        public async Task<string> Get()
        {
            var val = await DataBaseContext.GetAllInCollection("test");
            return val[1].ToString();
        }

        public async Task<List<string>> Post(List<KeyValuePair<string, object>> values) {
            var doc = DataBaseContext.KeyValuePairsToBson(values);
            await DataBaseContext.InsertSingle("test",doc);
            return await DataBaseContext.ListCollections();
        }
    }
}
