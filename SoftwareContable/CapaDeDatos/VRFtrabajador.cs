using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class VRFtrabajador
    {
        private CDConexion Con = new CDConexion();
        private SqlDataReader lee;

        public SqlDataReader DNI(string dni)
        {
            string sql = "select * from TB_Trabajador where Identificacion= '" + dni + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            lee = comando.ExecuteReader();
            return lee;
        }
    }
}
