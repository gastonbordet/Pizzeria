using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DAO;
using ENTIDAD;
using NEGOCIO;

namespace Pizzas
{
    public partial class Form7 : Form
    {
        AccesoDatos ad = new AccesoDatos();
        Negocio negocio = new Negocio();
        List<Pedidos_Local> pedidos = new List<Pedidos_Local>();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cargarElementos();
        }

        public void cargarElementos()
        {

            // buscar mesas ocupadas
            pedidos = ad.getPedidosLocalNoFacturados(); // Devuelve los pedidos locales no facturados, osea las mesas que todavia estan ocupadas
            foreach(Pedidos_Local pedido in pedidos)
            {
                listBoxMesas.Items.Add(pedido.Mesa); // Agrego la mesa del pedido no facturado
            }

            // cargar cmboxstock 
            ArrayList listaPizzas = ad.getColumna("Nombre", "Pizzas");
            ArrayList listaBebidas = ad.getColumna("Nombre", "Bebidas");
            foreach (String pizza in listaPizzas) cmbBoxStock.Items.Add(pizza);
            foreach (String bebida in listaBebidas) cmbBoxStock.Items.Add(bebida);

        }

        private void listBoxMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // limpio listbox
            listBoxPedidos.Items.Clear();

            List<String> listaPedido = new List<string>();
            String id = "";
            
            // Busco id de la mesa seleccionada
            foreach (Pedidos_Local pedido in pedidos)
            {
                //if (pedido.Mesa == Int32.Parse(listBoxMesas.SelectedItem.ToString())) listaPedido = negocio.ObtenerPedido(pedido.IdPedidoLocal);
                if (pedido.Mesa == Int32.Parse(listBoxMesas.SelectedItem.ToString())) id = pedido.IdPedidoLocal;
            }

            // Busco pedido de ese id y agrego los productos a la lista
            listaPedido = negocio.ObtenerPedido(id);
            
            // Agrego los productos al listbox de pedidos
            foreach (String pedido in listaPedido)
            {
                //listBoxPedidos.Items.Add("asd");
                listBoxPedidos.Items.Add(pedido);
            }

            // Agrego total de ese id
            labelTotalPedido.Text = "Total: $" + negocio.ObtenerTotalPedido(id);

        }

        private void cmbBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxStock.Text = ad.getStock(cmbBoxStock.SelectedItem.ToString()).ToString();
        }

        private void btnStockear_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            String producto = cmbBoxStock.SelectedItem.ToString();
            int cantidad = 0;
            float monto = 0;

            try
            {
                cantidad = Int32.Parse(txtBoxCantidad.Text);
                monto = float.Parse(txtBoxMonto.Text);
                if (negocio.ActualizarStock(producto, cantidad) && negocio.RegistrarMovimiento(monto, hoy, -1)) // Suma la cantidad a la ya existente
                    MessageBox.Show("Stock actualizado");
                else
                    MessageBox.Show("No se pudo actualizar el stock.");
            }
            catch
            {
                MessageBox.Show("Cantidad o monto invalido.");
            }

        }

        private void btnAceptarFinanzas_Click(object sender, EventArgs e)
        {
            DateTime desde = calendarDesde.SelectionEnd;
            DateTime hasta = calendarHasta.SelectionEnd;
            float ingresos = negocio.CalcularIngresosYEgresos(desde, hasta, 1); // Tipo 1: Ingreso
            float egresos = negocio.CalcularIngresosYEgresos(desde, hasta, -1); // Tipo -1: Egreso
            labelIngresos.Text = "Ingresos: $" + ingresos.ToString();
            labelEgresos.Text = "Gastos: $" + egresos.ToString();
            labelTotal.Text = "Total: $" + (ingresos - egresos).ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            String id = "";

            foreach (Pedidos_Local pedido in pedidos)
            {
                //if (pedido.Mesa == Int32.Parse(listBoxMesas.SelectedItem.ToString())) listaPedido = negocio.ObtenerPedido(pedido.IdPedidoLocal);
                if (pedido.Mesa == Int32.Parse(listBoxMesas.SelectedItem.ToString())) id = pedido.IdPedidoLocal;
            }

            List<Detalles_Pedido> lista = ad.getProductosPedido(id);
            float total = 0;

            foreach (Detalles_Pedido pedido in lista)
            {
                total += pedido.Precio * pedido.Cantidad;
            }

            DateTime hoy = DateTime.Now;

            if (negocio.RegistrarMovimiento(total, hoy, 1) && ad.PagarPedido(id)) MessageBox.Show("Se registró el pago.");
            else MessageBox.Show("No se pudo registrar el pago.");

            labelTotalPedido.Text = "Total: $0";
            try { listBoxMesas.Items.RemoveAt(listBoxMesas.SelectedIndex); } catch { MessageBox.Show("La mesa se libero."); }

        }
    }
}
