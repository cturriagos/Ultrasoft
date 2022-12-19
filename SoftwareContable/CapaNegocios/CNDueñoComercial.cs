using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CNDueñoComercial
    {
        private CDDueñoComercial obje = new CDDueñoComercial();
        public DataTable dueño ()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarDueño();
            return tabla1;
        }

        public void Insertardueño(string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio)
        {
            obje.insertarDueño( Nombre, Apellido, tipoID, ID, email, telefono, domicilio);
        }

        public void actualizarDueño (string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string codigo)
        {
            obje.ActualizarDueño(Nombre, Apellido, tipoID, ID, email, telefono,  domicilio, Convert.ToInt32(codigo));
        }

        public DataTable MostrarDatos(string credencial)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.MostrarDatos(credencial);
            return tabla2;
        }

        public void eliminar(string credencial)
        {
            obje.eliminar(credencial);
        }

        public DataTable propietario()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.Propietarios();
            return tabla2;
        }

        public DataTable comercial()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarComercial();
            return tabla1;
        }

        public void insertarComercial(string direccion, string nombre, string email, string telefono, string cod)
        {
            obje.insertarComercial(direccion,nombre,email,telefono,Convert.ToInt32( cod));
        }

        public DataTable direcciones()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.direciones();
            return tabla1;
        }

        public DataTable direccionComercial(string direccion)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.direcionesComercial(direccion);
            return tabla1;
        }

        public void ActualizarComercial(string direccion, string nombre, string email, string telefono, string cod, string numero)
        {
            obje.ActualizarComercial(direccion,nombre,email,telefono, Convert.ToInt32(cod), Convert.ToInt32(numero));
        }

        public void eliminar2(string comercial)
        {
            obje.eliminar2(comercial);
        }

    }
}
