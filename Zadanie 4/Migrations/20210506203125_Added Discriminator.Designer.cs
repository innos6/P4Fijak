﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zadanie_4;

namespace Zadanie_4.Migrations
{
    [DbContext(typeof(MyTPHContext))]
    [Migration("20210506203125_Added Discriminator")]
    partial class AddedDiscriminator
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Zadanie_4.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typ_osoby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Osoby");

                    b.HasDiscriminator<string>("Typ_osoby").HasValue("Osoba");
                });

            modelBuilder.Entity("Zadanie_4.Klient", b =>
                {
                    b.HasBaseType("Zadanie_4.Osoba");

                    b.Property<string>("NumerRejestracyjny")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumerTelefonu")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Klient");
                });

            modelBuilder.Entity("Zadanie_4.Pracownik", b =>
                {
                    b.HasBaseType("Zadanie_4.Osoba");

                    b.Property<DateTime>("DataZatrudnienia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataZwolnienia")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Pracownik");
                });
#pragma warning restore 612, 618
        }
    }
}
