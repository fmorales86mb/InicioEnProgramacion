using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class ProductosxCategoria : System.Web.UI.Page
    {
        Logica.Producto objLogicaProducto = new Logica.Producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TraerCategorias();
        }

        void TraerCategorias()
        {
            ddcategorias.DataSource = objLogicaProducto.TraerCategorias();
            ddcategorias.DataValueField = "CategoryId";
            ddcategorias.DataTextField = "CategoryName";
            ddcategorias.DataBind();
            ddcategorias.Items.Insert(0,"<<Seleccione>>");
        }

        void TraerProductosxCategoria(int pCategoriaId)
        {
            srServicioCursoBD.ServicioCursoBDSoapClient ws = new srServicioCursoBD.ServicioCursoBDSoapClient();
            gvProductoxCategoria.DataSource = ws.ProductosxCategoria(pCategoriaId);
            gvProductoxCategoria.DataBind();
        }

        protected void ddcategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intCategoria = Convert.ToInt32(ddcategorias.SelectedValue);
            TraerProductosxCategoria(intCategoria);
        }
    }
}