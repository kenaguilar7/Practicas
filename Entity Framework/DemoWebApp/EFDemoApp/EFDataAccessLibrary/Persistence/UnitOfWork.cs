using EFDataAccessLibrary.Core;
using EFDataAccessLibrary.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context; 
        public IPersonRepository PeopleRepository { get; private set; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            PeopleRepository = new PersonRepository(_context); 
        }

        public int Complete()
        {
            return _context.SaveChanges(); 
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }
    }
}
