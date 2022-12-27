using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaNegocios
{
    public class NEmpleado
    {
        public static DataTable Mostrar()
        {
            return new DEmpleado().MostrarEmpleado();
        }
    }
}
