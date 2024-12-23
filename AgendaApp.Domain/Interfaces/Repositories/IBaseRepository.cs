using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);
        void Delete(T obj);

        List<T> GetAll();
        T? GetById(Guid id);

    }
}
