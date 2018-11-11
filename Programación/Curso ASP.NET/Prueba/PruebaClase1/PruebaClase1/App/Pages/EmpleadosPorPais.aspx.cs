using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PruebaClase1.App.Pages {
    public partial class EmpleadosPorPais : System.Web.UI.Page {

        Logica.Empleado ObjLogicaEmpleado = new Logica.Empleado();
        DataView dvEmpleados;

        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                TraerPaises();
                TraerEmpleados();                
            }
            
        }

        // ver este método
        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e) {
            ddlPaises.Items.RemoveAt(0);
            dvEmpleados = (DataView) Session["Empleados"];
            dvEmpleados.RowFilter = "Pais='" + ddlPaises.SelectedValue.ToString() + "'";
            gvEmpleados.DataSource = dvEmpleados;
            gvEmpleados.DataBind();

        }

        // ver este método
        void TraerPaises() {
            ddlPaises.DataSource = ObjLogicaEmpleado.TraerPaises();
            ddlPaises.DataValueField = "Pais";
            ddlPaises.DataTextField = "Pais";
            ddlPaises.Items.Insert(0, "<<Seleccione>>");
        }

        // ver este método.
        void TraerEmpleados() {
            dvEmpleados = ObjLogicaEmpleado.TraerTodos().DefaultView;
            Session["Empleados"] = dvEmpleados;
        }
    }
}