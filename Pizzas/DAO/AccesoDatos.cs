using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using ENTIDAD;

namespace DAO
{
    public class AccesoDatos
    {
        String rutaBDPizzeria = "Data Source=localhost\\sqlexpress;Initial Catalog=Pizzeria;Integrated Security=True";

        public AccesoDatos()
        {
            // TODO: Agregar aquí la lógica del constructor
        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDPizzeria);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void cargaTabla(String NombreTabla, String Sql, ref DataSet ds)
        {
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, cn);
            adp.Fill(ds, NombreTabla);
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        public void ArmarParametrosPizzas(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDPIZZA", SqlDbType.Char, 6);
            SqlParametros.Value = fila["IdPizza"];
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 25);
            SqlParametros.Value = fila["Nombre"];
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.Float);
            SqlParametros.Value = fila["Precio"];
        }

        public void ArmarParametrosBebidas(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDBEBIDA", SqlDbType.Char, 6);
            SqlParametros.Value = fila["IdBebida"];
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 25);
            SqlParametros.Value = fila["Nombre"];
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.Float);
            SqlParametros.Value = fila["Precio"];
            SqlParametros = Comando.Parameters.Add("@ALCOHOL", SqlDbType.Char, 3);
            SqlParametros.Value = fila["Alcohol"];
        }

        public void ArmarParametrosEmpleados(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDEMPLEADO", SqlDbType.Char, 6);
            SqlParametros.Value = fila["IdEmpleado"];
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 25);
            SqlParametros.Value = fila["Nombre"];
            SqlParametros = Comando.Parameters.Add("@PUESTO", SqlDbType.Char, 25);
            SqlParametros.Value = fila["Puesto"];
            SqlParametros = Comando.Parameters.Add("@SUELDO", SqlDbType.Float);
            SqlParametros.Value = fila["Sueldo"];
            SqlParametros = Comando.Parameters.Add("@HORAS", SqlDbType.Int);
            SqlParametros.Value = fila["Horas"];
        }

        public void ArmarParametrosPedidoLocal(ref SqlCommand Comando, Pedidos_Local pedido)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDPEDIDOLOCAL", SqlDbType.Char, 6);
            SqlParametros.Value = pedido.IdPedidoLocal;
            SqlParametros = Comando.Parameters.Add("@CLIENTE", SqlDbType.Char, 25);
            SqlParametros.Value = pedido.Cliente;
            SqlParametros = Comando.Parameters.Add("@MESA", SqlDbType.Int);
            SqlParametros.Value = pedido.Mesa;
            SqlParametros = Comando.Parameters.Add("@IDEMPLEADO", SqlDbType.Char, 6);
            SqlParametros.Value = pedido.IdEmpleado;
            SqlParametros = Comando.Parameters.Add("@FACTURADO", SqlDbType.Int);
            SqlParametros.Value = pedido.Facturado;
        }

        public void ArmarParametrosPedidoDelivery(ref SqlCommand Comando, Pedidos_Delivery pedido)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDPEDIDODELIVERY", SqlDbType.Char, 6);
            SqlParametros.Value = pedido.IdPedidoDelivery;
            SqlParametros = Comando.Parameters.Add("@CLIENTE", SqlDbType.Char, 25);
            SqlParametros.Value = pedido.Cliente;
            SqlParametros = Comando.Parameters.Add("@TELEFONO", SqlDbType.Int);
            SqlParametros.Value = pedido.Telefono;
            SqlParametros = Comando.Parameters.Add("@DIRECCION", SqlDbType.Char, 25);
            SqlParametros.Value = pedido.Direccion;
            SqlParametros = Comando.Parameters.Add("@IDEMPLEADO", SqlDbType.Char, 6);
            SqlParametros.Value = pedido.IdEmpleado;
            SqlParametros = Comando.Parameters.Add("@FACTURADO", SqlDbType.Int);
            SqlParametros.Value = pedido.Facturado;
        }

        public void ArmarParametrosDetallePedido(ref SqlCommand Comando, Detalles_Pedido pedido)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDPEDIDO", SqlDbType.Char, 6);
            SqlParametros.Value = pedido.IdPedido;
            SqlParametros = Comando.Parameters.Add("@NOMBREPRODUCTO", SqlDbType.Char, 25);
            SqlParametros.Value = pedido.NombreProducto;
            SqlParametros = Comando.Parameters.Add("@CANTIDAD", SqlDbType.Int);
            SqlParametros.Value = pedido.Cantidad;
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.Float);
            SqlParametros.Value = pedido.Precio;
        }

        public void ArmarParametrosStock(ref SqlCommand Comando, Stock stock)
        {
            SqlParameter SqlParametros = new SqlParameter();
            // EL ID NO HACE FALTA TOMARLO
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 25);
            SqlParametros.Value = stock.Nombre;
            SqlParametros = Comando.Parameters.Add("@CANTIDAD", SqlDbType.Int);
            SqlParametros.Value = stock.Cantidad;
        }

        public void ArmarParametrosBalance(ref SqlCommand Comando, Balances balance)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = Comando.Parameters.Add("@MONTO", SqlDbType.Float);
            parametros.Value = balance.Monto;
            parametros = Comando.Parameters.Add("@DIA", SqlDbType.Int);
            parametros.Value = balance.Dia;
            parametros = Comando.Parameters.Add("@MES", SqlDbType.Int);
            parametros.Value = balance.Mes;
            parametros = Comando.Parameters.Add("@AÑO", SqlDbType.Int);
            parametros.Value = balance.Año;
            parametros = Comando.Parameters.Add("@TIPO", SqlDbType.Int);
            parametros.Value = balance.Tipo;

        }

        public bool grabarMovimiento(Balances balance)
        {
            SqlCommand Comando = new SqlCommand();
            String nombreSp = "spGrabarBalance";
            ArmarParametrosBalance(ref Comando, balance);
            if (EjecutarProcedimientoAlmacenado(Comando, nombreSp) >= 1) return true;
            else return false;
        }


        public bool InsertarPedidoEnBD(Object obj)
        {

            SqlCommand Comando = new SqlCommand();
            String nombreSp = "";
            if(obj is Pedidos_Local)
            {
                Pedidos_Local pedido = (Pedidos_Local)obj;
                ArmarParametrosPedidoLocal(ref Comando, pedido);
                nombreSp = "spInsertarPedidoLocal";
            }
            else if(obj is Pedidos_Delivery)
            {
                Pedidos_Delivery pedido = (Pedidos_Delivery)obj;
                ArmarParametrosPedidoDelivery(ref Comando, pedido);
                nombreSp = "spInsertarPedidoDelivery";
            }
            else if (obj is Detalles_Pedido)
            {
                Detalles_Pedido pedido = (Detalles_Pedido)obj;
                ArmarParametrosDetallePedido(ref Comando, pedido);
                nombreSp = "spInsertarDetallePedido";
            }

            try { EjecutarProcedimientoAlmacenado(Comando, nombreSp); } catch { return false; }
            return true;
        }

        public bool PagarPedido(String id)
        {
            SqlCommand Comando = new SqlCommand();
            String nombreSp = "spPagarPedido";
            SqlParameter parametros = new SqlParameter();
            parametros = Comando.Parameters.Add("@IDPEDIDOLOCAL", SqlDbType.Char, 6);
            parametros.Value = id;

            try { EjecutarProcedimientoAlmacenado(Comando, nombreSp); } catch { return false; }
            return true;
        }

        public bool ActualizarStockEnBD(Stock stock)
        {
            SqlCommand Comando = new SqlCommand();
            String nombreSp = "spActualizarStock";
            
            ArmarParametrosStock(ref Comando, stock);
            if (EjecutarProcedimientoAlmacenado(Comando, nombreSp) >= 1) return true;
            else return false;
        }

        public bool InsertarEnBD(String nombreTabla, DataSet ds)
        {
            
            int FilasInsertadas = 0;
            foreach (DataRow fila in ds.Tables[nombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                AccesoDatos ad = new AccesoDatos();
                String nombreSp = "";

                switch (nombreTabla)
                {
                    case "Pizzas":
                        ArmarParametrosPizzas(ref Comando, fila);
                        nombreSp = "spInsertarPizza";
                        break;
                    case "Bebidas":
                        ArmarParametrosBebidas(ref Comando, fila);
                        nombreSp = "spInsertarBebida";
                        break;
                    case "Empleados":
                        ArmarParametrosEmpleados(ref Comando, fila);
                        nombreSp = "spInsertarEmpleado";
                        break;                
                }

                try { FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, nombreSp); } catch { return false; }
            }
            if (FilasInsertadas >= 1)
                return true;
            else
                return false;
            
        }

        public bool ActualizarEnBD(String nombreTabla, DataSet ds)
        {
            int FilasActualizadas = 0;
            foreach (DataRow fila in ds.Tables[nombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                AccesoDatos ad = new AccesoDatos();
                String nombreSp = "";

                switch (nombreTabla)
                {
                    case "Pizzas":
                        ArmarParametrosPizzas(ref Comando, fila);
                        nombreSp = "spActualizarPizza";
                        break;
                    case "Bebidas":
                        ArmarParametrosBebidas(ref Comando, fila);
                        nombreSp = "spActualizarBebida";
                        break;
                    case "Empleados":
                        ArmarParametrosEmpleados(ref Comando, fila);
                        nombreSp = "spActualizarEmpleado";
                        break;
                }

                try { FilasActualizadas = ad.EjecutarProcedimientoAlmacenado(Comando, nombreSp); } catch { return false; }
            }
            if (FilasActualizadas >= 1)
                return true;
            else
                return false;
        }

        public bool EliminarEnBD(String nombreTabla, DataSet ds)
        {
            int FilasEliminadas = 0;
            foreach (DataRow fila in ds.Tables[nombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                fila.RejectChanges();
                AccesoDatos ad = new AccesoDatos();
                String nombreSp = "";

                switch (nombreTabla)
                {
                    case "Pizzas":
                        ArmarParametrosPizzas(ref Comando, fila);
                        nombreSp = "spEliminarPizza";
                        break;
                    case "Bebidas":
                        ArmarParametrosBebidas(ref Comando, fila);
                        nombreSp = "spEliminarBebida";
                        break;
                    case "Empleados":
                        ArmarParametrosEmpleados(ref Comando, fila);
                        nombreSp = "spEliminarEmpleado";
                        break;
                }

                try { FilasEliminadas = ad.EjecutarProcedimientoAlmacenado(Comando, nombreSp); } catch { return false; }
            }

            if (FilasEliminadas >= 1)
                return true;
            else
                return false;
        }

        public ArrayList getColumna(String nombreColumna, String nombreTabla)
        {
            ArrayList lista = new ArrayList();
            String sentencia = "SELECT " + nombreColumna + " FROM " + nombreTabla;

            SqlConnection conexion = ObtenerConexion(); // conexion ya abierta en ad
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader[nombreColumna].ToString());
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            return lista;
        }

        public float getPrecio(String nombreProducto, String nombreTabla)
        {
            String sentencia = "SELECT Nombre, Precio FROM " + nombreTabla;
            float precio = 0;

            SqlConnection conexion = ObtenerConexion();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (nombreProducto.Equals(reader["Nombre"].ToString())) precio = float.Parse(reader["Precio"].ToString());
            }
            
            reader.Close();
            comando.Dispose();
            conexion.Close();

            return precio;
        }

        public List<Pedidos_Local> getPedidosLocalNoFacturados()
        {
            List<Pedidos_Local> pedidos = new List<Pedidos_Local>();
            
            String sentencia = "SELECT * FROM Pedidos_Local";

            SqlConnection conexion = ObtenerConexion();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader["Facturado"].ToString().Equals("0"))
                {
                    Pedidos_Local pedido = new Pedidos_Local();
                    pedido.IdPedidoLocal = reader["IdPedidoLocal"].ToString();
                    pedido.Cliente = reader["Cliente"].ToString();
                    pedido.Mesa = Int32.Parse(reader["Mesa"].ToString());
                    pedido.IdEmpleado = reader["IdEmpleado"].ToString();
                    pedido.Facturado = Int32.Parse(reader["Facturado"].ToString());
                    pedidos.Add(pedido);
                }
                
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            return pedidos;
        }

        public List<Detalles_Pedido> getProductosPedido(String id)
        {
            List<Detalles_Pedido> detalles = new List<Detalles_Pedido>();
            
            String sentencia = "SELECT * FROM Detalles_Pedido";

            SqlConnection conexion = ObtenerConexion();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                if (reader["IdPedido"].ToString().Equals(id))
                {
                    Detalles_Pedido pedido = new Detalles_Pedido();
                    pedido.IdPedido = reader["IdPedido"].ToString();
                    pedido.NombreProducto = reader["NombreProducto"].ToString();
                    pedido.Cantidad = Int32.Parse(reader["Cantidad"].ToString());
                    pedido.Precio = float.Parse(reader["Precio"].ToString());
                    detalles.Add(pedido);
                }
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();
            
            return detalles;
        }

        public int getStock(String Nombre)
        {
            int stock = 0;
            SqlConnection conexion = ObtenerConexion();
            String sentencia = "SELECT * FROM Stock";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                if(reader["Nombre"].ToString().Equals(Nombre))
                {
                    stock = Int32.Parse(reader["Cantidad"].ToString());
                }
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            return stock;
        }

        public float getBalance(DateTime desde, DateTime hasta, int tipo)
        {
            float total = 0;
            SqlConnection conexion = ObtenerConexion();
            String sentencia = "SELECT * FROM Balance";
            SqlCommand Comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = Comando.ExecuteReader();

            while(reader.Read())
            {
                /*if(Int32.Parse(reader["Año"].ToString()) >= desde.Year && Int32.Parse(reader["Año"].ToString()) <= hasta.Year)
                {
                    if(Int32.Parse(reader["Mes"].ToString()) >= desde.Month && Int32.Parse(reader["Mes"].ToString()) <= desde.Month)
                    {
                        if(Int32.Parse(reader["Dia"].ToString()) >= desde.Day && Int32.Parse(reader["Dia"].ToString()) >= desde.Day)
                        {
                            if (Int32.Parse(reader["Tipo"].ToString()) == tipo) total += float.Parse(reader["Monto"].ToString());
                        }
                    }
                }*/

                DateTime registro = new DateTime(Int32.Parse(reader["Año"].ToString()), Int32.Parse(reader["Mes"].ToString()), Int32.Parse(reader["Dia"].ToString()));
                if(registro >= desde && registro <= hasta)
                {
                    if(Int32.Parse(reader["Tipo"].ToString()) == tipo) total += float.Parse(reader["Monto"].ToString());
                }
                
            }

            reader.Close();
            Comando.Dispose();
            conexion.Close();

            return total;

        }

        public bool EmpleadoExiste(String id)
        {
            String sentencia = "SELECT * Precio FROM Empleados";
            bool flag = false;

            SqlConnection conexion = ObtenerConexion();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader["IdEmpleado"].ToString().Equals(id)) flag = true;
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            return flag;
        }

        public String GenerarIdPedido()
        {

            // CHEQUEO PEDIDOS LOCAL
            String sentencia = "SELECT IdPedidoLocal Precio FROM Pedidos_Local";
            int cont = 0;

            SqlConnection conexion = ObtenerConexion();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cont++;
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            // CHEQUEO PEDIDOS DELIVERY
            sentencia = "SELECT IdPedidoDelivery FROM Pedidos_Delivery";
            conexion = ObtenerConexion();
            comando = new SqlCommand(sentencia, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cont++;
            }

            reader.Close();
            comando.Dispose();
            conexion.Close();

            return cont.ToString();
        }
    }
}
