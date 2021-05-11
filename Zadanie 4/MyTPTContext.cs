using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_4
{
    class MyTPTContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ASUS\ASUS; Initial Catalog = OsobyTPT; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<OsobaTPT> OsobyTPT { get; set; }
        public DbSet<KlientTPT> KlienciTPT { get; set; }
        public DbSet<PracownikTPT> PracownicyTPT { get; set; }


    }
}
