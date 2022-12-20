using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
    public class VRFProveedor
    {
        private ComprovarProveedor objDato2 = new ComprovarProveedor();
        private string _DNI;
        public string dni
        {
            set { _DNI = value; }
            get { return _DNI; }
        }
        public VRFProveedor() { }
        public SqlDataReader Verificar()
        {
            SqlDataReader veri;
            veri = objDato2.DNI(dni);
            return veri;
        }

        private string _Dni;
        private int _Codigo;
        public string Dni
        {
            set { _Dni = value; }
            get { return _Dni; }
        }

        public int codigo
        {
            set { _Codigo = value; }
            get { return _Codigo; }
        }

        public SqlDataReader VerificarTodo()
        {
            SqlDataReader veriTodo;
            veriTodo = objDato2.CodigoProveedorDni(Dni, codigo);
            return veriTodo;
        }
    }
}
