using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class Compra_Producto
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar(string cod)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Cliente as Código,Nombre_Cliente as Nombre,Apellido_Cliente as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Telefono as Teléfono,Email as Email, Direccion_Domicilio as Dirección_Domicilio from TB_Cliente where Cod_Cliente='" + cod + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarClientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Cliente as Código,Nombre_Cliente as Nombre,Apellido_Cliente as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Telefono as Teléfono,Email as Email, Direccion_Domicilio as Dirección_Domicilio from TB_Cliente ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void insertar (string NumeroFactura, string fecha, string ident)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_FacturaCliente values( '" + NumeroFactura+"','"+fecha+"',"+ident+")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable Factura()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT MAX(Num_Venta) as venta from TB_FacturaCliente";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarDetalleFactura (int NumVnet, string Cntidad, int codigoProducto, string precioProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_DetalleFacturaCliente values(" + NumVnet+","+Cntidad+","+codigoProducto+","+precioProducto+")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable Productos ()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText= "select * from TB_Producto";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ProductosPeso (string producto)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Producto where Nom_Producto= '"+ producto +"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
