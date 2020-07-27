using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saldos_de_Cuenta.library
{
    public class CuentaConSaldo : CuentaBase, ICuentaConSaldo
    {
        public List<IEntradaAsiento> EntradaAsientos { get; set;  }

        public CuentaConSaldo(List<IEntradaAsiento> entradaAsientos)
        {
            EntradaAsientos = entradaAsientos; 
        }

        public decimal Creditos(Moneda moneda)
        {
            throw new NotImplementedException();
        }

        public bool Cuadrada()
        {
            throw new NotImplementedException();
        }

        public decimal Debitos(Moneda moneda)
        {
            var output = EntradaAsientos.Where(x => x.Comportamiento is Debito && x.Moneda == moneda).Sum(x => x.Monto);
            return output; 
        }

        public decimal SaldoActual(Moneda moneda)
        {
            throw new NotImplementedException();
        }

        public decimal SaldoAnterior(Moneda moneda)
        {
            throw new NotImplementedException();
        }

        public decimal SaldoMensual(Moneda moneda)
        {
            throw new NotImplementedException();
        }

        public bool TieneMovimientos()
        {
            throw new NotImplementedException();
        }
    }
}
