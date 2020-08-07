using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Repository;
using EFDataAccessLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonRepository _db;

        public IndexModel(ILogger<IndexModel> logger, IPersonRepository db)
        {
            _logger = logger;
            _db = db;
            Insert(); 
        }

        public void Insert()
        {
            Person person = new Person();
            person.FirstName = "Kenneth";
            person.LastName = "Aguilar";
            person.Age = 24;

            _db.Add(person);
            
        }
    }
}
