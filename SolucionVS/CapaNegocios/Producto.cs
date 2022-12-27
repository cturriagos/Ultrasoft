using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    internal class Producto
    {
        private int idProducto;
        private Metrica metrica;
        private string nombreProducto;
        private Decimal unidades;
        private DateTime fechaRegistro;
        private DateTime fechaActualizacion;
        private DateTime fechaEliminacion;
        private Decimal precioCompra;
        private Decimal precioVenta;
        private string estado;

        public Producto()
        {
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public DateTime FechaEliminacion { get => fechaEliminacion; set => fechaEliminacion = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Metrica Metrica { get => metrica; set => metrica = value; }
    }
}
