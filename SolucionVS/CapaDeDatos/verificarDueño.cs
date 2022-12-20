using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class verificarDueño
    {
        private CDConexion Con = new CDConexion();
        private SqlDataReader lee;
        private SqlDataReader leer;

        public SqlDataReader DNI(string dni)
        {
            string sql = "select * from TB_Propietario where Identificacion ='" + dni + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            lee = comando.ExecuteReader();
            return lee;
        }
    }
}
