using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Detalles_Pedido
    {
        public String IdPedido { get; set; }
        public String NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public Detalles_Pedido() { }
    }
}
