namespace Saldos_de_Cuenta.library
{
    public interface ITipoCuenta
    {
        NombreTipoCuenta TipoCuenta { get; }
        
        Comportamiento Comportamiento { get; }
        
        decimal SaldoActual(decimal saldo, decimal debito, decimal credito);
        
        decimal SaldoMensual(decimal debito, decimal credito);
    }
}