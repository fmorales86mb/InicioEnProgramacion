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
            lblPagMsj4.Text = "UD ESTA EN PAGINA 4";
        }

        protected void btnPagina5_Click(object sender, EventArgs e)
        {
            //string url = "Pagina5.aspx";
            //string personal = "toolbar=no,status=no,menubar=no,location=center,scrollbar=no,resizable=no,height=400,width=400";
            //string strScript = string.Format("<script type='text/javascript'>windows.open('{0}','Pagina5','{1}');</script>",url,personal);
            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "pagina5", strScript);
            string url = "Pagina5.aspx";
            string strPersonal = "toolbar=no,status=no,menubar=no,location=center,scrollbars=no,resizable=no,height=400,width=400";
            string strScript = string.Format("<script type='text/javascript'>window.open('{0}', 'Pagina5', '{1}');</script>", url, strPersonal);
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "pagina5", strScript);
        }
    }
}