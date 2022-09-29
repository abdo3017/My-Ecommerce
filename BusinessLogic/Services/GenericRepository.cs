using InfraStructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic.Services
{

    public abstract class GenericRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MyDbContext Context;
        public GenericRepository(MyDbContext _Context)
        {
            Context = _Context;
        }


        public virtual T Add(T entity)
        {
            return Context
                .Add(entity)
                .Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
          
            return Context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public virtual T GetById(int id)
        {
            return Context.Find<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Context.Set<T>()
                .ToList();
        }

        public virtual T Update(T entity)
        {

            return Context.Update(entity)
                .Entity;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public virtual T Delete(T entity)
        {
            return Context.Remove(entity)
               .Entity;
        }

        public T FindOne(Expression<Func<T, bool>> predicate)
        {
             return Context.Set<T>().FirstOrDefault(predicate);
        }
    }
}
