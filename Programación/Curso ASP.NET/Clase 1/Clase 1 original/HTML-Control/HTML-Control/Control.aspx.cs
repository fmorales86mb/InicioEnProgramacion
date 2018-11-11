using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTML_Control
{
    public partial class Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblFecha.Text = "Esta es la hora y fecha actual del servidor: " + DateTime.Now.ToString();
        }
    }
}