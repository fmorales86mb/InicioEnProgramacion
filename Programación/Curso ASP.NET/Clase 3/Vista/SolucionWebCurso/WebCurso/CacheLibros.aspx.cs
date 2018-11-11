using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class CacheLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerLibros();
                Actualizar();
            }
        }

        // cargar en cache el resultado del dataview
        void TraerLibros()
        {
            Datos.Libro objLibro = new Datos.Libro();
            DataView dvLibros = objLibro.TraerLibros();

            // CACHE DISPONIBLE - se carga hasta que volvamos a ejecutar este metodo
            Cache["Libros"] = dvLibros;

            // CACHE TIEMPO ABSOLUTO se carga y se destruye a los n minutos que le configuremos
           //Cache.Insert("Libros",dvLibros, null, DateTime.Now.AddMinutes(1), TimeSpan.Zero); 

            //CAHE TIEMPO RELATIVO se carga y se destruye a los n segundos de inactividad
           // Cache.Insert("Libros", dvLibros, null, DateTime.MaxValue, TimeSpan.FromSeconds(15));

        }
        void Actualizar()
        {
            gvLibros.DataSource = (DataView)Cache["Libros"];
            gvLibros.DataBind();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            if (Cache["Libros"] == null)
            {
                TraerLibros();
            }
            Actualizar();
        }
    }
}