using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CDConexion
    {
        //SqlConnection oCon;

        string servidor;
        string Usuario;
        string clave;
        string cADENA;
        string baseDeDatos;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public static string Cn = "Data Source=.; Initial Catalog=Ultrasoft; Integrated Security=true";
=======
        public static string Cn = "Data Source=.; Initial Catalog=Ultrasoft;User ID=sa; Password=123456; Integrated Security=true";
>>>>>>> Stashed changes
=======
        public static string Cn = "Data Source=.; Initial Catalog=Ultrasoft;User ID=sa; Password=123456; Integrated Security=true";
>>>>>>> Stashed changes
        DataSet sqlDS;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDA;


        public CDConexion()
        {
            servidor = ".";//hace referencia a mi equipo
            Usuario = "sa";
            clave = "123456";
            baseDeDatos = "Ultrasoft";
            
        }
        public CDConexion(string server, string user, string password, string Bd)
        {
            servidor = server;
            Usuario = user;
            clave = password;
            baseDeDatos = Bd;

        }
        //Abir una conexion con la base de datos qu esta en sql Server
        private SqlConnection Conexion = new SqlConnection(Cn);//("Data Source=.;Initial Catalog=BASE DE DATOS DE PROYECTO INTEGRADOR;Integrated Security=True");
        //Metodo para abrir la conexion
        public SqlConnection AbrirConexion()
        {
            //abrir coneccion si esta cerrada
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = Cn;
                //Conexion.ConnectionString = "Server= " + servidor + " ; Database= " + baseDeDatos + ";User id =" + Usuario + "; Password= " + clave;
                //establezco la conexion debro de crear el usuario y la clave.
                Conexion.Open();
            }
            return Conexion;
        }
        ////Metodo para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
        //public SqlConnection abrirConexion()
        //{
        //    try
        //    {
        //        oCon = new SqlConnection();

        //        //pasar los parametros al Ocon
        //        oCon.ConnectionString = "Server= " + servidor + " ; Database= " + baseDeDatos + ";User id =" + Usuario + "; Password= " + clave;
        //        //establezco la conexion debro de crear el usuario y la clave.
        //        oCon.Open();
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}

        public DataTable ConsultarDatos(string consulta)
        {
            DataTable data = new DataTable();
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = AbrirConexion();
                com.CommandText = consulta;
                SqlDataReader read;
                read = com.ExecuteReader();
                data.Load(read);
                read.Close();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }
            return data;
        }      
    }
}
