using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _entities = new List<T>();
        
        public T CreateItem()
        {
            return new T();
        }

        public T GetById(int id)
        {
            return _entities.Single(item => item.Id == id); 
        }

        public void Add(T entity)
        {
            entity.Id = _entities.Count + 1; 
            _entities.Add(entity);
        }

        public void Save()
        {
            foreach (var entity in _entities)
                Console.WriteLine(entity);
        }
    }
}
