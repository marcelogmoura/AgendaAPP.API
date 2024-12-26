using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Interfaces.Repositories;
using AgendaApp.Infra.Data.Contexts;
using MongoDB.Driver;

namespace AgendaApp.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MongoDBContext<T> _context;
        private string v;

        public BaseRepository(MongoDBContext<T> context)
        {
            _context = context;
        }

        public BaseRepository(string v)
        {
            this.v = v;
        }

        public virtual void Add(T obj)
        {
            _context?.Collection?.InsertOne(obj);
        }

        public virtual void Delete(Guid id)
        {
            _context?.Collection?.DeleteOne(Builders<T>.Filter.Eq("_id", id));
        }

        public virtual List<T> GetAll()
        {
            return _context?.Collection?.Find(_ => true).ToList();
        }

        public void Update(Guid id, T obj)
        {
            _context?.Collection?.ReplaceOne(Builders<T>.Filter.Eq("_id", id), obj);
        }

        public virtual T? GetById(Guid id)
        {
            return _context?.Collection?.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefault();
        }
    }
}
