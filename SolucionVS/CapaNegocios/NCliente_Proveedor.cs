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

        public static string insertarClienteProveedorN(string tipoIdentificacion, string identificacion, string razonSocial,
            string nombreComercial, string direccion, string telefono, string email, string tipoEntidad)
        {

            DCliente_Proveedor obj = new DCliente_Proveedor();
            obj.Tipo_Identificacion = tipoIdentificacion;
            obj.Identificacion = identificacion;
            obj.Razon_Social = razonSocial;
            obj.Nombre_Comercial = nombreComercial;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Tipo_Entidad = tipoEntidad;

            return obj.insertarClienteProveedorD(obj);
        }

        public static DataTable MostrarDatos() {

            return new DCliente_Proveedor().Mostrar();
        }
    }
}
