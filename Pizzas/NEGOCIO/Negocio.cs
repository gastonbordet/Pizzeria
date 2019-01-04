using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDAD;
using System.Collections;
using System.Data;

namespace NEGOCIO
{
    public class Negocio
    {
        private AccesoDatos ad = new AccesoDatos();


        public void ObtenerDatos(String nombreTabla, String sentencia, ref DataSet ds)
        {
            
            ad.cargaTabla(nombreTabla, sentencia, ref ds);

        }

        public bool ActualizarDatos(String nombreTabla, ref DataSet ds)
        {
            DataSet dsActualizar = new DataSet();
            dsActualizar = ds.GetChanges(DataRowState.Modified);
            
            if (ad.ActualizarEnBD(nombreTabla, ds))
                return true;
            else
                return false;
        }

        public bool insertarDatos(String nombreTabla, ref DataSet ds)
        {
            DataSet dsInsertar = new DataSet();
            dsInsertar = ds.GetChanges(DataRowState.Added);
            
            
            if (ad.InsertarEnBD(nombreTabla, dsInsertar) == true)
                return true;
            else
                return false;
            
        }

        public bool insertarPedido(Object pedido)
        {
            if (ad.InsertarPedidoEnBD(pedido)) return true;
            else return false;
        }

        public bool eliminarDatos(String nombreTabla, ref DataSet ds)
        {
            DataSet dsEliminar = new DataSet();
            dsEliminar = ds.GetChanges(DataRowState.Deleted);
            if (ad.EliminarEnBD(nombreTabla, dsEliminar)) return true;
            else return false;
        }

        public float CalcularPedido(List<String> lista)
        {
            float total = 0;
            foreach (String producto in lista)
            {
                total += ad.getPrecio(producto, "Pizzas");
                
                total += ad.getPrecio(producto, "Bebidas");
            }
            return total;       
        }

        public List<String> ObtenerPedido(String id)
        {
            List<String> pedido = new List<string>();
            List<Detalles_Pedido> detalles = ad.getProductosPedido(id);

            foreach(Detalles_Pedido detalle in detalles)
            {
                for(int i = 0; i < detalle.Cantidad; i++)
                {
                    pedido.Add(detalle.NombreProducto);
                }
            }

            return pedido;
        }

        public float ObtenerTotalPedido(String id)
        {
            float total = 0;
            List<Detalles_Pedido> detalles = ad.getProductosPedido(id);

            foreach (Detalles_Pedido detalle in detalles)
            {
                total += detalle.Precio * detalle.Cantidad; 
            }

            return total;
        }
        
        public bool ActualizarStock(String nombre, int cantidad)
        {
            cantidad += ad.getStock(nombre);
            Stock stock = new Stock(nombre, cantidad);

            return ad.ActualizarStockEnBD(stock);
        }

        public bool RegistrarMovimiento(float total, DateTime date, int tipo)
        {
            Balances movimiento = new Balances(total, date.Day, date.Month, date.Year, tipo);
            return ad.grabarMovimiento(movimiento);
        }

        public float CalcularIngresosYEgresos(DateTime desde, DateTime hasta, int tipo)
        {
            float total = 0;

            total = ad.getBalance(desde, hasta, tipo);
            return total;
        }

        public List<Int32> MesasDisponibles()
        {
            List<Int32> mesas = new List<Int32>();
            List<Pedidos_Local> pedidos = ad.getPedidosLocalNoFacturados();
            int mesa = 0; // Mesa que voy a agregar al listado de disponibles

            for (int i = 0; i < 20; i++)
            {
                mesa = i + 1;
                bool flag = false; // flag para constatar que la mesa no esta ocupada
                foreach (Pedidos_Local pedido in pedidos)
                {
                    //MessageBox.Show(pedido.IdPedidoLocal);
                    if (pedido.Mesa == mesa) flag = true;
                }
                if (flag == false) mesas.Add(mesa);
            }

            return mesas;
        }

        
    }
}
