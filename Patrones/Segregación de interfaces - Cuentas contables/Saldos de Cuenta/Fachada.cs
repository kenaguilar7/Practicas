using Saldos_de_Cuenta.library;
using Saldos_de_Cuenta.library.Asientos;
using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.PeriodosContables;
using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta
{
    public static class Fachada
    {
        public static IAsiento GetAsiento()
        {
            return new Asiento(GetPeriodoContable());
        }

        public static IPeriodoContable GetPeriodoContable()
        {
            return new PeriodoContable();
        }

        public static ICuentaConSaldo GetCuentaDebito()
        {
            return new CuentaConSaldo(GetComportamientoDebito());
        }

        public static ICuentaConSaldo GetCuentaCredito()
        {
            return new CuentaConSaldo(GetComportamientoCredito());
        }

        public static IEntradaAsiento GetEntradaAsientoDebito()
        {
            return new Registro(GetComportamientoDebito());
        }

        public static IEntradaAsiento GetEntradaAsientoCredito()
        {
            return new Registro(GetComportamientoCredito());
        }

        

        private static IComportamiento GetComportamientoDebito() => new Debito();
        private static IComportamiento GetComportamientoCredito() => new Credito();
    }
}
