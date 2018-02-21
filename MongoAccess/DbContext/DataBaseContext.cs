using MongoAccess.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoAccess.DbContext
{
    public class DataBaseContext
    {
        MongoClient client = new MongoClient("Projects.belgiumcampus:27017");

        public void Insert()
        {
            var database = client.GetDatabase("PotatoFactoryCRF");
            database.CreateCollection("");
        }



        public async Task<List<BsonDocument>> GetBsonDocuments(string id)
        {
            List<BsonDocument> Documents = new List<BsonDocument>();
            var database = client.GetDatabase("PotatoFactoryCRF");
            var collection = database.GetCollection<BsonDocument>(id);
            await collection.Find(new BsonDocument()).ForEachAsync(d => Documents.Add(d));
            return Documents;
        }

        public async Task<List<BsonDocument>> GetDocumentswithFilter(int value)
        {
            List<BsonDocument> Documents = new List<BsonDocument>();
            var filter = Builders<BsonDocument>.Filter.Eq("", value);
            var database = client.GetDatabase("PotatoFactoryCRF");
            var collection = database.GetCollection<BsonDocument>(value.ToString());
            var cursor = collection.Find(filter).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                 Documents.Add(document);
            }
            return Documents;
        }
    }
}
