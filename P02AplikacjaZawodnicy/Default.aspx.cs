using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        IDostepDoDanych iDostepDoDanych = new ZawodnicyRepositoryLINQ();
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            Zawodnicy = iDostepDoDanych.WygenerujZawodnikow(1,5,"");
        }

 
        protected void btnNowy_Click(object sender, EventArgs e)
        {
            Response.Redirect("SzczegolyView.aspx");
        }
    }
}