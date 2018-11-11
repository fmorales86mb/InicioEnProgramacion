using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblValor.Text = Request.QueryString["valor"].ToString();
        }
    }
}