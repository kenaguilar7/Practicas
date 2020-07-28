using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.PeriodosContables;
using System;
using System.Collections.Generic;

namespace Saldos_de_Cuenta.library.Asientos
{
    public interface IAsiento : ISaldo
    {
        int Id { get; set; }

        int NumeroAsiento { get; set; }

        DateTime FechaRegistro { get; set; }

        EstadoAsiento Estado { get; set; }

        bool Convalidado { get; set; }

        DateTime FechaConvalidacion { get; set; }

        IPeriodoContable PeriodoContable { get; set; }

        List<IEntradaAsiento> EntradasDeAsiento { get; set; }


    }
}
