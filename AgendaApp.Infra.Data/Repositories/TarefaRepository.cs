using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Repositories;

namespace AgendaApp.Infra.Data.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public List<Tarefa> get(DateTime dataMin, DateTime dataMax, Guid pessoaId)
        {
            throw new NotImplementedException();
        }
    }
}
