using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App.Pages
{
    public partial class Destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Método QueryString
            lblInformacionRecibida.Text = Request.QueryString["valor"].ToString();
        }
    }
}