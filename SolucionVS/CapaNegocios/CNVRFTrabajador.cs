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
    public class CNVRFTrabajador
    {
        private VRFtrabajador objDato2 = new VRFtrabajador();
        private string _DNI;
        public string dni
        {
            set { _DNI = value; }
            get { return _DNI; }
        }
        public CNVRFTrabajador() { }
        public SqlDataReader Verificar()
        {
            SqlDataReader veri;
            veri = objDato2.DNI(dni);
            return veri;
        }
    }
}
