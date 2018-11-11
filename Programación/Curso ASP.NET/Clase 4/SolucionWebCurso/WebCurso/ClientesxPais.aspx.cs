using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class ClientesxPais : System.Web.UI.Page
    {
        Logica.Cliente objLogicaCliente = new Logica.Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
                TraerPaises();
        }
        void TraerPaises()
        {
            ddlPaises.DataSource = objLogicaCliente.TraerPaises();
            ddlPaises.DataValueField = "Country";
            ddlPaises.DataTextField = "Country";
            ddlPaises.DataBind();
            ddlPaises.Items.Insert(0, "<< Seleccione Pais >>");
        }


        void TraerClientes(string pPais)
        {
            gvClientes.DataSource = objLogicaCliente.TraerxPais(pPais);
            gvClientes.DataBind();
        }

        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPais = ddlPaises.SelectedValue.ToString();
            TraerClientes(strPais);
        }

    }
}