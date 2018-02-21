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

        public Object Get(string id)
        {
            return db.GetBsonDocuments(id).ToJson();
        }
    }
}
