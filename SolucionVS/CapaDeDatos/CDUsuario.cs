using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace CapaDeDatos
{
    public class CDUsuario
    {
        private CDConexion Conexion = new CDConexion();
        private CDConexion conexion = new CDConexion();
        private SqlDataReader leer;
        private String Email, Nombres, Contraseña;
        private String Mensaje;
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public String RecuperarContraseña(string dni)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText= "select * from TB_Usuario where DNI= '" + dni+"'";
            leer = comando.ExecuteReader();
            if (leer.Read()==true)
            {
                Email = leer["Email"].ToString();
                Nombres=leer["Nombre_Usuario"].ToString()+" "+ leer["Apellido_Usuario"].ToString();
                Contraseña= leer["Contraseña"].ToString();
                EnviarEmail();
                Mensaje = "Estimado " + Nombres + ". Se ha enviado su contraseña a su correo: " + Email + ". Verifique su bandeja de entrada";
                leer.Close();
            }else
            {
                Mensaje = "No existe datos .....";
                leer.Close();
            }
            return Mensaje;
        }

        public void EnviarEmail()
        {
            //creacion de correo
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("asistenteparaelusuario@gmail.com");
            Correo.To.Add(Email);
            Correo.Subject = ("Recuperar contraseña SYSTEM");
            Correo.Body = "Hola, " + Nombres + " somos el asistente técnico. Usted solicito recuperar contraseña. Su contraseña es: " + Contraseña + ". Gracias por preferirnos, estamos a sus órdenes";
            Correo.Priority = MailPriority.Normal;
            //SMPT conecion para enviar correo
            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("asistenteparaelusuario@gmail.com","Grupo62semestre");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;
            try
            {
                ServerMail.Send(Correo);
            }
            catch(Exception ex)
            {

            }
            Correo.Dispose();
        }


        public SqlDataReader IniciarSecion(string user, string pass)
        {
            string sql = "select * from TB_Usuario where Usuario='"+user+ "'and Contraseña='"+pass+ "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader(); 
            return leer;
        }

        public SqlDataReader verificar(string users)
        {
            string sql = "select * from TB_Usuario where Usuario= '" + users + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public DataTable nivelUsuario(string users)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TB_Usuario where Usuario= '"+users+"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
