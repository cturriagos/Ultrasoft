using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NCliente_Proveedor
    {
        public DataTable Mostrar(string identificacion)
        {
            return new DCliente_Proveedor().MostrarCliente(identificacion);
        }
    }
}
