using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App.Pages {
    public partial class Cliente : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                TraerClientes();
            }
        }
        void TraerClientes() {
            Logica.Cliente ObjLogicaCliente = new Logica.Cliente();
            gvCliente.DataSource = ObjLogicaCliente.TraerTodos();
            gvCliente.DataBind();
        }

        protected void gvCliente_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            gvCliente.PageIndex = e.NewPageIndex;
            TraerClientes();
        }
    }
}