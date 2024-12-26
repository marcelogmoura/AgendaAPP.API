using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Repositories;
using AgendaApp.Infra.Data.Contexts;
using MongoDB.Driver;

namespace AgendaApp.Infra.Data.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository() : base("Pessoas")
        {
        }

        public Pessoa? Get(string email, string senha)
        {
            var filter = Builders<Pessoa>.Filter.Eq(p => p.Email, email) 
                & Builders<Pessoa>.Filter.Eq(p => p.Senha, senha);
                
            return _context.Collection.Find(filter).FirstOrDefault();
        }

        public bool VerifyExists(string email)
        {
            var filter = Builders<Pessoa>.Filter.Eq(p => p.Email, email);
            return _context.Collection.Find(filter).Any();
        }
    }
}
