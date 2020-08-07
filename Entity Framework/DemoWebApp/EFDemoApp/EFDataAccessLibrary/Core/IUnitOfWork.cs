using EFDataAccessLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IPersonRepository PeopleRepository { get; }
        int Complete(); 
    }
}
