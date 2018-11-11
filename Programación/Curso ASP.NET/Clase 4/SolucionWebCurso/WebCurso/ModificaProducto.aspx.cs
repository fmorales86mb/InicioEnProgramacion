using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class ModificaProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TraerProductos();

        }
        void TraerProductos()
        {
            Logica.Producto objLogicaProducto = new Logica.Producto();
            gvProductos.DataSource = objLogicaProducto.TraerParaModificar();
            gvProductos.DataBind();

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            TraerProductos();
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvProductos.SelectedRow;
            lblID.Text = row.Cells[2].Text;
            string url = "UnProducto.aspx?id=" + row.Cells[1].Text;
            string strPersonal = "toolbar=no,status=no,menubar=no,location=center,scrollbars=no,resizable=no,height=200,width=400";
            string strScript = string.Format("<script type='text/javascript'>window.open('{0}', 'producto', '{1}');</script>", url, strPersonal);
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "producto", strScript);


        }
    }
}