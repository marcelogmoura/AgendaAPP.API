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
    public class PessoaDomainService : IPessoaDomainService
    {
        public CriarPessoaResponse Criar(CriarPessoaRequest request)
        {
            throw new NotImplementedException();
        }

        public AutenticarPessoaResponse Autenticar(AutenticarPessoaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
