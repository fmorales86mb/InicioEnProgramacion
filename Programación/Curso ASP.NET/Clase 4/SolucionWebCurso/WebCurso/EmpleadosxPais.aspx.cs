using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebCurso
{
    public partial class EmpleadosxPais : System.Web.UI.Page
    {
        DataView dvEmpleados = new DataView(); // para filtrar en memoria
        Logica.Empleado objLogicaEmpleado = new Logica.Empleado();// para acceder a los metodos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerPaises();
                TraerEmpleados();
            }
        }
               
        void TraerPaises()
        {

            ddlPaises.DataSource = objLogicaEmpleado.TraerPaises();
            ddlPaises.DataValueField = "Pais"; // campo a guardar para usar luego
            ddlPaises.DataTextField = "Pais"; // campo a visualizar en combo box
            ddlPaises.DataBind();
            ddlPaises.Items.Insert(0, "<< Seleccione >>");

        }

        void TraerEmpleados()
        {
            dvEmpleados = objLogicaEmpleado.TraerTodos().DefaultView;
            Session["Empleados"] = dvEmpleados;
        }

        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            // evento al cambiar de pais en combo box
            // guardo en variable el pais seleccionado
            string strPais = ddlPaises.SelectedValue.ToString();

            dvEmpleados = (DataView)Session["Empleados"];
            dvEmpleados.RowFilter = "Pais='" + strPais + "'";
            gvEmpleados.DataSource = dvEmpleados;
            gvEmpleados.DataBind();
        }

       

     
        

    }
}