using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyTPHContext();
            context.Database.EnsureCreated();
            context.Osoby.Add(new Klient { Imie = "Czarny", Nazwisko = "Smok", NumerRejestracyjny = "SB 2KS21", NumerTelefonu = "+48728495213" });
            context.Osoby.Add(new Pracownik { Imie = "Czarny", Nazwisko = "Smok", DataZatrudnienia = new DateTime(1999, 12, 25), DataZwolnienia = null });
            context.SaveChanges();

            var contextTPT = new MyTPTContext();
            contextTPT.Database.EnsureCreated();
            contextTPT.OsobyTPT.Add(new KlientTPT { Imie = "Smok", Nazwisko = "Czerwony", NumerRejestracyjny = "WE 98U7", NumerTelefonu = "+48512982102" });
            contextTPT.OsobyTPT.Add(new PracownikTPT { Imie = "Czarny", Nazwisko = "Smok", DataZatrudnienia = new DateTime(1999, 12, 25), DataZwolnienia = null });
            contextTPT.SaveChanges();
        }
    }
}
