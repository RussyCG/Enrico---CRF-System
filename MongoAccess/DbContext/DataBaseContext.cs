using MongoAccess.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoAccess.DbContext
{
    public class DataBaseContext
    {
        const string DB_NAME = "crfdb";        
        static MongoClient client = new MongoClient("mongodb://projects.belgiumcampus.ac.za:27017");

        static IMongoDatabase GetDB() {

            return client.GetDatabase(DB_NAME);

        }

        public static async Task<List<string>> ListCollections() {

            List<string> collectionNames = new List<string>();
            var collections = await GetDB().ListCollectionsAsync();
            await collections.ForEachAsync(
                    x => collectionNames.Add((string)x.GetValue("name"))
                );
            return collectionNames;

        }

        static IMongoCollection<BsonDocument> GetCollection(string name) {
            
            return GetDB().GetCollection<BsonDocument>(name);

        }

        public static async Task<bool> InsertSingle(string collectionName, BsonDocument doc) {

            try {
                var collection = GetCollection(collectionName);
                await collection.InsertOneAsync(doc);
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        public static async Task<bool> MultiInsertAsync(string collectionName, List<BsonDocument> docs) {

            try {
                var collection = GetCollection(collectionName);
                await collection.InsertManyAsync(docs);
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        public static async Task<List<BsonDocument>> GetAllInCollection(string collectionName)
        {
            List<BsonDocument> docs = new List<BsonDocument>();
            var collection = GetCollection(collectionName);
            using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(FilterDefinition<BsonDocument>.Empty)) {
                while (await cursor.MoveNextAsync()) {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (var item in batch) {
                        docs.Add(item);
                    }
                }
                return docs;
            }
            
        }

        public static async Task<List<BsonDocument>> GetAllInCollectionFiltered(string collectionName, BsonDocument filter)
        {
            List<BsonDocument> docs = new List<BsonDocument>();
            var collection = GetCollection(collectionName);
            using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(filter)) {
                while (await cursor.MoveNextAsync()) {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (var item in batch) {
                        docs.Add(item);
                    }
                }
                return docs;
            }
        }

        public static BsonDocument JsonToBson(string json) {

            var bson = BsonDocument.Parse(json);            
            return bson;

        }

        public static BsonDocument KeyValuePairsToBson(List<KeyValuePair<string, object>> data) {

            BsonDocument doc = new BsonDocument();
            foreach (var item in data) {
                doc.Add(item.Key, BsonValue.Create(item.Value));
            }
            return doc;

        }
    }
}
