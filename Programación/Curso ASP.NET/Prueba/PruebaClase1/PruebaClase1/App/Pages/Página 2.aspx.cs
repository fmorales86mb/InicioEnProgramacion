using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections.Specialized;

namespace PruebaClase1
{
    public partial class Página_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Para este tipo de colección agrego el namespace Collections.Specialized. Ver los tipos de colecciones.
            NameValueCollection Coleccion;
            Coleccion = new NameValueCollection ();
            Coleccion = Request.Form;

            lblCopiaHora.Text = Coleccion["tbPag1"];
        }
    }
}