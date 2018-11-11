using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App.Pages
{
    public partial class Origen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            // Con este método adhiero un string al url como información.
            string informacion = this.tbInformacion.Text;

            Response.Redirect("~/App/Pages/Destino.aspx?valor=" + informacion);
        }
    }
}