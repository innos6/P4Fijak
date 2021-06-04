using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Projekt1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Faktura> Faktura { get; set; }
        public virtual DbSet<Miesięczna_Karta_Drogowa> Miesięczna_Karta_Drogowa { get; set; }
        public virtual DbSet<Pozycje_faktury> Pozycje_faktury { get; set; }
        public virtual DbSet<Przejazd> Przejazd { get; set; }
        public virtual DbSet<Samochody> Samochody { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Użytkownicy> Użytkownicy { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faktura>()
                .Property(e => e.Sprzedawca)
                .IsUnicode(false);

            modelBuilder.Entity<Faktura>()
                .Property(e => e.Nabywca)
                .IsUnicode(false);

            modelBuilder.Entity<Faktura>()
                .Property(e => e.Suma)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Faktura>()
                .HasMany(e => e.Pozycje_faktury)
                .WithRequired(e => e.Faktura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Miesięczna_Karta_Drogowa>()
                .Property(e => e.Nr_rejestracyjny)
                .IsUnicode(false);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Cena_jednostkowa_brutto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Wartość_netto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Podatek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Wartość_brutto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pozycje_faktury>()
                .Property(e => e.Suma)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Przejazd>()
                .Property(e => e.Cel_wyjazdu)
                .IsUnicode(false);

            modelBuilder.Entity<Przejazd>()
                .Property(e => e.Trasa)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Nr_rejestracyjny)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Typ)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Własność)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Paliwo)
                .IsUnicode(false);

            modelBuilder.Entity<Samochody>()
                .Property(e => e.Pojemność)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Samochody>()
                .HasMany(e => e.Miesięczna_Karta_Drogowa)
                .WithRequired(e => e.Samochody)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Użytkownicy>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Użytkownicy>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Użytkownicy>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Użytkownicy>()
                .Property(e => e.Stanowisko)
                .IsUnicode(false);

            modelBuilder.Entity<Użytkownicy>()
                .Property(e => e.Rodzaj_uprawnień)
                .IsUnicode(false);

            modelBuilder.Entity<Użytkownicy>()
                .HasMany(e => e.Przejazd)
                .WithRequired(e => e.Użytkownicy)
                .WillCascadeOnDelete(false);
        }
    }
}
