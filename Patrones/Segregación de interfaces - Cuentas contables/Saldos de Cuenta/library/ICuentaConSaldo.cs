using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.TiposCuenta;
using System.Collections.Generic;

namespace Saldos_de_Cuenta.library
{
    public interface ICuentaConSaldo : ICuenta, ISaldo
    {
        List<IEntradaAsiento> EntradaAsientos { get; set; } 

        decimal SaldoAnterior(Moneda moneda);

        decimal SaldoActual(Moneda moneda);

        decimal SaldoMensual(Moneda moneda);
    }
}