using GestionOffers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionOffer.ClientApp.app.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        protected Context _context { get; set; }

        public BaseRepository(Context appDbContext)
        {
            _context = appDbContext;
        }


        public void Add(T entity)
        {
             _context.Set<T>().Add(entity);               
        }

        public bool DeleteById(int id)
        {
            var entity = GetById(id);
            var res = _context.Set<T>().Remove(entity);

            if (res == null) return false;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetList()
        {
            IEnumerable<T> res = _context.Set<T>().ToList();
            return res;
        }

        public T GetById(int id)
        {
            var res = _context.Set<T>().Find(id);
            return res;
        }

        public bool Delete (T entity) 
        {
            var res = _context.Set<T>().Remove(entity);

            if (res == null) return false;
            _context.SaveChanges();
            return true;
        }

        public T Search(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).First();
        }
    }
}
