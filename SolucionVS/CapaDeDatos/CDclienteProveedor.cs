using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
   public class CDclienteProveedor
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertarClienteProveedor(string TipoIdentifacion, string identifiacion, string razonSocial,
            string nomComercial, string direccion, string telefono, string email, string tipoEntidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_registrarClienteProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@tipo_identificacion", TipoIdentifacion);
            comando.Parameters.AddWithValue("@identificacion", identifiacion);
            comando.Parameters.AddWithValue("@razon_social", razonSocial);
            comando.Parameters.AddWithValue("@nombre_comercial", nomComercial);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@tipo_entidad", tipoEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
