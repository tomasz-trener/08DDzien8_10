using P04AplikacjaZawodnicy.Core;
using P04AplikacjaZawodnicy.Core.DataSource;
using P04AplikacjaZawodnicy.Core.Domain;
using P04AplikacjaZawodnicy.Core.Zawodnicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filtr = Request["filtr"];

            string wielkoscStrony = Request["wielkoscStrony"];
            string numerStrony = Request["numerStrony"];


            IZawodnicyDataSource iDostepDoDanych = new ZawodnicyRepositoryLINQ();
            
            Zawodnik[] zawodnicy;
            if (string.IsNullOrEmpty(wielkoscStrony))
                zawodnicy = iDostepDoDanych.Filtruj(filtr);
            else
                zawodnicy = iDostepDoDanych.WygenerujZawodnikow(
                    Convert.ToInt32(numerStrony),
                    Convert.ToInt32(wielkoscStrony), 
                    filtr); ;

            Thread.Sleep(5000);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string naps= jss.Serialize(zawodnicy);
            Response.Write(naps);
        }
    }
}