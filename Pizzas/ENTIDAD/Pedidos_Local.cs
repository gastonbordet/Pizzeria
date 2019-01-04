using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Pedidos_Local
    {
        public String IdPedidoLocal { get; set; }
        public String Cliente { get; set; }
        public int Mesa { get; set; }
        public String IdEmpleado { get; set; }
        public int Facturado { get; set; } // 0 = no 1 = Si

        public Pedidos_Local() { }
    }
}
