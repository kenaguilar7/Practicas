using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDataAccessLibrary.Persistence
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }

        public IEnumerable<Person> GetOldersPeople()
        {
            var output = GetPeopleContext.People.OrderByDescending(x => x.Age).Take(10);
            return output; 
        }

        public PeopleContext GetPeopleContext
        {
            get { return _Context as PeopleContext; }
        }
    }
}
