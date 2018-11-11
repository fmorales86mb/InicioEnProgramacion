using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Sumar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            srServicioCurso.ServicioCursoSoapClient ws = new srServicioCurso.ServicioCursoSoapClient();
            int intNro1 =Convert.ToInt32(txtNro1.Text);
            int intNro2 = Convert.ToInt32(txtNro2.Text);

            lblSuma.Text = ws.Sumar(intNro1, intNro2).ToString();
        }
    }
}