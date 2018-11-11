using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Hay dos maneras de crear Cookies en C#. Responce y HTTP
        // Problema: la cookie queda guardada, entonces cuando abro nuevamente la aplicación, ya tengo un valor en la cookie.
        protected void btnGuardarCookie_Click(object sender, EventArgs e)
        {
            /*
            
             * Método Response.Cookies [Nombre] 
            
            Response.Cookies["Entrada"].Value = this.tbCookie.Text;       
            lblMensaje.Text = "Cookie guardada";
            */

            HttpCookie cookie = Request.Cookies["Entrada"];
            if (cookie == null) {
                cookie = new HttpCookie("Entrada");
            }
            cookie["Dato"] = this.tbCookie.Text;
            cookie.Expires = DateTime.MaxValue; // Cookie Permanente
            Response.Cookies.Add(cookie); // Guardo Cookie
            lblMensaje.Text = "Cookie Guardada";
        }

        protected void btnRecuperarCookie_Click(object sender, EventArgs e)
        {
            /*
             
             * Método Response
             
            if (Request.Cookies["Entrada"]==null)
            {
                lblMensaje.Text = "No hay Cookies guardadas.";
            }
            else {
                lblCookieRecuperado.Text = Request.Cookies["Entrada"].Value.ToString();
                lblMensaje.Text = "";
            }
            */

            HttpCookie cookie = Request.Cookies["Entrada"];
            if (cookie == null)
            {
                this.lblMensaje.Text = "No hay cookies guardadas";
            }
            else {
                lblCookieRecuperado.Text = cookie["Dato"].ToString();
                lblMensaje.Text = "";
            }

        }
    }
}