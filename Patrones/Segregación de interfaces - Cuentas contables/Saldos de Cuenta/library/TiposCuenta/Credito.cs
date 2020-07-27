namespace Saldos_de_Cuenta.library.TiposCuenta
{
    public class Credito : IComportamiento
    {
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