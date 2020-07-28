using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta.library.MovientoACuenta
{
    public class Registro : IEntradaAsiento
    {
        public int Id { get; set; }

        //public ICuenta CuentaDeAsiento { get; set; }

        public string Referencia { get; set; }

        public string Detalle { get; set; }

        public DateTime FechaFactura { get; set; }

        public Moneda Moneda { get; set; }

        public decimal Monto { get; set; }

        public IComportamiento Comportamiento { get;  set; }

        public decimal MontoTipoCambio { get; set; }

        public Registro(IComportamiento comportamiento)
        {
            Comportamiento = comportamiento;
        }

        public Registro()
        {
        }
    }
}
