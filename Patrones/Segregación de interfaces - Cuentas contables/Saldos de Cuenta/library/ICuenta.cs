namespace Saldos_de_Cuenta.library {

    public interface ICuenta {
        
        bool Active { get; set; }
        
        string Detalle { get; set; }

        bool Editable { get; set; }

        int Id { get; set; }

        IndicadorCuenta Indicador { get; set; }

        string Nombre { get; set; }

        int IdPadre { get; set; }

        string PathDirection { get; set; }


        string ToString ();
    }
}