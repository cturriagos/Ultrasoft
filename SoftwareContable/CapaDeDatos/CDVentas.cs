using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CDVentas
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        private SqlDataReader LeerFilas;
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar(string dni)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Proveedor as Código,Nombre_Proveedor as Nombre,Apellido_Proveedor as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Telefono as Teléfono,Email as Email from TB_Proveedor where Identificacion='" + dni + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void insertar(string NumeroFactura, string fecha, int codigoProveedor )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_FacturaProveedor values('" + NumeroFactura + "','" + fecha + "'," + codigoProveedor + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable Factura()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT MAX(Num_Compra) as venta from TB_FacturaProveedor";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarDetalleFactura(int NumVnet, string Cntidad, int codigoProducto, string precioProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_DetalleFacturaProveedor values(" + NumVnet + "," + Cntidad + "," + codigoProducto + ","  + precioProducto + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable Productos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Producto";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
