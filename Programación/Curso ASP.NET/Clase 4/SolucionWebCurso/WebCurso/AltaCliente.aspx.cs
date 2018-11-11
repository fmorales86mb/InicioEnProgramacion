using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class AltaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Logica.Cliente objLogicaCliente = new Logica.Cliente();
            Entidades.Customer objEntidadCliente = new Entidades.Customer();
            objEntidadCliente.CustomerID = int.Parse(txtID.Text);
            objEntidadCliente.CompanyName = txtNombre.Text;
            objEntidadCliente.ContactName = txtContacto.Text;
            objEntidadCliente.Country = txtPais.Text;
            objEntidadCliente.City = txtCiudad.Text;
            objLogicaCliente.Agregar(objEntidadCliente);
            lblMensaje.Text = "Alta OK!";
            txtID.Text = "";
            txtNombre.Text = "";
            txtContacto.Text = "";
            txtPais.Text = "";
            txtCiudad.Text = "";
        }
    }
}