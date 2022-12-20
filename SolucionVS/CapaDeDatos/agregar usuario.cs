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
    public class agregar_usuario
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();
        private SqlDataReader lee;
        public void insertarUsuario(string dni, string nombre, string apellido, string usuario, string contraseña, string email, int idNivel)
        {
            comando2.Connection = conexion.AbrirConexion();
            comando2.CommandText = "insert into TB_Usuario values ('" + dni + "','" + nombre + "','" + apellido + "','" + usuario + "','" + contraseña + "','" + email + "'," + idNivel + ")";
            comando2.CommandType = CommandType.Text;
            comando2.ExecuteNonQuery();
        }

        public void actualizar(string dni, string nombre, string apellido, string usuario, string contraseña, string email, int idNivel,int COd)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " UPDATE TB_Usuario SET DNI = '" + dni +"', Nombre_Usuario = '" + nombre + "', Apellido_Usuario = '" + apellido + "',Usuario='"+usuario+"',Contraseña='"+contraseña+"',Email = '" + email +"',ID_Nivel='"+idNivel+ "' WHERE[ID_Usuario] = " + COd;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarDatos(string credencial)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Usuario where DNI='" + credencial + "'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ContarUsuarisAdmin()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(ID_Nivel) as total from TB_Usuario where ID_Nivel=1 group by ID_Nivel";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void eliminar(string credencial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_Usuario WHERE DNI = '" + credencial + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
