namespace Saldos_de_Cuenta.library.TiposCuenta
{
    public interface IComportamiento
    {
        decimal SaldoActual(decimal SaldoAnterior, decimal Debitos, decimal Creditos);
        
        decimal SaldoMensual(decimal DebitosColones, decimal CreditosColones);
    }
}