using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebCurso
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // este evento se dispara cuando el primer usuario inicia la app
            Application["Conectados"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // se dispara cuando cada usuario inicia su sesion
            Application["Conectados"] = Convert.ToInt32(Application["Conectados"]) + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Server.Transfer("~/Error2.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // se dispara al cerrar la sesion de cada usuario
            Application["Conectados"] = Convert.ToInt32(Application["Conectados"]) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}