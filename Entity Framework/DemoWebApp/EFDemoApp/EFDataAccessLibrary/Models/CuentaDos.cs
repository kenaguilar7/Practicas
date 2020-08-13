using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    [Table("CuentaDos")]
    public class CuentaDos : CuentaBase
    {
        public DateTime DocDate { get; set; }

        public decimal Credit { get; set; }

    }
}
