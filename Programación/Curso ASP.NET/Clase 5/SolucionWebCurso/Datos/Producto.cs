using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        // metodos
        public List<Entidades.Producto> TraerTodos()
        {
            List<Entidades.Producto> productos = new List<Entidades.Producto>();

            DataTable dt = new DataTable();
            string strSQL = "Select * from Products";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            da.Fill(dt);
            foreach (DataRow fila in dt.Rows)
            {
                Entidades.Producto produ = new Entidades.Producto();
                produ.ProductId = (int)fila["ProductID"];
                produ.CategoryID = (int)fila["CategoryId"];
                produ.ProductName = fila["ProductName"].ToString();
                produ.UnitsInStock = Convert.ToInt32(fila["UnitsInStock"]);
                produ.UnitPrice = Convert.ToDecimal(fila["UnitPrice"]);
                productos.Add(produ);
            }

            return productos;

        }

        //Para Modificar Producto
        public DataTable TraerParaModificar()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from VistaProductos";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            da.Fill(dt);
            return dt;
        }

        public Entidades.Producto TraerUno(int pId)
        {
            Entidades.Producto produ = new Entidades.Producto();

            DataTable dt = new DataTable();
            string strSQL = "Select * from Products where ProductID=" + pId;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraerUno = new SqlCommand(strSQL, objConexion);
            SqlDataReader dr;
            objConexion.Open();
            dr = comTraerUno.ExecuteReader();
            dr.Read();
            produ.ProductId = (int)dr["ProductID"];
            produ.ProductName = dr["ProductName"].ToString();
            produ.UnitsInStock = Convert.ToInt32(dr["UnitsInStock"]);
            produ.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
            objConexion.Close();
            return produ;
        }

        public void Modificar(Entidades.Producto pProducto)
        {
            string strSql = "Update products Set productname=@Nombre,unitPrice=@Precio,unitsInStock=@Stock where productID=" + pProducto.ProductId;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comModifica = new SqlCommand(strSql, objConexion);
            comModifica.Parameters.AddWithValue("@Nombre", pProducto.ProductName);
            comModifica.Parameters.AddWithValue("@Categoria", pProducto.CategoryID);
            comModifica.Parameters.AddWithValue("@Precio", pProducto.UnitPrice);
            comModifica.Parameters.AddWithValue("@Stock", pProducto.UnitsInStock);
            objConexion.Open();
            comModifica.ExecuteNonQuery();
            objConexion.Close();

        }

        //Para agregar producto

        public DataTable TraerCategorias()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from Categories";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            da.Fill(dt);
            return dt;
        }
        public void Agregar(Entidades.Producto pProducto)
        {
            string strSql = "Insert productS(productid1,productName,categoryID,UnitPrice,UnitsInStock)";
            strSql += " Values(@Codigo,@Nombre,@Categoria,@Precio,@Stock)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAgregar = new SqlCommand(strSql, objConexion);
            comAgregar.Parameters.AddWithValue("@Codigo", pProducto.ProductId);
            comAgregar.Parameters.AddWithValue("@Nombre", pProducto.ProductName);
            comAgregar.Parameters.AddWithValue("@Categoria", pProducto.CategoryID);
            comAgregar.Parameters.AddWithValue("@Precio", pProducto.UnitPrice);
            comAgregar.Parameters.AddWithValue("@Stock", pProducto.UnitsInStock);
            try
            {                
                objConexion.Open();
                comAgregar.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa datoa, Alta Producto -"+ex.Message);
            }
            finally
            {
                objConexion.Close();
            }

            

        }
    }
}
