using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
    public class CNUsuario
    {
        private CDUsuario objDato = new CDUsuario();
        private string _Usuario;
        private string _Contraseña;
        private int _nivel;
        private string _Usuario2;
        public string Usuario
        {
            set { if (value == "Usuario") { _Usuario = "No ha ingresado usuario"; } else { _Usuario = value; } }
            get { return _Usuario; }
        }
        public string Contraseña
        {
            set { if (value == "Contraseña") { _Contraseña = "Ingrese su contraseña"; } else { _Contraseña = value; } }
            get { return _Contraseña; }
        }
        public int nivel
        {
            set { _nivel = value; }
            get { return _nivel; }
        }
        public CNUsuario() { }
        public SqlDataReader IniciarSecion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSecion(Usuario, Contraseña);
            return Loguear;
        }

        public string RecuperarContra(string dni)
        {
            string Mensaje;
            Mensaje = objDato.RecuperarContraseña(dni);
            return Mensaje;
        }

        public string usuario2
        {
            set { _Usuario2 = value; }
            get { return _Usuario2; }
        }

        public SqlDataReader VerificarUser()
        {
            SqlDataReader veriTodo;
            veriTodo = objDato.verificar(usuario2);
            return veriTodo;
        }

        public DataTable MostrarNivel(string users)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objDato.nivelUsuario(users);
            return tabla2;
        }
    }
}
