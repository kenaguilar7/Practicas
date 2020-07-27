using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta.library.MovientoACuenta
{
    public interface IEntradaAsiento
    {
        int Id { get; set; }

        //ICuenta CuentaDeAsiento { get; set; }

        string Referencia { get; set; }

        string Detalle { get; set; }

        IComportamiento Comportamiento { get; set; }

        DateTime FechaFactura { get; set; }

        Moneda Moneda { get; set; }

        decimal Monto { get; set; }

        decimal MontoTipoCambio { get; set; }
    }
}
