using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1
{
    public partial class Página_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPag3Minutos.Text = "Minuto: " + DateTime.Now.Minute;
        }
    }
}