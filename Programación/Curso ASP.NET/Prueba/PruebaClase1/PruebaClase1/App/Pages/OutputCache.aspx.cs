﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaClase1.App
{
    public partial class OutputCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}