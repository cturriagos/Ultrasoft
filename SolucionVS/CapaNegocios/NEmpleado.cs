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
        public static string Registrar(string Tipo_identificacion, string Nombres, string Direccion, string Telefono, string Email)
        {
            DEmpleado Empleado = new DEmpleado();
            Empleado.Tipo_Identificacion = Tipo_identificacion;
            Empleado.Nombres = Nombres;
            Empleado.Direccion = Direccion;
            Empleado.Telefono = Telefono;
            Empleado.Email = Email;
            return Empleado.Registrar(Empleado);
        }

        public static DataTable Mostrar()
        {
            return new DEmpleado().Mostrar();
        }
    }
}
