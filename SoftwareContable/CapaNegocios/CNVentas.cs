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
    public class CNVentas
    {
        private CDVentas obje = new CDVentas();
        public DataTable mostrarTabla(string dni)
        {
            DataTable tabla = new DataTable();
            tabla = obje.Mostrar(dni);
            return tabla;
        }
        public void Insert(string NumeroFactura, string fecha, string codigoProveedor)
        {
            obje.insertar( NumeroFactura, fecha, Convert.ToInt32(codigoProveedor));
        }

        public void InsertarFac(string NumVnet, string Cntidad, string codigoProducto, string precioProducto)
        {
            obje.insertarDetalleFactura(Convert.ToInt32(NumVnet), Cntidad, Convert.ToInt32(codigoProducto), precioProducto);
        }

        public DataTable MostrarProductos()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.Productos();
            return tabla2;
        }

        public DataTable MostrarFactura()
        {
            DataTable tabla3 = new DataTable();
            tabla3 = obje.Factura();
            return tabla3;
        }
    }
}
