namespace Saldos_de_Cuenta.library
{
    public abstract class CuentaBase : ICuenta
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Detalle { get; set; }
        
        public bool Active { get; set; }
        
        public bool Editable { get; set; }
        
        public IndicadorCuenta Indicador { get; set; }
        
        public int IdPadre { get; set; }
        
        public string PathDirection { get; set; }
    }
}