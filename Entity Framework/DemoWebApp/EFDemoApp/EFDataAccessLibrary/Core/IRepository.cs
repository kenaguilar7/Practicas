using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EFDataAccessLibrary.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(); 

        TEntity GetById(int id);
        
        void Insert(TEntity entity);
        
        void Update(TEntity entity);
        
        void Delete(TEntity entity);
        
     
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] incluideProperties);

    }
}
