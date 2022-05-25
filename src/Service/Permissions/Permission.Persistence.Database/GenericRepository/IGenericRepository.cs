using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Permission.Persistence.Database.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T obj);
    }
}
