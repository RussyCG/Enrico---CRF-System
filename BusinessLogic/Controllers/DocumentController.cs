using MongoAccess.DbContext;
using MongoAccess.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controllers
{
    public class DocumentController 
    {
        //[HttpPost]
        //[Route("api/course")]
        //public void async POST(Document Document)
        //{
        //     await 
        //}
        DataBaseContext db = new DataBaseContext();

        public void POST(BsonDocument[] documents)
        {
            List<BsonDocument> docs = documents.ToList();
            db.InsertAsync(docs);
        }
    }
}
