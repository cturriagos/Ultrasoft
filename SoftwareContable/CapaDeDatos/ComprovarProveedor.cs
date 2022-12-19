using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class ComprovarProveedor
    {
        private CDConexion Con = new CDConexion();
        private SqlDataReader lee;
        private SqlDataReader leer;

        public SqlDataReader DNI(string dni)
        {
            string sql = "select * from TB_Proveedor where Identificacion ='"+dni+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            lee = comando.ExecuteReader();
            return lee;
        }

        public SqlDataReader CodigoProveedorDni(string Dni, int codigo)
        {
            string sql = "select * from TB_Proveedor where Identificacion='" + Dni + "'and Cod_Proveedor=" + codigo;
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
