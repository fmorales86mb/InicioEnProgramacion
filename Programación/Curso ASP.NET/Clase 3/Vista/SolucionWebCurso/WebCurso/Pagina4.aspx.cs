using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Pagina4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPag4Msj.Text = "UD ESTA EL PAGINA 4";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = "Pagina5.aspx";
            string strPersonal = "toolbar=no,status=no,menubar=no,location=center,scrollbars=no,resizable=no,height=400,width=400";
            string strScript = string.Format("<script type='text/javascript'>window.open('{0}', 'Pagina5', '{1}');</script>", url, strPersonal);
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "pagina5", strScript);

            
        }
    }
}