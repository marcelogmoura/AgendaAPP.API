using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Repositories;
using MongoDB.Driver;

namespace AgendaApp.Infra.Data.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository() : base("Tarefas")
        { 
        }
        public List<Tarefa> get(DateTime dataMin, DateTime dataMax, Guid pessoaId)
        {
            var filter = Builders<Tarefa>.Filter.Eq(t => t.PessoaId, pessoaId)
                & Builders<Tarefa>.Filter.Gte(t => t.DataHora, dataMin)
                & Builders<Tarefa>.Filter.Lte(t => t.DataHora, dataMax);

            var sort = Builders<Tarefa>.Sort.Ascending(t => t.DataHora);

            return _context.Collection.Find(filter).Sort(sort).ToList();
        }
    }
}
