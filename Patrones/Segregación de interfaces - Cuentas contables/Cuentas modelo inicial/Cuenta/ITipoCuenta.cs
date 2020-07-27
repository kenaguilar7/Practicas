using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas_modelo_inicial.Cuenta
{
    public interface ITipoCuenta
    {
        NombreTipoCuenta TipoCuenta { get; }

        Comportamiento Comportamiento { get; }

        decimal SaldoActual(decimal saldo, decimal debito, decimal credito);

        decimal SaldoMensual(decimal debito, decimal credito);
    }
}
