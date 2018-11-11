using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class VistaEmpleados : System.Web.UI.Page
    {
        Logica.Empleado objLogicaEmpleado = new Logica.Empleado();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TraerEmpleados();
        }
        void TraerEmpleados()
        {
            gvEmpleados.DataSource = objLogicaEmpleado.TraerTodos();
            gvEmpleados.DataBind();
        }

        protected void gvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmpleados.PageIndex = e.NewPageIndex;
            TraerEmpleados();
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Server.Transfer("~/MostrarError.aspx");
        }
    }
}