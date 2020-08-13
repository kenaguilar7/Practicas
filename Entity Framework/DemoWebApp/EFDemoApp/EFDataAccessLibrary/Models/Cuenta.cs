using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    [Table("Cuenta")]
    public class Cuenta : CuentaBase
    {
        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

    }
}
