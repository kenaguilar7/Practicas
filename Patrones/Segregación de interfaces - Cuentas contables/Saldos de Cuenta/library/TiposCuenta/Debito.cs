namespace Saldos_de_Cuenta.library.TiposCuenta
{
    public class Debito : IComportamiento
    {
        public decimal SaldoActual(decimal SaldoAnteriorColones, decimal DebitosColones, decimal CreditosColones)
        {
            return (SaldoAnteriorColones + DebitosColones - CreditosColones);
        }

        public decimal SaldoMensual(decimal DebitosColones, decimal CreditosColones)
        {
            return (DebitosColones - CreditosColones);
        }
    }
}