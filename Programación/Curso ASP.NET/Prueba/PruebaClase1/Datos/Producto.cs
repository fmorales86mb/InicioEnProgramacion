using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class Producto {
        public List<Entidades.Producto> TraerTodos() {

            Entidades.Producto objEntidadesProducto;
            List<Entidades.Producto> lista;
            string strSQL;
            SqlDataAdapter da;
            DataTable dt;

            
            lista = new List<Entidades.Producto>();
            dt = new DataTable();
            strSQL = "select productid, categoryid as Categoría, productname as NombreDelProducto, unitsinstock as UnidadesEnStock, unitprice as PrecioUnitario from products";
            da = new SqlDataAdapter(strSQL, Conexion.strConexion);
            
            da.Fill(dt);

            foreach (DataRow fila in dt.Rows) {
                // Inicializo dentro del foreach porque sino la lista se crea con objetos iguales.
                objEntidadesProducto = new Entidades.Producto();
                objEntidadesProducto.ProductId = (int) fila[0];
                objEntidadesProducto.CategoryId = (int) fila[1];
                objEntidadesProducto.ProductName = fila[2].ToString();
                objEntidadesProducto.UnitsInStock = (int) fila[3];
                objEntidadesProducto.UnitPrice = (decimal) fila[4];

                lista.Add(objEntidadesProducto);
            }

            return lista;            

        }
    }
}
