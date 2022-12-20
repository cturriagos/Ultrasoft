using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class Imagen
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        public string abrirConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=BASE DE DATOS DE PROYECTO INTEGRADOR;Integrated Security=True");
                cn.Open();
                return "Conectado";
            }
            catch(Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        public string insertarImagen(string dni,string nombre,string apellido,string usuario,string contraseña,string email,int idNivel, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                cmd = new SqlCommand("Insert into TB_Usuario(DNI,Nombre_Usuario,Apellido_Usuario,Usuario,Contraseña,Email,ID_Nivel,Imagen) values(@DNI,@Nombre_Usuario,@Apellido_Usuario,@Usuario,@Contraseña,@Email,@ID_Nivel,@Imagen)", cn);
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar);
                cmd.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@Apellido_Usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@ID_Nivel", SqlDbType.Int);
                cmd.Parameters.Add("@Imagen",SqlDbType.Image);

                cmd.Parameters["@DNI"].Value = dni;
                cmd.Parameters["@Nombre_Usuario"].Value = nombre;
                cmd.Parameters["@Apellido_Usuario"].Value = apellido;
                cmd.Parameters["@Usuario"].Value = usuario;
                cmd.Parameters["@Contraseña"].Value = contraseña;
                cmd.Parameters["@Email"].Value = email;
                cmd.Parameters["@ID_Nivel"].Value = idNivel;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }

        public void verImagen(PictureBox pbFoto, string descripcion)
        {
            try
            {
                da = new SqlDataAdapter("Select Imagen from TB_Usuario where Usuario = '" + descripcion + "'", cn);
                ds = new DataSet();
                da.Fill(ds, "TB_Usuario");
                byte[] datos = new byte[0];
                dr = ds.Tables["TB_Usuario"].Rows[0];
                datos = (byte[])dr["Imagen"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                
            }
        }

        public string actualizar (int COd, string dni, string nombre, string apellido, string usuario, string contraseña, string email, int idNivel, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                SqlCommand cm = new SqlCommand("UPDATE TB_Usuario set DNI=@DNI,Nombre_Usuario=@Nombre_Usuario,Apellido_Usuario=@Apellido_Usuario,Usuario=@Usuario,Contraseña=@Contraseña,Email=@Email,ID_Nivel=@ID_Nivel,Imagen=@Imagen WHERE [ID_Usuario] = " + COd , cn);
                cm.Parameters.Add("@DNI", SqlDbType.VarChar);
                cm.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar);
                cm.Parameters.Add("@Apellido_Usuario", SqlDbType.VarChar);
                cm.Parameters.Add("@Usuario", SqlDbType.VarChar);
                cm.Parameters.Add("@Contraseña", SqlDbType.VarChar);
                cm.Parameters.Add("@Email", SqlDbType.VarChar);
                cm.Parameters.Add("@ID_Nivel", SqlDbType.Int);
                cm.Parameters.Add("@Imagen", SqlDbType.Image);

                cm.Parameters["@DNI"].Value = dni;
                cm.Parameters["@Nombre_Usuario"].Value = nombre;
                cm.Parameters["@Apellido_Usuario"].Value = apellido;
                cm.Parameters["@Usuario"].Value = usuario;
                cm.Parameters["@Contraseña"].Value = contraseña;
                cm.Parameters["@Email"].Value = email;
                cm.Parameters["@ID_Nivel"].Value = idNivel;
                System.IO.MemoryStream m = new System.IO.MemoryStream();
                pbImagen.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                cm.Parameters["@Imagen"].Value = m.GetBuffer();
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }
    }
}
