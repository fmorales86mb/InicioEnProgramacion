using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Bienvenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Usuario objUsuario = new Usuario();
            //objUsuario = (Usuario)Session["Usuario"];
            //lblUsuario.Text = objUsuario.Nombre;
            lblUsuario.Text = Session["Usuario"].ToString();
        }
    }
}