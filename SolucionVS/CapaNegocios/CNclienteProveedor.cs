using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeDatos;

namespace CapaNegocios
{
    public class CNclienteProveedor
    {
        private CDclienteProveedor obje = new CDclienteProveedor();

        public void insertarClienteProveedor(string TipoIdentifacion, string identifiacion, string razonSocial,
            string nomComercial, string direccion, string telefono, string email, string tipoEntidad)
        {
            obje.insertarClienteProveedor(TipoIdentifacion, identifiacion, razonSocial, nomComercial, direccion,
                telefono, email, tipoEntidad);
        }

        public DataTable MostrarClientesProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = obje.MostrarDatos() ;
            return tabla;
        }
    }
}
