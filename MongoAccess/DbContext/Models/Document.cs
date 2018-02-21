using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoAccess.Models
{
    public class Document
    {
        BsonDocument BsonDocument { get; set; }

        public Document(BsonDocument document)
        {
            this.BsonDocument = document;
        }

        public Document()
        {
            
        }
    }
}
