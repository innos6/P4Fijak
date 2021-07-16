using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozliczenieSamochodów
{
    public static class getData
    {
        public static BindingList<DataModel.Samochody> getFlotaItems()
        {
            var context = new DataModel.DataContext();
            context.Samochodies.Load();
            var res = context.Samochodies.Local.ToBindingList();
            return res;
        }
        public static BindingList<DataModel.Użytkownicy> getUsersItem()
        {
            var context = new DataModel.DataContext();
            context.Użytkownicy.Load();
            return context.Użytkownicy.Local.ToBindingList();
        }
        public static BindingList<DataModel.Miesięczna_Karta_Drogowa> getMonthCard()
        {
            var context = new DataModel.DataContext();
            context.Miesięczna_Karta_Drogowa.Load();
            return context.Miesięczna_Karta_Drogowa.Local.ToBindingList();
        }
        public static BindingList<DataModel.Przejazd> getPrzejazdy(int month, int year, string reg)
        {
            var context = new DataModel.DataContext();
            context.Przejazds.Where(x=>x.Miesiąc==month && x.Rok == year && x.Nr_rejestracyjny.Equals(reg)).Load();
            return context.Przejazds.Local.ToBindingList();
        }
    }

    public static class addData
    {
        public static void addCar(string nr, string typ, string marka, string model, string wlasnosc, string paliwo, decimal pojemnosc)
        {
            var context = new DataModel.DataContext();
            context.Samochodies.Add(new DataModel.Samochody
            {
                Nr_rejestracyjny = nr,
                Typ = typ,
                Marka = marka,
                Model = model,
                Paliwo = paliwo,
                Własność = wlasnosc,
                Pojemność = pojemnosc
            });
            context.SaveChanges();
            context.Samochodies.Load(); 
        }

        public static void addUser(string imie, string nazwisko, int day, int month, int year, string stanowisko, string kat)
        {
            var context = new DataModel.DataContext();
            context.Użytkownicy.Add(new DataModel.Użytkownicy
            {
                Id_pracownika = context.Użytkownicy.Max(x=>x.Id_pracownika) + 1,
                Imie = imie,
                Nazwisko = nazwisko,
                Dzień_urodzenia = day,
                Miesiac_urodzenia = month,
                Rok_urodzenia = year,
                Stanowisko = stanowisko,
                Rodzaj_uprawnień = kat
            });
            context.SaveChanges();
            context.Użytkownicy.Load();
        }

        public static void addCard(int month, int year, string reg)
        {
            var context = new DataModel.DataContext();
            context.Miesięczna_Karta_Drogowa.Add(new DataModel.Miesięczna_Karta_Drogowa
            {
                Miesiąc = month,
                Rok = year,
                Nr_rejestracyjny = reg
            });
            context.SaveChanges();
            context.Miesięczna_Karta_Drogowa.Load();
        }
        public static void addPrzejazd(int day, string cel, string trasa, int licznikPrzed, int licznikPo, int id_pracownika, int month, int year, string reg)
        {
            var context = new DataModel.DataContext();
            context.Przejazds.Add(new DataModel.Przejazd
            {
                Id_przejazdu = context.Przejazds.Count() + 1,
                Dzień_Miesiąca = day,
                Cel_wyjazdu = cel,
                Trasa = trasa,
                Stan_licznika_przy_wyjeździe = licznikPrzed,
                Stan_licznika_po_powrocie = licznikPo,
                Ilość_przejechanych_km_ = licznikPo-licznikPrzed,
                Id_pracownika = id_pracownika,
                Miesiąc = month,
                Rok = year,
                Nr_rejestracyjny = reg
            });
            context.SaveChanges();
            context.Przejazds.Load();
        }
    }

    public static class removeData
    {
        public static void removeCar(string reg)
        {
            var context = new DataModel.DataContext();
            context.Samochodies.Remove(context.Samochodies.Single(x => x.Nr_rejestracyjny.Equals(reg)));
            context.SaveChanges();
            context.Samochodies.Load();
        }

        public static void removeUser(int id)
        {
            var context = new DataModel.DataContext();
            context.Użytkownicy.Remove(context.Użytkownicy.Single(x => x.Id_pracownika == id));
            context.SaveChanges();
            context.Użytkownicy.Load();
        }

        public static void removeCard(int month, int year, string reg)
        {
            var context = new DataModel.DataContext();
            context.Miesięczna_Karta_Drogowa.Remove(context.Miesięczna_Karta_Drogowa.Single(x => x.Nr_rejestracyjny.Equals(reg) && x.Miesiąc==month &&x.Rok==year));
            context.SaveChanges();
            context.Miesięczna_Karta_Drogowa.Load();
        }
        public static void removePrzejazd(int id)
        {
            var context = new DataModel.DataContext();
            context.Przejazds.Remove(context.Przejazds.Single(x => x.Id_przejazdu == id));
            context.SaveChanges();
            context.Przejazds.Load();
        }
    }


    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
