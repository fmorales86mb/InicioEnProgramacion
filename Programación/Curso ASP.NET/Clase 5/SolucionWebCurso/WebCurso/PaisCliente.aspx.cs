using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class PaisCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                lblPais.Text = "Debe ingresar un codigo de cliente";
            }
            else
            { 
                srServicioCursoBD.ServicioCursoBDSoapClient ws = new srServicioCursoBD.ServicioCursoBDSoapClient();
                lblPais.Text = ws.TraerPais(Convert.ToInt32(txtID.Text)).ToString();
            }
        }
    }
}