using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P04AJAX
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             string s1= Request["name"];
            string s2 = Request["location"];

            Response.Write("ala ma kota (serveR)" + s1 + s2) ;
        }
    }
}