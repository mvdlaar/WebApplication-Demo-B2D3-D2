﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;

namespace WebApplication1.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AanmakenToets aanmakenToets = new AanmakenToets();
            TextBox1.Text = aanmakenToets.MaakToetsAan(TextBox1.Text);

        }
    }
}