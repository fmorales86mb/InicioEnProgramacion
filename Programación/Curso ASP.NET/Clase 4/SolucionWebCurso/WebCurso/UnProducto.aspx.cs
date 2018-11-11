using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class UnProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int intID = Convert.ToInt32(Request.QueryString["id"]);
                Logica.Producto objLogicaProducto = new Logica.Producto();
                Entidades.Producto miProducto = new Entidades.Producto();
                miProducto = objLogicaProducto.TraerUno(intID);
                txtNombre.Text = miProducto.ProductName;
                txtPrecio.Text = miProducto.UnitPrice.ToString();
                txtStock.Text = miProducto.UnitsInStock.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Logica.Producto objLogicaProducto = new Logica.Producto();
            Entidades.Producto objEntidadProducto = new Entidades.Producto();
            objEntidadProducto.ProductId = Convert.ToInt32(Request.QueryString["id"]);
            objEntidadProducto.ProductName = txtNombre.Text;
            objEntidadProducto.UnitPrice = Convert.ToDecimal(txtPrecio.Text);
            objEntidadProducto.UnitsInStock = Convert.ToInt32(txtStock.Text);
            objLogicaProducto.Modificar(objEntidadProducto);
            lblMensaje.Text = "Modificacion OK";

            string funcion = "<script language='Javascript'>window.opener.location = window.opener.location;</script>";
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "refresh", funcion);
        }
    }
}