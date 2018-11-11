using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App.Pages {
    public partial class VistaEmpleados : System.Web.UI.Page {
        
        Logica.Empleado objLogicaEmpleado = new Logica.Empleado();

        protected void Page_Load(object sender, EventArgs e) {
            // Corroboro que la carga de la pág no sea por un postback.
            if (!Page.IsPostBack) {
                TraerEmpleados();
            }
        }

        /// <summary>
        /// Carga el grid view con Empleados.
        /// </summary>
        void TraerEmpleados() {
            gvEmpleados.DataSource = objLogicaEmpleado.TraerTodos();
            gvEmpleados.DataBind();
        }

        // Ver este método.. Al parecer cada vez que cambia de página vuelve a conectarse a la BD. 
        // Hay otro método en el que se guarda la información en caché. (ver)
        protected void gvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            gvEmpleados.PageIndex = e.NewPageIndex;
            TraerEmpleados();
        }
    }
}