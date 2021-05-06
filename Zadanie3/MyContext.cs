using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie3
{
    public class MyContext : Model.ZNorthwindContext
    {
        public DbSet<MyUser> MyUsers { get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ASUS\ASUS; Initial Catalog = ZNorthwind; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
