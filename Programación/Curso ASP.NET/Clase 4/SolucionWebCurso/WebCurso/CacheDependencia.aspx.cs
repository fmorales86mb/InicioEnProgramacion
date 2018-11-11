using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class CacheDependencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerLibros();
                EnlazarGrid();
            }
        }

        // cargar en cache el resultado del dataview
        void TraerLibros()
        {
            Datos.Libro objLibro = new Datos.Libro();
            DataView dvLibros = objLibro.TraerLibros();

            // se carga y se destruye al modificarse el archivo de dependencia
            Cache.Insert("Libros", dvLibros, new CacheDependency(@"c:\Biblioteca\Libros.xml"), DateTime.MaxValue, TimeSpan.Zero);
        }
        void EnlazarGrid()
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
            EnlazarGrid();

        }

      

    }
}