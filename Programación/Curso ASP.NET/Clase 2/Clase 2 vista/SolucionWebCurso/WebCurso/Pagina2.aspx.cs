using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTexto.Text = "Usted esta en la Pagina 2";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Pagina3.aspx", true);
        }
    }
}