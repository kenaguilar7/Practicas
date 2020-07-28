using Saldos_de_Cuenta.library.TiposCuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saldos_de_Cuenta.library
{
    public interface ISaldo
    {
        decimal Debitos(Moneda moneda);
        decimal Creditos(Moneda moneda);
        bool TieneMovimientos();
        bool Cuadrada();
    }
}
