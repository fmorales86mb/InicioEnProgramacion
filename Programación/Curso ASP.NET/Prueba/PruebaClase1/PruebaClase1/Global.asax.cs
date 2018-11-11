using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace PruebaClase1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Conectados"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
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

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["Conectados"] = Convert.ToInt32(Application["Conectados"]) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}