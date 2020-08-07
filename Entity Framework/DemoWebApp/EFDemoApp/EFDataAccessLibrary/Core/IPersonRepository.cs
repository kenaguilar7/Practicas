using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Services
{
    public interface IPersonRepository : IRepository<Person>
    {
        IEnumerable<Person> GetOldersPeople(); 

    }
}
