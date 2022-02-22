using P04AplikacjaZawodnicy.Core;
using P04AplikacjaZawodnicy.Core.DataSource;
using P04AplikacjaZawodnicy.Core.Domain;
using P04AplikacjaZawodnicy.Core.Raporty;
using P04AplikacjaZawodnicy.Core.Zawodnicy;
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
        IZawodnicyDataSource iDostepDoDanych = new ZawodnicyRepositoryLINQ();
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            Zawodnicy = iDostepDoDanych.WygenerujZawodnikow(1,5,"");
        }

 
        protected void btnNowy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ZawodnicyViews\\SzczegolyView.aspx");
        }

        protected void btnRaport_Click(object sender, EventArgs e)
        {
            string sciezka = System.IO.Path.Combine(Request.PhysicalApplicationPath, "raport.pdf");
            //string sciezka = "c:\\dane\\zawpodnicyRaport.pdf";
            ManagerRaportow mr = new ManagerRaportow();
            mr.StworzRaportZawodnicy(Zawodnicy, sciezka);
            Response.Redirect("ZawodnicyViews\\RaportServer.aspx");

        }
    }
}