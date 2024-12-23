using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using AgendaApp.Infra.Data.Settings;
using MongoDB.Driver;

namespace AgendaApp.Infra.Data.Contexts
{
    public class MongoDBContext<T> where T : class
    {
        private readonly IMongoDatabase? _database;
        private readonly string? _collectionName;

        public MongoDBContext(string collectionName)
        {
            var clientSettings = MongoClientSettings.FromUrl
            (new MongoUrl(MongoDBSettings.Host));

            var mongoClient = new MongoClient(clientSettings);

            _database = mongoClient.GetDatabase(MongoDBSettings.Database);
            _collectionName = collectionName;
        }

        public IMongoCollection<T>? Collection
        {
            get
            {
                return _database?.GetCollection<T>(_collectionName);
            }
        }
    }
}
