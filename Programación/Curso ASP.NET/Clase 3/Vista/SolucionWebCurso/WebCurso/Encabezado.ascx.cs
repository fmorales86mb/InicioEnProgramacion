using System;
using System.Collections.Generic;
//using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Encabezado : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // lblEmpresa.Text = ConfigurationManager.AppSettings["Empresa"];
            lblEmpresa.Text = System.Configuration.ConfigurationManager.AppSettings["Empresa"];
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblConectados.Text = Application["Conectados"].ToString();
        }
    }
}