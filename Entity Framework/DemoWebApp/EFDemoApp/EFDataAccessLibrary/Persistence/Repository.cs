using EFDataAccessLibrary.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EFDataAccessLibrary.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;


        public Repository(DbContext context)
        {
            _Context = context;
        }

        public TEntity GetById(int id)
        {
            return _Context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _Context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] incluideProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }
    }
}
