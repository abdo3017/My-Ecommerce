using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLogic.Services
{
    public interface IBaseRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T FindOne(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
