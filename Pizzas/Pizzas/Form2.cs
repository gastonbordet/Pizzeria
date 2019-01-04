using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NEGOCIO;

namespace Pizzas
{
    public partial class Form2 : Form
    {

        private DataSet dsPizzeria;
        private Negocio negocio;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Pizzas");
        }

        private void ActualizarCambios(ref DataSet ds)
        {
           
            if (dsPizzeria.HasChanges(DataRowState.Modified))
            {
                if (negocio.ActualizarDatos("Pizzas", ref dsPizzeria) == true)
                    MessageBox.Show("Producto Actualizado");
                else
                    MessageBox.Show("El producto no se pudo actualizar.");
            }
            
            
            if (dsPizzeria.HasChanges(DataRowState.Added))
            {
                if (negocio.insertarDatos("Pizzas", ref dsPizzeria) == true)
                    MessageBox.Show("Producto Agregado");
                else
                    MessageBox.Show("El producto no se pudo agregar.");
            }

            
            if (dsPizzeria.HasChanges(DataRowState.Deleted))
            {
                if (negocio.eliminarDatos("Pizzas", ref dsPizzeria) == true)
                    MessageBox.Show("Producto Eliminado");
                else
                    MessageBox.Show("El producto no se pudo eliminar.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCambios(ref dsPizzeria);
        }

        private void cargarGrilla(String sentencia)
        {
            dsPizzeria = new DataSet();
            negocio = new Negocio();
            negocio.ObtenerDatos("Pizzas", sentencia, ref dsPizzeria);
            dataGridPizzas.DataSource = dsPizzeria.Tables["Pizzas"];
        }

        private void ConstruirClausulaSQL(String nombreTabla, String opcion, String valor, ref String sentencia)
        {
            sentencia = "SELECT * FROM " + nombreTabla + " WHERE " + opcion + " = '" + valor + "'";
            MessageBox.Show(sentencia);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "SELECT * FROM Pizzas";
            if (comboBoxBuscar.Text != "" && txtBoxBuscar.Text != "")
                ConstruirClausulaSQL("Pizzas", comboBoxBuscar.Text, txtBoxBuscar.Text, ref sentencia);

            cargarGrilla(sentencia);
        }

        private void dataGridPizzas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Alguno de los datos ingresados es invalido.");
        }
    }
}
