using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// agrego para usar las configuraciones del web.config.
using System.Configuration;

namespace PruebaClase1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = ConfigurationManager.AppSettings["Empresa"];
            lblFechaHora.Text = DateTime.Now.ToShortDateString();

            lblNroConectados.Text = Application["Conectados"].ToString();
        }

    }
}