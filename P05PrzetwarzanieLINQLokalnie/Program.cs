using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05PrzetwarzanieLINQLokalnie
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            //Zawodnik[] zawodnicy = db
            //    .Zawodnik
            //    .Where(x=>x.kraj.Contains("POL") || x.data_ur.Value.ToString("ddMMyyy").Contains("1"))
            //    .OrderBy(x=>x.wzrost)
            //    .ToArray();

            // ORM konowertuje LINQ na SQL


            var zawodnicy2 = db.Zawodnik.AsQueryable();
            zawodnicy2 = zawodnicy2.Where(x => x.kraj == "POL");

            Zawodnik[] zawodnicyWynik = zawodnicy2.ToArray();
            //teraz zawodnicyWynik dziala lokalnie
            zawodnicyWynik = zawodnicyWynik.Where(x => x.data_ur.Value.ToString("ddMMyyyy").Contains("1")).ToArray();
            zawodnicyWynik = zawodnicyWynik.OrderBy(x => x.wzrost).ToArray();




            Zawodnik[] wynik2= db
                .ExecuteQuery<Zawodnik>("select id_zawodnika, imie, nazwisko from zawodnicy where kraj = 'pol'").ToArray();

            // toArray to funkcja specjalna , która wysyła do bazy danych SQL, ine takie funkcje to:
            // ToList, First lub FirstOrdefault , Min, Max, Average.. itp 


        }
    }
}
