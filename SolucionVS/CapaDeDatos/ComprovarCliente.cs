using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class ComprovarCliente
    {
        private CDConexion Con = new CDConexion();
        private SqlDataReader lee;
        private SqlDataReader leer;

        public SqlDataReader COD (int cod)
        {
            string sql = "select * from TB_Cliente where Cod_Cliente= '" + cod + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            lee = comando.ExecuteReader();
            return lee;
        }

        public SqlDataReader CodigoClienteyDni( int cod /*,string Dni*/ )
        {
            string sql = "select * from TB_Cliente where Cod_Cliente= " + cod;//+ "'and Identificacion="+Dni;
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
