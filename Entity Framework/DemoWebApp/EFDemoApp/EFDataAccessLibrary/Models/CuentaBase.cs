using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public abstract class CuentaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
    }
}
