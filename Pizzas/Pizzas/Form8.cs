using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using DAO;
using ENTIDAD;

namespace Pizzas
{
    public partial class Form8 : Form
    {
        private Negocio negocio;
        private DataSet dsPedidos;
        private String pedido = "Pedidos_Local";

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Pedidos_Local");
        }

        private void cargarGrilla(String sentencia)
        {
            dsPedidos = new DataSet();
            negocio = new Negocio();
            negocio.ObtenerDatos("Pedidos_local", sentencia, ref dsPedidos);
            dataGridPedidos.DataSource = dsPedidos.Tables["Pedidos_Local"];

        }

        private void rdioBtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Pedidos_Delivery");
            String[] items = { "IdPedidoDelivery", "Cliente", "Telefono", "Direccion", "IdEmpleado", "Facturado" };
            comboBoxBuscar.Items.Clear();
            foreach (String item in items) comboBoxBuscar.Items.Add(item);
            pedido = "Pedidos_Delivery";
            
        }

        private void rdioBtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Pedidos_Local");
            String[] items = { "IdPedidoDelivery", "Cliente", "Mesa", "IdEmpleado", "Facturado" };
            comboBoxBuscar.Items.Clear();
            foreach (String item in items) comboBoxBuscar.Items.Add(item);
            pedido = "Pedidos_Local";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "SELECT * FROM " + pedido;
            if (comboBoxBuscar.Text != "" && txtBoxBuscar.Text != "")
                ConstruirClausulaSQL(pedido, comboBoxBuscar.Text, txtBoxBuscar.Text, ref sentencia);

            cargarGrilla(sentencia);
        }

        private void ConstruirClausulaSQL(String nombreTabla, String opcion, String valor, ref String sentencia)
        {
            sentencia = "SELECT * FROM " + nombreTabla + " WHERE " + opcion + " = '" + valor + "'";
            //MessageBox.Show(sentencia);
        }
    }
}
