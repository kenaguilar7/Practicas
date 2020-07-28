using System;
using System.Collections.Generic;
using Saldos_de_Cuenta.library;
using Saldos_de_Cuenta.library.Asientos;
using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.TiposCuenta;

namespace Saldos_de_Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {

            IEntradaAsiento entrada = Fachada.GetEntradaAsientoCredito();
            entrada.Monto = 500;
            entrada.Moneda = Moneda.colones;


            IAsiento asiento = Fachada.GetAsiento();
            asiento.EntradasDeAsiento.Add(entrada);
            ISaldo saldoAsiento = asiento;


            ICuentaConSaldo cuenta = Fachada.GetCuentaDebito();
            cuenta.EntradaAsientos.Add(entrada);
            ISaldo saldoCuenta = cuenta;


            Console.WriteLine($"{saldoAsiento.Creditos(Moneda.colones)} AND {saldoCuenta.Creditos(Moneda.colones)}");

        }
    }
}
