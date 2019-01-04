using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using NEGOCIO;

namespace Pizzas
{
    public partial class Form6 : Form
    {
        private DataSet dsEmpleados;
        private Negocio negocio;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cargarGrilla("SELECT * FROM Empleados");
        }

        private void cargarGrilla(String sentencia)
        {
            dsEmpleados = new DataSet();
            negocio = new Negocio();
            negocio.ObtenerDatos("Empleados", sentencia, ref dsEmpleados);
            dataGridEmpleados.DataSource = dsEmpleados.Tables["Empleados"];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCambios(ref dsEmpleados);
        }

        private void ActualizarCambios(ref DataSet ds)
        {
            if (dsEmpleados.HasChanges(DataRowState.Modified))
            {
                if (negocio.ActualizarDatos("Empleados", ref dsEmpleados) == true)
                    MessageBox.Show("Producto Actualizado");
            }


            if (dsEmpleados.HasChanges(DataRowState.Added))
            {
                if (negocio.insertarDatos("Empleados", ref dsEmpleados) == true)
                    MessageBox.Show("Producto Agregado");
            }


            if (dsEmpleados.HasChanges(DataRowState.Deleted))
            {
                if (negocio.eliminarDatos("Empleados", ref dsEmpleados) == true)
                    MessageBox.Show("Producto Eliminado");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "SELECT * FROM Empleados";
            if (comboBoxBuscar.Text != "" && txtBoxBuscar.Text != "")
                ConstruirClausulaSQL("Empleados", comboBoxBuscar.Text, txtBoxBuscar.Text, ref sentencia);

            cargarGrilla(sentencia);
        }

        private void ConstruirClausulaSQL(String nombreTabla, String opcion, String valor, ref String sentencia)
        {
            sentencia = "SELECT * FROM " + nombreTabla + " WHERE " + opcion + " = '" + valor + "'";
            MessageBox.Show(sentencia);
        }

        private void dataGridEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Alguno de los datos ingresados es invalido.");
        }
    }
}
