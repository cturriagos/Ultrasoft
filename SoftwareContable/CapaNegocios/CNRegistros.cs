using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CNRegistros
    {
        private CDRegistros obje = new CDRegistros();
        public DataTable MostrarCompras()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarCompras();
            return tabla1;
        }
        public DataTable MostrarVentas()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarVentas();
            return tabla1;
        }
        public DataTable MostrarBodega()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarBodega();
            return tabla1;
        }

        public void eliminar(string NumeroRegistro)
        {
            obje.eliminar(Convert.ToInt32(NumeroRegistro));
        }

        public DataTable ContarCompra(string NumeroCompra)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.ContarCompras(Convert.ToInt32(NumeroCompra));
            return tabla1;
        }

        public void eliminarCompra1(string NumVenta, string CodigoProduc)
        {
            obje.eliminarCompra1(Convert.ToInt32(NumVenta), Convert.ToInt32(CodigoProduc));
        }

        public void eliminarCompra2(string NumVenta)
        {
            obje.eliminarCompra2(Convert.ToInt32(NumVenta));
        }

        public DataTable ContarVentas(string NumeroCompra)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.ContarVentas(Convert.ToInt32(NumeroCompra));
            return tabla1;
        }
        public DataTable CadaCliente(int codigo)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.CadaCliente(codigo);
            return tabla1;
        }
        public DataTable dtoVentaCliente(int codigo)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.DtoVentaCliente(codigo);
            return tabla1;
        }

        public void eliminarVenta1(string NumVenta, string CodigoProduc)
        {
            obje.eliminarVenta1(Convert.ToInt32(NumVenta), Convert.ToInt32(CodigoProduc));
        }

        public void eliminarVenta2(string NumVenta)
        {
            obje.eliminarVenta2(Convert.ToInt32(NumVenta));
        }
    }
}
