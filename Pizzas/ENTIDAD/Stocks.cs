using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Stock
    {
        public String IdProducto { get; set; }
        public String Nombre { get; set; }
        public int Cantidad { get; set; }

        public Stock(String nombre, int cant)
        {
            this.Nombre = nombre;
            this.Cantidad = cant;
            this.IdProducto = "";
        }
    }
}
