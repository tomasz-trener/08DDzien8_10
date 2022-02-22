using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P04AJAX
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrzyciskNET_Click(object sender, EventArgs e)
        {
            lblWynik.Text = "ala ma kota";
        }
    }
}