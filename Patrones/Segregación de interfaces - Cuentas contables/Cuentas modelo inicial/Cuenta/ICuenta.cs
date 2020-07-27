using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas_modelo_inicial.Cuenta
{
    public interface ICuenta
    {
        bool Active { get; set; }

        decimal CreditosColones { get; set; }

        decimal CreditosDolares { get; set; }

        bool Cuadrada { get; set; }

        decimal DebitosColones { get; set; }

        decimal DebitosDolares { get; set; }

        string Detalle { get; set; }

        bool Editable { get; set; }

        int Id { get; set; }

        IndicadorCuenta Indicador { get; set; }

        string Nombre { get; set; }

        int IdPadre { get; set; }

        string PathDirection { get; set; }

        decimal SaldoAnteriorColones { get; set; }

        decimal SaldoAnteriorDolares { get; set; }

        ITipoCuenta TipoCuenta { get; set; }

        bool CuentaConMovientos();

        decimal SaldoActualColones();

        decimal SaldoActualDolares();

        decimal SaldoMensualColones();

        decimal SaldoMensualDolares();

        string ToString();
    }
}
