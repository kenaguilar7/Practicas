using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas_modelo_inicial.Cuenta
{
    public class Pasivo : ITipoCuenta
    {
        public NombreTipoCuenta TipoCuenta { get { return NombreTipoCuenta.Pasivo; } }

        public Comportamiento Comportamiento { get { return Comportamiento.Credito; } }

        public decimal SaldoActual(decimal saldo, decimal debito, decimal credito)
        {
            return (saldo - debito + credito);
        }

        public decimal SaldoMensual(decimal debito, decimal credito)
        {
            return (credito - debito);
        }
    }
}
