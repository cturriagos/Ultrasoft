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
    public class VRFCliente
    {
        private ComprovarCliente objDato2 = new ComprovarCliente();
        private int _COD;
        public int cod
        {
            set { _COD = value; }
            get { return _COD; }
        }
        public VRFCliente() { }
        public SqlDataReader Verificar()
        {
            SqlDataReader veri;
            veri = objDato2.COD(cod);
            return veri;
        }

        //private string _Dni;
        private int _Codigo;
        //public string Dni
        //{
        //    set { _Dni = value; }
        //    get { return _Dni; }
        //}

        public int codigo
        {
            set { _Codigo = value; }
            get { return _Codigo; }
        }

        public SqlDataReader VerificarTodo()
        {
            SqlDataReader veriTodo;
            veriTodo = objDato2.CodigoClienteyDni(cod);
            return veriTodo;
        }
    }
}
