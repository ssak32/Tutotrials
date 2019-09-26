using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInventory.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        T Find(T entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
