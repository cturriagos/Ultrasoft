using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaNegocios
{
    public class NProducto
    {
        private DProducto dProducto;

        public NProducto()
        {
            this.dProducto = new DProducto();
        }

        public DataTable ObtenerProductos(string nombre)
        {
            return dProducto.ObtenerProductos(nombre);
        }
    }
}
