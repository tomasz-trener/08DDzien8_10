using P04AplikacjaZawodnicy.Core;
using P04AplikacjaZawodnicy.Core.DataSource;
using P04AplikacjaZawodnicy.Core.Domain;
using P04AplikacjaZawodnicy.Core.Zawodnicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy.ZawodnicyViews
{
    public partial class SzczegolyView : System.Web.UI.Page
    {
        IZawodnicyDataSource iDostepDoDanych = new ZawodnicyRepositoryLINQ();
        public Zawodnik Zawodnik;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ids = Request["id"];
            if (ids == null) // to znaczy, że jestesmy w trybie tworzenia nowego zawodnika
                return;

            int id = Convert.ToInt32(ids);
            Zawodnik= iDostepDoDanych.PodajZawodnika(id);

            if (!Page.IsPostBack)
            {
                txtImie.Text = Zawodnik.Imie;
                txtNazwisko.Text = Zawodnik.Nazwisko;
                txtKraj.Text = Zawodnik.Kraj;
                txtDataUr.Text = Zawodnik.DataUrodzenia.ToString("yyyy-MM-dd");
                txtWaga.Text = Convert.ToString(Zawodnik.Waga);
                txtWzrost.Text = Convert.ToString(Zawodnik.Wzrost);
            }
           
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            if(Zawodnik == null) // to znaczy jestesmy w trybie tworzenia
            {
                Zawodnik = new Zawodnik();
                zczytajTextboxy(Zawodnik);
                iDostepDoDanych.Dodaj(Zawodnik);
            } 
            else // jestesmy w trybie edycji 
            {
                zczytajTextboxy(Zawodnik);
                iDostepDoDanych.Edytuj(Zawodnik);
            }
            Response.Redirect("~\\Default.aspx");
        }

        private void zczytajTextboxy(Zawodnik z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            iDostepDoDanych.Usun(Zawodnik.Id_zawodnika);
            Response.Redirect("~\\Default.aspx");
        }
    }
}