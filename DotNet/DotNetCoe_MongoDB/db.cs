using MongoDB.Bson;
using MongoDB.Driver;
using System;


namespace myPro.App
{

    public class DB
    {
        MongoClient client;

        public MongoClient GetOrCreateDBClinet()
        {
            if (client == null)
            {
                client = new MongoClient("mongodb://127.0.0.1:27017");
            }
            return client;
        }

        public IMongoDatabase GetOrCreateDatabase(MongoClient client,string database)
        {
           return client.GetDatabase(database);
        }

        public IMongoCollection<T> GetOrCreateCollection<T>(IMongoDatabase database, string collection)
        {
           return database.GetCollection<T>(collection);

        }
    }

}