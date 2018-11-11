using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MisServiciosWEB
{
    /// <summary>
    /// Summary description for ServicioCursoBD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCursoBD : System.Web.Services.WebService
    {

        [WebMethod]
        public string TraerPais(int pIdCliente)
        {
            string strPais;
            string strConexion = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            string strSql = "select Country from Customer where CustomerId="+ pIdCliente;
            SqlConnection objConexion = new SqlConnection(strConexion);
            SqlCommand objCommand = new SqlCommand(strSql, objConexion);
            SqlDataReader drPais;
            try
            {
                objConexion.Open();
                drPais = objCommand.ExecuteReader();
                if (drPais.Read())
                    strPais = drPais["Country"].ToString();
                else
                    strPais = "No existe ese Cliente";
            }
            catch (Exception ex)
            {

                strPais = "Error en web service - "+ ex.Message;
            }
            finally
            {
                objConexion.Close();
            }
            return strPais;

        }

        [WebMethod]
        public DataSet ProductosxCategoria (int pIdCategoria)
        {
            string strConexion = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            DataSet ds = new DataSet();
            string strsql = "Select ProductId, ProductName, UnitsinStock ";
            strsql += " from products where categoryId="+ pIdCategoria;
            SqlDataAdapter da = new SqlDataAdapter(strsql,strConexion);
            da.Fill(ds);
            return ds;
        }
    }
}
