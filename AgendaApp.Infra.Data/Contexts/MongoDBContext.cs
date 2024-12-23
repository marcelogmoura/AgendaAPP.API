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
    public class MongoDBContext
    {
        private IMongoDatabase? _database;

        public MongoDBContext()
        {
            var clientSettings = MongoClientSettings.FromUrl
                (new MongoUrl(MongoDBSettings.Host));

            var mongoClient = new MongoClient(clientSettings);

            _database = mongoClient.GetDatabase(MongoDBSettings.Database);
        }

        public IMongoCollection<Pessoa>? Pessoas
        {
            get
            {
                return _database?.GetCollection<Pessoa>("Pessoas");
            }
        }

        public IMongoCollection<Tarefa>? Tarefas
        {
            get
            {
                return _database?.GetCollection<Tarefa>("Tarefas");
            }
        }
    }
}
