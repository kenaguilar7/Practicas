using Saldos_de_Cuenta.library.PeriodosContables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta.library.Asientos
{
    public class AsientoBase
    {
        public int Id { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public bool Convalidado { get; set; }
        public DateTime FechaConvalidacion { get; set; }
        
        public EstadoAsiento Estado { get; set; }
        
        public IPeriodoContable PeriodoContable { get; set; }

        public AsientoBase(IPeriodoContable periodoContable)
        {
            PeriodoContable = periodoContable; 
        }

    }
}
