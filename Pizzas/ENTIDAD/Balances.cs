using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Balances
    {
        public float Monto { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public int Tipo { get; set; } // 1: Ingreso || -1: Egreso

        public Balances(float total, int dia, int mes, int año, int tipo)
        {
            Monto = total;
            Dia = dia;
            Mes = mes;
            Año = año;
            Tipo = tipo;
        }
    }
}
