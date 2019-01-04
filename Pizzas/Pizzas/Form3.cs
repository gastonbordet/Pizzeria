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

namespace Pizzas
{
    public partial class Form3 : Form
    {

        private DataSet dsBebidas;
        private Negocio negocio;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Bebidas");
        }

        private void cargarGrilla(String sentencia)
        {
            dsBebidas = new DataSet();
            negocio = new Negocio(); 
            negocio.ObtenerDatos("Bebidas", sentencia, ref dsBebidas);
            dataGridBebidas.DataSource = dsBebidas.Tables["Bebidas"];
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCambios(ref dsBebidas);
        }

        private void ActualizarCambios(ref DataSet ds)
        {

            if (dsBebidas.HasChanges(DataRowState.Modified))
            {
                if (negocio.ActualizarDatos("Bebidas", ref dsBebidas) == true)
                    MessageBox.Show("Producto Actualizado");
            }


            if (dsBebidas.HasChanges(DataRowState.Added))
            {
                if (negocio.insertarDatos("Bebidas", ref dsBebidas) == true)
                    MessageBox.Show("Producto Agregado");
            }


            if (dsBebidas.HasChanges(DataRowState.Deleted))
            {
                if (negocio.eliminarDatos("Bebidas", ref dsBebidas) == true)
                    MessageBox.Show("Producto Eliminado");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "SELECT * FROM Bebidas";
            if (comboBoxBuscar.Text != "" && txtBoxBuscar.Text != "")
                ConstruirClausulaSQL("Bebidas", comboBoxBuscar.Text, txtBoxBuscar.Text, ref sentencia);

            cargarGrilla(sentencia);
        }

        private void ConstruirClausulaSQL(String nombreTabla, String opcion, String valor, ref String sentencia)
        {
            sentencia = "SELECT * FROM " + nombreTabla + " WHERE " + opcion + " = '" + valor + "'";
            MessageBox.Show(sentencia);
        }

        private void dataGridBebidas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Alguno de los datos ingresados es invalido.");
        }
    }
}
