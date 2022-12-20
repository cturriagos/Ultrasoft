using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CDRegistros
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        private SqlDataReader LeerFilas;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCompras ()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select  c.Cod_Cliente as Código,c.Nombre_Cliente as Nombre, c.Apellido_Cliente as Apellido, f.Num_Venta as Número_compra, f.Fecha as Fecha, D.Cantidad_Peso AS Peso,P.Cod_Producto as Código_Producto,P.Nom_Producto AS Producto, D.Precio_Producto AS Precio  from TB_Cliente as c inner join TB_FacturaCliente as f on C.Cod_Cliente=f.Cod_Cliente inner join TB_DetalleFacturaCliente D on f.Num_Venta=d.Num_Venta inner join TB_Producto P on d.Cod_Producto=p.Cod_Producto order by c.Cod_Cliente, f.Num_Factura desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable CadaCliente(int cod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "    select  c.Cod_Cliente as Código,c.Nombre_Cliente as Nombre, c.Apellido_Cliente as Apellido,  f.Fecha as Fecha,P.Nom_Producto AS Producto, D.Cantidad_Peso AS QQ  from TB_Cliente as c inner join TB_FacturaCliente as f on C.Cod_Cliente=f.Cod_Cliente inner join TB_DetalleFacturaCliente D on f.Num_Venta=d.Num_Venta inner join TB_Producto P on d.Cod_Producto=p.Cod_Producto where c.Cod_Cliente="+cod+" order by c.Cod_Cliente,f.Num_Venta desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable DtoVentaCliente(int cod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "  select  c.Cod_Cliente as Código,c.Nombre_Cliente as Nombre, c.Apellido_Cliente as Apellido, f.Num_Venta as Número_compra, f.Fecha as Fecha, D.Cantidad_Peso AS Peso,P.Nom_Producto AS Producto, D.Precio_Producto AS Precio  from TB_Cliente as c inner join TB_FacturaCliente as f on C.Cod_Cliente=f.Cod_Cliente inner join TB_DetalleFacturaCliente D on f.Num_Venta=d.Num_Venta inner join TB_Producto P on d.Cod_Producto=p.Cod_Producto where c.Cod_Cliente="+cod+" order by c.Cod_Cliente, f.Num_Factura asc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable MostrarVentas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  c.Cod_Proveedor as Código,c.Nombre_Proveedor as Nombre, c.Apellido_Proveedor as Apellido, f.Num_Compra as Número_venta, f.Num_Factura as Número_factura, f.Fecha as Fecha, D.Cantidad_Peso AS Peso,P.Cod_Producto as Código_Producto,P.Nom_Producto AS Producto, D.Precio_Producto AS Precio  from TB_Proveedor as c inner join TB_FacturaProveedor as f on C.Cod_Proveedor=f.Cod_Proveedor inner join TB_DetalleFacturaProveedor D on f.Num_Compra=d.Num_Compra inner join TB_Producto P on d.Cod_Producto=p.Cod_Producto";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarBodega()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select b.Cod_Bodega as Código, b.Direccion_Comercial as Dirección_Comercial,d.Numero_Registro as Número_Registro , d.Fecha as Fecha, p.Nom_Producto as Producto, d.Cantidad_Peso_Total_Bodega as Peso, p.Tipo_Peso as  Tipo_Peso from TB_Bodega as b inner join TB_Detalle_Bodega as d on b.Cod_Bodega=d.Cod_Bodega inner join TB_Producto as p on d.Cod_Producto= p.Cod_Producto";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void eliminar(int numeroregistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_Detalle_Bodega WHERE Numero_Registro = " + numeroregistro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable ContarCompras(int  NumCompra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(Num_Venta) as total from TB_DetalleFacturaCliente where Num_Venta="+NumCompra+ "group by Num_Venta";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void eliminarCompra1(int numVenta,int codigoPro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_DetalleFacturaCliente WHERE Num_Venta = " + numVenta+ "and Cod_Producto="+codigoPro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void eliminarCompra2(int numVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_FacturaCliente WHERE Num_Venta = " + numVenta;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable ContarVentas(int NumVentas)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(Num_Compra) as total from TB_DetalleFacturaProveedor where Num_Compra=" + NumVentas + "group by Num_Compra";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void eliminarVenta1(int numVenta, int codigoPro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_DetalleFacturaProveedor WHERE Num_Compra = " + numVenta + "and Cod_Producto=" + codigoPro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void eliminarVenta2(int numVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM TB_FacturaProveedor WHERE Num_Compra = " + numVenta;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
