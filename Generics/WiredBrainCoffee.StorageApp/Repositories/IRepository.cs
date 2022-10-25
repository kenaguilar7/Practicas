using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll(); 
        T GetById(int id);
    }

    public interface IWriteRepository<in T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Save();
    }

    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
    {
        //T CreateItem();
    }
}