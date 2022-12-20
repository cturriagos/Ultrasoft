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
    public class CNAgregarUsuario
    {
        private CDAgregarUsuario objDato2 = new CDAgregarUsuario();
        private string _DNI;
        private string _USUARIO;

        public DataTable MostrarUsuarios()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objDato2.MostrarUsuarios();
            return tabla1;
        }

        public string dni
        {
            set { _DNI = value; }
            get { return _DNI; }
        }
        public string usuario
        {
            set { _USUARIO = value; }
            get { return _USUARIO; }
        }
        public CNAgregarUsuario() { }
        public SqlDataReader VerificarDni()
        {
            SqlDataReader veri;
            veri = objDato2.verificarDNI(dni,usuario);
            return veri;
        }

        public DataTable MostrarAdministrador()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objDato2.Administradores();
            return tabla2;
        }

    }
}
