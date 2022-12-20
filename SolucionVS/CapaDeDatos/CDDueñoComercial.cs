using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDeDatos
{
    public class CDDueñoComercial
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDueño()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cod_Propietario as Código,Nombre_Propietario as Nombre,Apellido_Propietario as Apellido,Tipo_Identificacion as Tipo_Identificación, Identificacion as Identificación, Email_Propietario as Email,Telefono_Propietario as Teléfono, Direccion_Domicilio as Dirección_Domicilio from TB_Propietario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void insertarDueño( string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_Propietario values( '" + Nombre + "','" + Apellido + "','" + tipoID + "','" + ID+ "','" + email + "','" + telefono +"','" +domicilio+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void ActualizarDueño(string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, int codigo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " UPDATE TB_Propietario SET Nombre_Propietario = '" + Nombre + "', Apellido_Propietario = '" + Apellido + "',Tipo_Identificacion = '" + tipoID + "',Identificacion = '" + ID + "',Email_Propietario = '" + email + "',Telefono_Propietario = '" + telefono + "',Direccion_Domicilio = '" + domicilio + "' WHERE[Cod_Propietario] = " + codigo;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarDatos(string credencial)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Propietario where Identificacion='" + credencial + "'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void eliminar(string credencial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_Propietario WHERE Identificacion = '" + credencial + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarComercial()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select c.Direccion_Comercial as Dirección, c.Nombre_Comercial as Nombre, c.Email_Comercial as Email,c.Telefono_Comercial as Teléfono, p.Nombre_Propietario as Nombre_Propietario, p.Apellido_Propietario as Apellido_Propietario from  TB_Propietario as p inner join TB_Comercial as c on p.Cod_Propietario = c.Cod_Propietario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Propietarios ()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Propietario";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void insertarComercial(string direccion, string nombre, string email, string telefono, int cod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into TB_Comercial values( '" + direccion + "','" + nombre + "','" + email + "','" + telefono + "'," + cod +  ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable direciones()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Comercial";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable direcionesComercial(string direccion )
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Comercial where Direccion_Comercial='"+direccion+"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void ActualizarComercial(string direccion, string nombre, string email, string telefono ,int cod, int numero)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " UPDATE TB_Comercial SET Direccion_Comercial = '" + direccion + "', Nombre_Comercial = '" + nombre + "',Email_Comercial = '" + email + "',Telefono_Comercial = '" + telefono + "',Cod_Propietario = '" + cod + "' WHERE[NumeroLocal] = " + numero;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void eliminar2(string comercial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_Comercial WHERE Direccion_Comercial = '" + comercial + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
