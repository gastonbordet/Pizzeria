using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Collections;
using NEGOCIO;
using ENTIDAD;

namespace Pizzas
{
    public partial class Form4 : Form
    {

        private Negocio negocio = new Negocio();
        private AccesoDatos ad = new AccesoDatos();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cargarElementos();
        }

        public void cargarElementos()
        {
            AccesoDatos ad = new AccesoDatos();
            ArrayList lista;

            // Cargo id disponible
            txtBoxIdPedido.Text = ad.GenerarIdPedido();

            // Cargo pizzas
            lista = ad.getColumna("Nombre", "Pizzas");
            foreach(String elem in lista) cmbBoxPizzas.Items.Add(elem);

            // Cargo bebidas
            lista = ad.getColumna("Nombre", "Bebidas");
            foreach (String elem in lista) cmbBoxBebidas.Items.Add(elem);

            // Cargo empleados
            lista = ad.getColumna("IdEmpleado", "Empleados");
            foreach (String elem in lista) cmbBoxEmpleados.Items.Add(elem);

            // Cargo Mesas disponibles
            foreach(int mesa in negocio.MesasDisponibles())
            {
                cmbBoxMesas.Items.Add(mesa);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Chequeo si hay stock
            int stockPizzas = ad.getStock(cmbBoxPizzas.SelectedItem.ToString());
            int stockBebidas = ad.getStock(cmbBoxBebidas.SelectedItem.ToString());

            if (stockPizzas < Int32.Parse(numericUpDown1.Value.ToString()))
            {
                MessageBox.Show("No hay suficientes pizzas.");
                return;
            }

            if (stockBebidas < Int32.Parse(numericUpDown2.Value.ToString()))
            {
                MessageBox.Show("No hay suficientes bebidas.");
                return;
            }


            // Agrego items al listbox
            for (int i = 0; i < Int32.Parse(numericUpDown1.Value.ToString()); i++) listBox1.Items.Add(cmbBoxPizzas.SelectedItem.ToString());
            for (int i = 0; i < Int32.Parse(numericUpDown2.Value.ToString()); i++) listBox1.Items.Add(cmbBoxBebidas.SelectedItem.ToString());

            // Calculo total
            calcularTotal();

            // Limpio items
            limpiarItems();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedidos_Local pedido;
            ArrayList lista;
            try
            {
                pedido = cargarPedido();
                lista = armarDetallesPedidos();
            }
            catch
            {
                MessageBox.Show("No se completaron datos o fueron incorrectos.");
                return;
            }

            // GUARDO CADA DETALLE DEL ARRAYLIST

            if (negocio.insertarPedido(pedido))
            {
                MessageBox.Show("Pedido agregado.");
                foreach(Detalles_Pedido detalle in lista)
                {
                    negocio.insertarPedido(detalle);

                    // DESCUENTO LOS PRODUCTOS EN EL STOCK
                    int cantidad = detalle.Cantidad - (detalle.Cantidad * 2); // CONVIERTO LA CANTIDAD EN NUM NEGATIVO ASI SE RESTA AL TOTAL
                    negocio.ActualizarStock(detalle.NombreProducto, cantidad);
                }

            }
            else MessageBox.Show("No se agrego el pedido, revise los datos.");

            btnAgregarPedido.Enabled = false;
        }

        public void calcularTotal()
        {
            List<String> lista = listBox1.Items.Cast<String>().ToList();
            float total = negocio.CalcularPedido(lista);
            labelTotal.Text = "Total: $ " + total.ToString();
        }

        public void limpiarItems()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            cmbBoxPizzas.SelectedItem = "";
            cmbBoxBebidas.SelectedItem = "";
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            calcularTotal();
            limpiarItems();
        }

        public Pedidos_Local cargarPedido()
        {
            Pedidos_Local pedido = new Pedidos_Local();
            pedido.IdPedidoLocal = txtBoxIdPedido.Text;
            pedido.Cliente = txtBoxCliente.Text;
            pedido.Mesa = Int32.Parse(cmbBoxMesas.SelectedItem.ToString());
            pedido.IdEmpleado = cmbBoxEmpleados.SelectedItem.ToString();
            pedido.Facturado = 0;

            return pedido;
        }

        
        public ArrayList armarDetallesPedidos()
        {
            ArrayList detalles = new ArrayList();
            List<String> lista = listBox1.Items.Cast<String>().ToList();

            foreach (String producto in lista)
            {
                // Armo un detalle con cada producto
                
                Detalles_Pedido pedido = new Detalles_Pedido();
                pedido.IdPedido = txtBoxIdPedido.Text;
                pedido.NombreProducto = producto;
                pedido.Cantidad = existeProductoEnLista(producto, lista);
                pedido.Precio = ad.getPrecio(producto, "Pizzas") + ad.getPrecio(producto, "Bebidas") * pedido.Cantidad; // Si no esta en una tabla suma 0

                if (!existeProductoEnArrayList(pedido.NombreProducto, detalles)) detalles.Add(pedido); // y lo agrego al arraylist si no contiene uno igual
            }

            return detalles;
        }

        public int existeProductoEnLista(String producto, List<String> list)
        {
            int cont = 0;
            foreach(String pro in list)
            {
                if (pro.Equals(producto)) cont++;
            }
            return cont;
        }

        public bool existeProductoEnArrayList(String producto, ArrayList lista)
        {
            foreach(Detalles_Pedido pedido in lista)
            {
                if (pedido.NombreProducto.Equals(producto)) return true;
            }
            return false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
            String id = txtBoxIdPedido.Text;
            List<Detalles_Pedido> lista = ad.getProductosPedido(id);
            float total = 0;

            foreach (Detalles_Pedido pedido in lista)
            {
                total += pedido.Precio * pedido.Cantidad;
            }
            
            DateTime hoy = DateTime.Now;
            
            if (negocio.RegistrarMovimiento(total, hoy, 1) && ad.PagarPedido(id)) MessageBox.Show("Se registró el pago.");
            else MessageBox.Show("No se pudo registrar el pago.");
        }
    }
}
