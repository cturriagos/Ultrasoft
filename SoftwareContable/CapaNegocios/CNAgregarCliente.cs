using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CNAgregarCliente
    {
        private CDAgregarCliente obje = new CDAgregarCliente();
        public void insertarCliente(string fecha, string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string comercial, string fechaActu)
        {
            obje.insertarCliente(fecha,Nombre,Apellido,tipoID,ID,telefono,email,domicilio,comercial,fechaActu);
        }

        public DataTable clientes()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.Clientes();
            return tabla2;
        }

        public DataTable MostrarClientes(int cod)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.MostrarClientes(cod);
            return tabla1;
        }

        public DataTable Mostrar()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = obje.Mostrar();
            return tabla1;
        }

        public DataTable MostrarDatos(int cod)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = obje.MostrarDatos(cod);
            return tabla2;
        }

        public void actualizar(string Nombre, string Apellido, string tipoID, string ID, string telefono, string email, string domicilio, string comercial, string FechaActu, string codigo)
        {
            obje.Actualizar(Nombre, Apellido, tipoID, ID, telefono, email, domicilio, comercial,FechaActu,Convert.ToInt32(codigo));
        }

        public void eliminar(string credencial)
        {
            obje.eliminar(credencial);
        }
    }
}
