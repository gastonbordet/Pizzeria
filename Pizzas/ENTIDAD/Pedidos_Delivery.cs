using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Pedidos_Delivery
    {
        public String IdPedidoDelivery { get; set; }
        public String Cliente { get; set; }
        public int Telefono { get; set; }
        public String Direccion { get; set; }
        public String IdEmpleado { get; set; }
        public int Facturado { get; set; } // 0=NO 1=SI

        public Pedidos_Delivery() { }
    }
}
