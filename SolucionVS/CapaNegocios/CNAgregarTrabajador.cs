using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CNAgregarTrabajador
    {
        private CDAgregarTrabajador obje = new CDAgregarTrabajador();
        public void insertarTrabajador(string fecha, string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string comercial, string fechaActu)
        {
            obje.insertarTrabajador(fecha, Nombre, Apellido, tipoID, ID, telefono, email, domicilio, comercial, fechaActu);
        }

        public DataTable trabajador()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.Trabajador();
            return tabla2;
        }

        public DataTable MostrarTrabajador(string dni)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarTrabajador(dni);
            return tabla1;
        }

        public DataTable Mostrar()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.Mostrar();
            return tabla1;
        }

        public DataTable MostrarDatos(string credencial)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.MostrarDatos(credencial);
            return tabla2;
        }

        public void actualizar(string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string comercial, string FechaActu, string codigo)
        {
            obje.Actualizar(Nombre, Apellido, tipoID, ID, telefono, email, domicilio, comercial, FechaActu, Convert.ToInt32(codigo));
        }

        public void eliminar(string credencial)
        {
            obje.eliminar(credencial);
        }
    }
}
