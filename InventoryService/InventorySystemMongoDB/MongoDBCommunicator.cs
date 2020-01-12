using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemMongoDB
{
    public class MongoDBCommunicator
    {
        private IMongoDatabase db;

        public MongoDBCommunicator(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public MongoDBCommunicator(string database,string connectionString) 
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(database);
        }
        public async Task InsertRecord<T>(string table,T record) 
        {
            var collection = db.GetCollection<T>(table);
            await collection.InsertOneAsync(record);
        }

        public async Task<T> GetRecord<T>(string table,string id) 
        {
            var collection = db.GetCollection<T>(table);
            Guid guid = new Guid(id);

            var filter = Builders<T>.Filter.Eq("_id", guid);


            return (await collection.FindAsync(filter)).FirstOrDefault();
        }

    }
}
