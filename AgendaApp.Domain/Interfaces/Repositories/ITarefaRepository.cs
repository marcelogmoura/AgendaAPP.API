using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;

namespace AgendaApp.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository : IBaseRepository<Tarefa>
    {
        List<Tarefa> get(DateTime dataMin, DateTime dataMax, Guid pessoaId);
    }
}
