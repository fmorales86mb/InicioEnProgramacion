using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace PruebaClase1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        protected void btnPag2_Click(object sender, EventArgs e)
        {
            // Este método tiene sobrecarga. Además del URL se puede ingresar un booleano, éste indica si se destruye o no la pág origen.
            Response.Redirect("~/Página 2.aspx", true);
        }

        protected void btn2Pag2_Click(object sender, EventArgs e)
        {
            // El booleano permite guardar los valores de la página de origen.
            Server.Transfer("~/Página 2.aspx", true);
        }

        protected void btnPag3_Click(object sender, EventArgs e)
        {
            // Creo un StringWriter, éste implementa un TextWriter, un ¿?... Se usa en una sobrecarga del Server.Execute
            StringWriter Dato;
            Dato=new StringWriter();

            Server.Execute("Página 3.aspx", Dato);
            lblDato.Text = Dato.ToString();
        }

        protected void btn3Pag2_Click(object sender, EventArgs e)
        {
            // Creo un string en partes.
            string url;
            string personal;
            string script;


            url = "Página 2.aspx";

    /* 
    width y height son su anchura y altura.
    top y left son su distancia al borde superior e izquierdo de la pantalla.
    menubar especifica si se quiere que el menú del navegador sea visible para la nueva ventana.
    resizable especifica si se permite o no que la nueva ventana sea redimensionable.
    location especifica si se muestra o no la caja para introducir direcciones.
    scrollbars especifica si se permite que aparezcan barras de desplazamiento o no.
    status especifica si se quiere visible la barra inferior de estatus.
    toolbar especifica si se hace o no visible la barra de herramientas del navegador.
    */
            personal = "width=300px, heiht=600px, top=50px, left=50px, menubar=no, resizable=no, location=no, scrollbar=yes, status=yes, toolbar=no";
            script = string.Format("<script type='text/javascript'>window.open('{0}', 'Pagina5', '{1}');</script>", url, personal);


            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Página 2", script);

            //string strPersonal = "toolbar=no,status=no,menubar=no,location=center,scrollbars=no,resizable=no,height=400,width=400";
            //string strScript = string.Format("<script type='text/javascript'>window.open('{0}', 'Pagina5', '{1}');</script>", url, strPersonal);
            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "pagina5", strScript);
        }
    }
}