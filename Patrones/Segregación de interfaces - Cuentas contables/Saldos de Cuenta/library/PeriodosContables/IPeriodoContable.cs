using Saldos_de_Cuenta.library.Asientos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta.library.PeriodosContables
{
    public interface IPeriodoContable
    {
        public interface IPeriodoContable
        {
            int Id { get; set; }

            DateTime Fecha { get; set; }

            bool Cerrada { get; set; }

            List<IAsiento> Asientos { get; set; }

            int Anyo { get; set; }

            int Mes { get; set; }

            string ToString();
        }
    }
}
