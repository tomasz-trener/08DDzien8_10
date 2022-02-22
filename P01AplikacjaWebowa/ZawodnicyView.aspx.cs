using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowa
{
    public partial class ZawodnicyView : System.Web.UI.Page
    {
        IDostepDoDanych iDostepDoDanych = new ZawodnicyRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
                foreach (var k in Zawodnik.Kolumny)
                    clbKolumny.Items.Add(new ListItem(k.Nazwa) { Selected=k.Widocznosc });
        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {

            Odswiez();
        }

        private void Odswiez()
        {
            List<string> kolumny = new List<string>();

            foreach (ListItem k in clbKolumny.Items)
                if (k.Selected)
                    kolumny.Add(k.ToString());

            //Zawodnik.KolumnyZWidoku = new string[]{ "Imie","Nazwisko" };
            Zawodnik.KolumnyZWidoku = kolumny.ToArray();

            Zawodnik[] zawodnicy = iDostepDoDanych.WygenerujZawodnikow();
            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "WidoczneKolumny";
            lbDane.DataValueField = "Id_zawodnika";
            lbDane.DataBind();

        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik();
            zczytajTextobxy(z);
            iDostepDoDanych.Dodaj(z);
            Odswiez();
        }

        private void zczytajTextobxy(Zawodnik z)
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
            int id = Convert.ToInt32(lbDane.SelectedValue);
            iDostepDoDanych.Usun(id);
            Odswiez();
        }

        protected void btnEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            Zawodnik z = iDostepDoDanych.PodajZawodnika(id);
            zczytajTextobxy(z);
            iDostepDoDanych.Edytuj(z);
            Odswiez();
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            Zawodnik z= iDostepDoDanych.PodajZawodnika(id);
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            txtDataUr.Text = z.DataUrodzenia.ToString("yyyy-MM-dd");
            txtWaga.Text = Convert.ToString(z.Waga);
            txtWzrost.Text = Convert.ToString(z.Wzrost);


        }
    }
}