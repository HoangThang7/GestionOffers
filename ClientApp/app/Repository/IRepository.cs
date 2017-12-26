using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionOffer.ClientApp.app.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> GetList();
        T GetById(int id);
        void Add(T entity);
        bool Delete(T entity);
        bool DeleteById(int id);
    }
}
