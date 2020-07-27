using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas_modelo_inicial.Cuenta
{
    public class Cuenta : ICuenta
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int IdPadre { get; set; }

        public decimal SaldoAnteriorColones { get; set; }

        public decimal SaldoAnteriorDolares { get; set; }

        public decimal DebitosColones { get; set; }

        public decimal DebitosDolares { get; set; }

        public decimal CreditosColones { get; set; }

        public decimal CreditosDolares { get; set; }

        public string Detalle { get; set; }

        public bool Active { get; set; }

        public IndicadorCuenta Indicador { get; set; }

        public ITipoCuenta TipoCuenta { get; set; }

        public bool Editable { get; set; }

        public String PathDirection { get; set; }

        public bool Cuadrada { get; set; }

        public Cuenta(ITipoCuenta tipoCuenta)
        {
            TipoCuenta = tipoCuenta;
        }

        public decimal SaldoActualColones()
        {
            return TipoCuenta.SaldoActual(this.SaldoAnteriorColones, this.DebitosColones, this.CreditosColones);
        }

        public decimal SaldoMensualColones()
        {
            return TipoCuenta.SaldoMensual(DebitosColones, CreditosColones);
        }

        public decimal SaldoActualDolares()
        {
            return TipoCuenta.SaldoActual(SaldoAnteriorDolares, DebitosDolares, CreditosDolares);
        }

        public decimal SaldoMensualDolares()
        {
            return TipoCuenta.SaldoMensual(DebitosDolares, CreditosDolares);
        }

        public override string ToString()
        {
            return Nombre;
        }

        public bool CuentaConMovientos()
        {
            if (SaldoAnteriorColones == 0.00m && DebitosColones == 0.00m && CreditosColones == 0.00m)
                return false;
            else
                return true;
        }
    }
}
