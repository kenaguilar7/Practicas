using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Person> PeopleRepository { get; }
        int Complete(); 
    }
}
