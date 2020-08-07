using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.Core;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IUnitOfWork _unitOfWork;

        public PersonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            //Create();
            var personList = _unitOfWork.PeopleRepository.GetAll();
            return personList; 
        }


        public void Create()
        {
            Person person = new Person
            {
                FirstName = "Kenneth",
                LastName = "Aguilar",
                Age = -80
            };

            var emails = new List<Email>()
            {
                new Email(){EmailAddress="kenaguilar.steve@gmail.com" }
            };

            var address = new List<Address>()
            {
                new Address(){City = "San José", StreetAddress = "100 metros del parque" }
            };

            person.Addresses = address;
            person.EmailAddresses = emails;

            _unitOfWork.PeopleRepository.Add(person);
            _unitOfWork.Complete();

        }

    }
}
