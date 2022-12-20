using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CN_CompraProducto
    {
        private Compra_Producto obje = new Compra_Producto();
        public DataTable mostrarTabla(string cod)
        {
            DataTable tabla = new DataTable();
            tabla = obje.Mostrar(cod);
            return tabla;
        }

        public DataTable MostrarClientes()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarClientes();
            return tabla1;
        }

        public void Insert(string NumeroFactura, string fecha, int codCliente)
        {
            obje.insertar(NumeroFactura, fecha, Convert.ToString(codCliente));
        }
       
        public void InsertarFac(string NumVnet, string Cntidad, string codigoProducto, string precioProducto)
        {
            obje.insertarDetalleFactura(Convert.ToInt32(NumVnet),Cntidad, Convert.ToInt32(codigoProducto),precioProducto);
        }

        public DataTable MostrarProductos()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.Productos();
            return tabla2;
        }

        public DataTable MostrarFactura ()
        {
            DataTable tabla3 = new DataTable();
            tabla3 = obje.Factura();
            return tabla3;
        }

        public DataTable ProductosPeso (string producto)
        {
            DataTable tabla3 = new DataTable();
            tabla3 = obje.ProductosPeso(producto);
            return tabla3;
        }
    }
}
