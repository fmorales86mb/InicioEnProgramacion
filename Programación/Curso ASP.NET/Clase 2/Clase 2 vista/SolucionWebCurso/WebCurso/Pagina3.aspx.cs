using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Pagina3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsjPag3.Text = "Esta en pagina 3";
            NameValueCollection pColForm = new NameValueCollection();
            pColForm = Request.Form;
            lblNombre.Text = pColForm["txtNombre"];
        }

        protected void btnIrAPagina4_Click(object sender, EventArgs e)
        {
            StringWriter dato = new StringWriter();
            Server.Execute("Pagina4.aspx", dato);
            lblDato.Text = dato.ToString();
        }
    }
}