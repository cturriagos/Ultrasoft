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
    public class AgregarUsuario
    {
        private agregar_usuario objDato2 = new agregar_usuario();

        public void insertarUsuario(string dni, string nombre, string apellido, string usuario, string contraseña, string email, string idNivel)
        {
            objDato2.insertarUsuario(dni, nombre, apellido, usuario, contraseña, email, Convert.ToInt32(idNivel));
        }

        public DataTable MostrarDatos(string credencial)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objDato2.MostrarDatos(credencial);
            return tabla2;
        }

        public void actualizar(string dni, string nombre, string apellido, string usuario, string contraseña, string email, string idNivel, string COd)
        {
            objDato2.actualizar(dni,nombre, apellido, usuario,contraseña, email,Convert.ToInt32(idNivel), Convert.ToInt32(COd));
        }

        public DataTable ContarUsers()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objDato2.ContarUsuarisAdmin();
            return tabla1;
        }

        public void eliminar(string credencial)
        {
            objDato2.eliminar(credencial);
        }
    }
}
