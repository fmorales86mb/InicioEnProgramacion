using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class VistaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TraerClientes();
        }

        void TraerClientes()
        {
            Logica.Cliente objLogicaCliente = new Logica.Cliente();
            gvClientes.DataSource = objLogicaCliente.TraerTodos();
            gvClientes.DataBind();

        }

        protected void gvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvClientes.PageIndex = e.NewPageIndex;
            TraerClientes();
        }

       
  
    }
}