using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //HttpCookie cookie = Request.Cookies["Valores"];
            //if (cookie == null)
            //    cookie = new HttpCookie("Valores");
            //cookie["Dato"] = this.txtCookie.Text;
            //cookie.Expires = DateTime.MaxValue; // cookie permanente
            //Response.Cookies.Add(cookie);// guardo cookie
            //lblmensaje.Text = "Cookie Guardada!";


            Response.Cookies["Entrada"].Value = this.txtCookie.Text; 
            lblmensaje.Text = "Cookie Guardada!";
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            //HttpCookie cookie = Request.Cookies["Valores"];

            //if (cookie == null)
            //    this.lblmensaje.Text = "No hay cookies guardadas";
            //else
            //    this.lblValorCookie.Text = cookie["Dato"].ToString();

            HttpCookie cookie = Request.Cookies["Entrada"];            
            if (cookie == null)
                this.lblmensaje.Text = "No hay cookies guardadas";
            else
            {
                this.lblValorCookie.Text = Request.Cookies["Entrada"].Value;
                Response.Cookies["Entrada"].Expires = DateTime.Now.AddDays(-1);
            }
           
        }
    }
}