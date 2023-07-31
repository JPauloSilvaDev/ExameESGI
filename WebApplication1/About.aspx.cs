using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteAdmissao
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = Session["Logged"];

            if (session != null)
            {
                Session.Abandon();
               
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        
        
        }
    }
}