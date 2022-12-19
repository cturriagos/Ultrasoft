using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace CapaDeDatos
{
    public class CDAgregarUsuario
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();
        private SqlDataReader lee;

        public DataTable MostrarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select u.Nombre_Usuario as Nombre, u.Apellido_Usuario as Apellido, u.DNI as DNI,U.Usuario,U.Contraseña,u.Email as Email,N.Nivel_Usuario from UsuarioNivel as n inner join TB_Usuario as u on n.ID_Nivel=u.ID_Nivel";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Administradores()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from UsuarioNivel";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public SqlDataReader verificarDNI(string dni,string Usuario)
        {
            string sql = "select * from TB_Usuario where DNI= '" + dni + "' or Usuario= '"+Usuario+"'";
            SqlCommand comando1 = new SqlCommand();
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = sql;
            lee = comando1.ExecuteReader();
            return lee;
        }
    }
}
