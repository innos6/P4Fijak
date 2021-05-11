using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_4
{
    class MyTPHContext : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ASUS\ASUS; Initial Catalog = OsobyTPH; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>()
                .HasDiscriminator<string>("Typ_osoby")
                .HasValue<Klient>("Klient")
                .HasValue<Pracownik>("Pracownik");
            base.OnModelCreating(modelBuilder);
        }
    }
}
