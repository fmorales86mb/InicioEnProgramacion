using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App.Pages {
    public partial class Producto : System.Web.UI.Page {

        

        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                TraerProductos();
            }
        }

        void TraerProductos() {
            Logica.Producto objLogicaProducto = new Logica.Producto();
            gvProductos.DataSource = objLogicaProducto.TraerTodos();
            // El DataBind enlaza el origen de datos al control de servidor.
            gvProductos.DataBind();
        }
    }
}