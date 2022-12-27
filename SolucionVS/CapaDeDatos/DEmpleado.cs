using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DEmpleado
    {
        // VARIABLES
        private int _Id_empleado;
        private string _Tipo_Identificacion;
        private string _Nombres;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Estado;

        //  Constructor sin parámetros
        public DEmpleado()
        {

        }

        //  Constructor con parámetros
        public DEmpleado(int id_empleado, string tipo_Identificacion, string nombres, string direccion, string telefono, string email, string estado)
        {
            _Id_empleado = id_empleado;
            _Tipo_Identificacion = tipo_Identificacion;
            _Nombres = nombres;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _Estado = estado;
        }

        //  Propiedades

        public int Id_empleado { get => _Id_empleado; set => _Id_empleado = value; }
        public string Tipo_Identificacion { get => _Tipo_Identificacion; set => _Tipo_Identificacion = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //  Métodos y Funciones

        public string Registrar(DEmpleado Empleado)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = CDConexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_registrarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParTipo_identificacion = new SqlParameter();
                ParTipo_identificacion.ParameterName = "@tipo_identificacion";
                ParTipo_identificacion.SqlDbType = SqlDbType.Char;
                ParTipo_identificacion.Size = 1;
                ParTipo_identificacion.Value = Empleado.Tipo_Identificacion;
                SqlCmd.Parameters.Add(ParTipo_identificacion);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@nombres";
                ParNombres.SqlDbType = SqlDbType.Char;
                ParNombres.Size = 50;
                ParNombres.Value = Empleado.Nombres;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.Char;
                ParDireccion.Size = 100;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Char;
                ParTelefono.Size = 15;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.Char;
                ParEmail.Size = 50;
                ParEmail.Value = Empleado.Email;
                SqlCmd.Parameters.Add(ParEmail);

                //  Ejecutar el commando
                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el empleado de forma correcta";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                //  Cerrar la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //  Mostrar Empleados
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {   
                SqlCon.ConnectionString = CDConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrarEmpleado";
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
