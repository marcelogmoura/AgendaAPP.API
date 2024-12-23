using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Repositories;

namespace AgendaApp.Infra.Data.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public Pessoa? Get(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public bool VerifyExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
