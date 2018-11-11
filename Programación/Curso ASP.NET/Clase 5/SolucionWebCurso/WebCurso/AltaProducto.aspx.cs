using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class AltaProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                traerCategorias();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    //lblMensaje.Text = "Datos Validados!";
                    Logica.Producto objLogicaProducto = new Logica.Producto();
                    Entidades.Producto objEntidadProducto = new Entidades.Producto();
                    objEntidadProducto.ProductId = Convert.ToInt32(txtCodigo.Text);
                    objEntidadProducto.ProductName = txtNombre.Text;
                    objEntidadProducto.UnitPrice = Convert.ToDecimal(txtPrecio.Text);
                    objEntidadProducto.UnitsInStock = Convert.ToInt32(txtStock.Text);
                    objEntidadProducto.CategoryID = Convert.ToInt32(ddlCategorias.SelectedValue);
                    objLogicaProducto.Agregar(objEntidadProducto);
                    lblMensaje.Text = "Alta OK!";
                }
                catch (Exception ex)
                {

                    lblMensaje.Text= ex.Message;
                }             

            }
            else
            {
                lblMensaje.Text = "Datos NO Validados!";
            }
        }

        void traerCategorias()
        {
            Logica.Producto objLogicaProducto = new Logica.Producto();
            ddlCategorias.DataSource = objLogicaProducto.TraerCategorias();
            ddlCategorias.DataValueField = "CategoryId";
            ddlCategorias.DataTextField = "CategoryName";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, "<< Seleccione >>");
        }
    }
}