using System;
using System.Collections.Generic;
using Saldos_de_Cuenta.library;
using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.TiposCuenta;

namespace Saldos_de_Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {

            IComportamiento comportamiento = new Debito();

            IEntradaAsiento entradaAsiento = new Registro(comportamiento)
            {
                Moneda = Moneda.colones,
                Monto = 5000,
                Id = 1
            };

            IEntradaAsiento entrada1 = new Registro(comportamiento)
            {
                Moneda = Moneda.colones,
                Monto = 5000,
                Id = 1
            }; 

            var lst = new List<IEntradaAsiento> { entradaAsiento, entrada1 };

            ICuentaConSaldo cuentaConSaldo = new CuentaConSaldo(lst);
            cuentaConSaldo.Nombre = "jaja conoce";

            ICuenta cc = cuentaConSaldo;

            decimal monto = cuentaConSaldo.Debitos(Moneda.colones);


            Console.WriteLine(cc.Nombre + $"{monto}");

        }
    }
}
