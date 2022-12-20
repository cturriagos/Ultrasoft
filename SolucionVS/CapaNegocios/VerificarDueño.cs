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
    public class VerificarDueño
    {
        private verificarDueño objDato2 = new verificarDueño();
        private string _DNI;
        public string dni
        {
            set { _DNI = value; }
            get { return _DNI; }
        }
        public VerificarDueño() { }
        public SqlDataReader Verificar()
        {
            SqlDataReader veri;
            veri = objDato2.DNI(dni);
            return veri;
        }
    }
}
