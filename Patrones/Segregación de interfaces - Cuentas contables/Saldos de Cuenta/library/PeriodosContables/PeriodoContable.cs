using Saldos_de_Cuenta.library.Asientos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Saldos_de_Cuenta.library.PeriodosContables
{
    public class PeriodoContable : IPeriodoContable
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public Boolean Cerrada { get; set; }

        public List<IAsiento> Asientos { get; set; }

        public int Anyo { get; set; }

        public int Mes { get; set; }

        //public PeriodoContable(List<IAsiento> asientos)
        //{
        //    this.Asientos = asientos;
        //}

        public override string ToString()
        {
            return $"{MonthName(Fecha.Month)} {Fecha.Year}";
        }

        private string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }
    }
}
