using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CDAgregarCliente
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertarCliente(string fecha ,string Nombre, string Apellido, string tipoID, string ID, string telefono, string email,string domicilio, string comercial, string fechaActu )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_Cliente values( '" + fecha + "','" + Nombre + "','" + Apellido+ "','" +tipoID + "','" +ID + "','" +telefono + "','" +email + "','" +domicilio + "','" +comercial +"','"+fechaActu+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable Clientes()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Direccion_Comercial as direccion from TB_Comercial";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable MostrarClientes(int cod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Cliente as Código,Fecha_Registro as Fecha_Registro,Nombre_Cliente as Nombre,Apellido_Cliente as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Telefono as Teléfono,Email as Email, Direccion_Domicilio as Dirección_Domicilio,Direccion_Comercial as Dirección_Comercial, FechaAcualizacionDatos as Fecha_Actualización from TB_Cliente where Cod_Cliente='" + cod + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Cliente as Código,Fecha_Registro as Fecha_Registro,Nombre_Cliente as Nombre,Apellido_Cliente as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Telefono as Teléfono,Email as Email, Direccion_Domicilio as Dirección_Domicilio,Direccion_Comercial as Dirección_Comercial, FechaAcualizacionDatos as Fecha_Actualización from TB_Cliente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Actualizar (string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string comercial, string FechaActu, int codigo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText =" UPDATE TB_Cliente SET Nombre_Cliente = '"+Nombre+"',Apellido_Cliente = '"+Apellido+"',Tipo_Identificacion = '"+tipoID+"',Identificacion = '"+ID+"',Telefono = '"+telefono+"',Email = '"+email+"',Direccion_Domicilio = '"+domicilio+"',Direccion_Comercial = '"+comercial+"',FechaAcualizacionDatos = '"+FechaActu+"' WHERE[Cod_Cliente] = "+codigo;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarDatos(int ident)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Cliente where Cod_Cliente='"+ident+"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void eliminar(string credencial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_Cliente WHERE Identificacion = '" + credencial + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
