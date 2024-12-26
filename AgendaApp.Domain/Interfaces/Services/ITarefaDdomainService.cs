using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Dtos.Requests;
using AgendaApp.Domain.Dtos.Responses;

namespace AgendaApp.Domain.Interfaces.Services
{
    public interface ITarefaDdomainService
    {
        TarefaResponse Criar(TarefaRequest request, Guid pessoaId);

        TarefaResponse Alterar(TarefaRequest request, Guid tarefaId, Guid pessoaId);

        TarefaResponse Excluir(Guid tarefaId, Guid pessoaId);

        TarefaResponse Consultar(DateTime dataMin, DateTime dataFim, Guid pessoaId);

        TarefaResponse Obter(Guid tarefaId, Guid pessoaId);
    }
}
