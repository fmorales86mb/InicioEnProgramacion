using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class VistaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TraerProductos();

        }
        void TraerProductos()
        {
            Logica.Producto objLogicaProducto = new Logica.Producto();
            gvProductos.DataSource = objLogicaProducto.traerTodos();
            gvProductos.DataBind();

        }
    }
}