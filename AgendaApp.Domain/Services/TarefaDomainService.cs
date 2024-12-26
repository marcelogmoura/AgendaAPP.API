using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Dtos.Requests;
using AgendaApp.Domain.Dtos.Responses;
using AgendaApp.Domain.Interfaces.Services;

namespace AgendaApp.Domain.Services
{
    public class TarefaDomainService : ITarefaDdomainService
    {

        public TarefaResponse Criar(TarefaRequest request, Guid pessoaId)
        {
            throw new NotImplementedException();
        }
        public TarefaResponse Alterar(TarefaRequest request, Guid tarefaId, Guid pessoaId)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse Excluir(Guid tarefaId, Guid pessoaId)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse Consultar(DateTime dataMin, DateTime dataFim, Guid pessoaId)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse Obter(Guid tarefaId, Guid pessoaId)
        {
            throw new NotImplementedException();
        }
    }
}
