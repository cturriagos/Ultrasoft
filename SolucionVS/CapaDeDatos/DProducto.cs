using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DProducto
    {
        private CDConexion conexion;
        public DProducto()
        {
            this.conexion= new CDConexion();
        }

        public DataTable ObtenerProductos(string nombre)
        {
            try
            {
                string consulta = "Select p.ID_PRODUCTO, p.NOMBRE_PRODUCTO, p.UNIDADES, m.SIMBOLO, " +
                    "p.PRECIO_COMPRA, p.PRECIO_VENTA, P.FECHA_REGISTRO, " +
                    "CASE WHEN P.FECHA_ACTUALIZACION IS NULL THEN '' else p.FECHA_ACTUALIZACION END as \"FECHA_ACTUALIZACION\", " +
                    "CASE WHEN P.FECHA_ELIMINACION IS NULL THEN '' else p.FECHA_ELIMINACION END as \"FECHA_ELIMINACION\"" +
                    "from dbo.PRODUCTO p INNER JOIN dbo.METRICA m on p.ID_METRICA = m.ID_METRICA where p.NOMBRE_PRODUCTO like '%" +
                    nombre + "%';";
                return conexion.ConsultarDatos(consulta);
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
