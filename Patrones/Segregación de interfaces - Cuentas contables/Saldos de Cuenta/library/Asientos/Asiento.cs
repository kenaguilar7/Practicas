using Saldos_de_Cuenta.library.MovientoACuenta;
using Saldos_de_Cuenta.library.PeriodosContables;
using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saldos_de_Cuenta.library.Asientos
{
    public class Asiento : AsientoBase, IAsiento
    {
        public List<IEntradaAsiento> EntradasDeAsiento { get; set; } = new List<IEntradaAsiento>(); 

        public Asiento(IPeriodoContable periodoContable)
            : base(periodoContable) { }

        public override string ToString()
        {
            return Convert.ToString(NumeroAsiento);
        }

        public decimal Debitos(Moneda moneda)
        {
            return EntradasDeAsiento.Where(x => x.Comportamiento is Debito).Sum(x => x.Monto);
        }

        public decimal Creditos(Moneda moneda)
        {
            return EntradasDeAsiento.Where(x => x.Comportamiento is Credito).Sum(x => x.Monto);
        }

        public bool TieneMovimientos()
        {
            if (EntradasDeAsiento.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Cuadrada()
        {
            var moneda = Moneda.colones;

            if (Debitos(moneda) == Creditos(moneda))
                return true;
            else
                return false;
        }
    }
}
