using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DCliente_Proveedor
    {
        // Variables
        private int _ID_Cliente_Proveedor;
        private string _Tipo_Identificacion;
        private string _Identificacion;
        private string _Razon_Social;
        private string _Nombre_Comercial;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Tipo_Entidad;
        private char _Habilitado;

        //Constructor sin parámetros
        public DCliente_Proveedor()
        {

        }

        //Constructor con parámetros
        public DCliente_Proveedor(int iD_Cliente_Proveedor, string tipo_Identificacion, string identificacion,
                                  string razon_Social, string nombre_Comercial, string direccion, string telefono,
                                  string email, string tipo_Entidad, char habilitado)
        {
            _ID_Cliente_Proveedor = iD_Cliente_Proveedor;
            _Tipo_Identificacion = tipo_Identificacion;
            _Identificacion = identificacion;
            _Razon_Social = razon_Social;
            _Nombre_Comercial = nombre_Comercial;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _Tipo_Entidad = tipo_Entidad;
            _Habilitado = habilitado;
        }

        //  Propiedades
        public int ID_Cliente_Proveedor { get => _ID_Cliente_Proveedor; set => _ID_Cliente_Proveedor = value; }
        public string Tipo_Identificacion { get => _Tipo_Identificacion; set => _Tipo_Identificacion = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Razon_Social { get => _Razon_Social; set => _Razon_Social = value; }
        public string Nombre_Comercial { get => _Nombre_Comercial; set => _Nombre_Comercial = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Tipo_Entidad { get => _Tipo_Entidad; set => _Tipo_Entidad = value; }
        public char Habilitado { get => _Habilitado; set => _Habilitado = value; }

        public DataTable MostrarCliente(string identificacion)
        {
            DataTable DtResultado = new DataTable("cliente_identificacion");
            //SqlConnection SqlCon = new SqlConnection();
            CDConexion conn = new CDConexion();
            try
            {
                //SqlCon.ConnectionString = CDConexion.Cn;s
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = conn.AbrirConexion();
                SqlCmd.CommandText = "sp_buscarClientexIdentificacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@identificacion",identificacion);
                param.SqlDbType = SqlDbType.Char;
                param.Size = 13;
                SqlCmd.Parameters.Add(param);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                conn.CerrarConexion();
            }
            return DtResultado;
        }

        //Metodo para registrar cliente y proveedor
        public string insertarClienteProveedorD(DCliente_Proveedor cliente_Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            CDConexion conn = new CDConexion();
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = conn.AbrirConexion();
                SqlCmd.CommandText = "sp_registrarClienteProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTipoIde = new SqlParameter();
                ParTipoIde.ParameterName = "@tipo_identificacion";
                ParTipoIde.SqlDbType = SqlDbType.Char;
                ParTipoIde.Size = 10;
                ParTipoIde.Value = cliente_Proveedor.Tipo_Identificacion;
                SqlCmd.Parameters.Add(ParTipoIde);

                SqlParameter Paridentif = new SqlParameter();
                Paridentif.ParameterName = "@identificacion";
                Paridentif.SqlDbType = SqlDbType.Char;
                Paridentif.Size = 13;
                Paridentif.Value = cliente_Proveedor.Identificacion;
                SqlCmd.Parameters.Add(Paridentif);

                SqlParameter ParRsocial = new SqlParameter();
                ParRsocial.ParameterName = "@razon_social";
                ParRsocial.SqlDbType = SqlDbType.Char;
                ParRsocial.Size = 50;
                ParRsocial.Value = cliente_Proveedor.Razon_Social;
                SqlCmd.Parameters.Add(ParRsocial);

                SqlParameter ParComercial = new SqlParameter();
                ParComercial.ParameterName = "@nombre_comercial";
                ParComercial.SqlDbType = SqlDbType.Char;
                ParComercial.Size = 50;
                ParComercial.Value = cliente_Proveedor.Nombre_Comercial;
                SqlCmd.Parameters.Add(ParComercial);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.Char;
                ParDireccion.Size = 100;
                ParDireccion.Value = cliente_Proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Char;
                ParTelefono.Size = 15;
                ParTelefono.Value = cliente_Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.Char;
                ParEmail.Size = 50;
                ParEmail.Value = cliente_Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParTipoEntidad = new SqlParameter();
                ParTipoEntidad.ParameterName = "@tipo_entidad";
                ParTipoEntidad.SqlDbType = SqlDbType.Char;
                ParTipoEntidad.Size = 15;
                ParTipoEntidad.Value = cliente_Proveedor.Tipo_Entidad;
                SqlCmd.Parameters.Add(ParTipoEntidad);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cliente_proveedor");
            SqlConnection SqlCon = new SqlConnection();
            CDConexion conn = new CDConexion();
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Connection = conn.AbrirConexion();
                SqlCmd.CommandText = "sp_mostraDatosClientesProv";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
