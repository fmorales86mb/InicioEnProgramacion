using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlIdioma.Items.Add("Español");
                ddlIdioma.Items.Add("Ingles");
                ddlIdioma.Items.Add("Frances");
            }
        }

        protected void ddlIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Saludo objSaludo = new Saludo();
            //lblSaludo.Text = objSaludo.Saludar(txtNombre.Text, ddlIdioma.SelectedItem.Text);
            lblSaludo.Text = objSaludo.Saludar(txtNombre.Text, ddlIdioma.Text);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Usuario objUsuario = new Usuario();
            //objUsuario.Nombre = txtNombre.Text;
            //objUsuario.Idioma = ddlIdioma.Text;
            //Session["Usuario"] = objUsuario;
            Session["Usuario"] = txtNombre.Text;
            Response.Redirect("Bienvenido.aspx");

        }
    }
}


 