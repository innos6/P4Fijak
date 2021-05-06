﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zadanie3;

namespace Zadanie3.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Polish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Zadanie3.Model.Dostawcy", b =>
                {
                    b.Property<int>("Iddostawcy")
                        .HasColumnType("int")
                        .HasColumnName("IDdostawcy");

                    b.Property<string>("Adres")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Faks")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<string>("Kraj")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Miasto")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("NazwaFirmy")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Przedstawiciel")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("StanowiskoPrzedstawiciela")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StronaMacierzysta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Iddostawcy");

                    b.ToTable("Dostawcy", "mg");
                });

            modelBuilder.Entity("Zadanie3.Model.Kategorie", b =>
                {
                    b.Property<int>("Idkategorii")
                        .HasColumnType("int")
                        .HasColumnName("IDkategorii");

                    b.Property<string>("NazwaKategorii")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Rysunek")
                        .HasColumnType("image");

                    b.HasKey("Idkategorii");

                    b.ToTable("Kategorie", "mg");
                });

            modelBuilder.Entity("Zadanie3.Model.Klienci", b =>
                {
                    b.Property<string>("Idklienta")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("IDklienta")
                        .IsFixedLength(true);

                    b.Property<string>("Adres")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Faks")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<string>("Kraj")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Miasto")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("NazwaFirmy")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Przedstawiciel")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("StanowiskoPrzedstawiciela")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Idklienta")
                        .HasName("PK_IDKlienta");

                    b.ToTable("Klienci");
                });

            modelBuilder.Entity("Zadanie3.Model.PozycjeZamówienium", b =>
                {
                    b.Property<int>("Idzamówienia")
                        .HasColumnType("int")
                        .HasColumnName("IDzamówienia");

                    b.Property<int>("Idproduktu")
                        .HasColumnType("int")
                        .HasColumnName("IDproduktu");

                    b.Property<decimal>("CenaJednostkowa")
                        .HasColumnType("money");

                    b.Property<short>("Ilość")
                        .HasColumnType("smallint");

                    b.Property<float>("Rabat")
                        .HasColumnType("real");

                    b.HasKey("Idzamówienia", "Idproduktu")
                        .HasName("PK_PozycjeZamowien");

                    b.HasIndex("Idproduktu");

                    b.ToTable("PozycjeZamówienia");
                });

            modelBuilder.Entity("Zadanie3.Model.Pracownicy", b =>
                {
                    b.Property<int>("Idpracownika")
                        .HasColumnType("int")
                        .HasColumnName("IDpracownika");

                    b.Property<string>("Adres")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("DataUrodzenia")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataZatrudnienia")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("Fotografia")
                        .HasColumnType("image");

                    b.Property<string>("Imię")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<string>("Kraj")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Miasto")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Stanowisko")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("Szef")
                        .HasColumnType("int");

                    b.Property<string>("TelefonDomowy")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("TelefonWewnętrzny")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZwrotGrzecznościowy")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Idpracownika");

                    b.ToTable("Pracownicy");
                });

            modelBuilder.Entity("Zadanie3.Model.Produkty", b =>
                {
                    b.Property<int>("Idproduktu")
                        .HasColumnType("int")
                        .HasColumnName("IDproduktu");

                    b.Property<decimal?>("CenaJednostkowa")
                        .HasColumnType("money");

                    b.Property<int?>("Iddostawcy")
                        .HasColumnType("int")
                        .HasColumnName("IDdostawcy");

                    b.Property<int?>("Idkategorii")
                        .HasColumnType("int")
                        .HasColumnName("IDkategorii");

                    b.Property<string>("IlośćJednostkowa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<short?>("IlośćZamówiona")
                        .HasColumnType("smallint");

                    b.Property<string>("NazwaProduktu")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<short?>("StanMagazynu")
                        .HasColumnType("smallint");

                    b.Property<short?>("StanMinimum")
                        .HasColumnType("smallint");

                    b.Property<bool>("Wycofany")
                        .HasColumnType("bit");

                    b.HasKey("Idproduktu");

                    b.HasIndex("Iddostawcy");

                    b.HasIndex("Idkategorii");

                    b.ToTable("Produkty", "mg");
                });

            modelBuilder.Entity("Zadanie3.Model.Spedytorzy", b =>
                {
                    b.Property<int>("Idspedytora")
                        .HasColumnType("int")
                        .HasColumnName("IDspedytora");

                    b.Property<string>("NazwaFirmy")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Idspedytora");

                    b.ToTable("Spedytorzy");
                });

            modelBuilder.Entity("Zadanie3.Model.Zamówienium", b =>
                {
                    b.Property<int>("Idzamówienia")
                        .HasColumnType("int")
                        .HasColumnName("IDzamówienia");

                    b.Property<string>("AdresOdbiorcy")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("DataWymagana")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataWysyłki")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataZamówienia")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Fracht")
                        .HasColumnType("money");

                    b.Property<string>("Idklienta")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("IDklienta")
                        .IsFixedLength(true);

                    b.Property<int?>("Idpracownika")
                        .HasColumnType("int")
                        .HasColumnName("IDpracownika");

                    b.Property<int?>("Idspedytora")
                        .HasColumnType("int")
                        .HasColumnName("IDspedytora");

                    b.Property<string>("KodPocztowyOdbiorcy")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("KrajOdbiorcy")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("MiastoOdbiorcy")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("NazwaOdbiorcy")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RegionOdbiorcy")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Idzamówienia");

                    b.HasIndex("Idklienta");

                    b.HasIndex("Idpracownika");

                    b.HasIndex("Idspedytora");

                    b.ToTable("Zamówienia");
                });

            modelBuilder.Entity("Zadanie3.MyUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MyUsers");
                });

            modelBuilder.Entity("Zadanie3.Model.PozycjeZamówienium", b =>
                {
                    b.HasOne("Zadanie3.Model.Produkty", "IdproduktuNavigation")
                        .WithMany("PozycjeZamówienia")
                        .HasForeignKey("Idproduktu")
                        .HasConstraintName("FK_PozycjeZamówienia_Produkty")
                        .IsRequired();

                    b.HasOne("Zadanie3.Model.Zamówienium", "IdzamówieniaNavigation")
                        .WithMany("PozycjeZamówienia")
                        .HasForeignKey("Idzamówienia")
                        .HasConstraintName("FK_PozycjeZamówienia_Zamówienia")
                        .IsRequired();

                    b.Navigation("IdproduktuNavigation");

                    b.Navigation("IdzamówieniaNavigation");
                });

            modelBuilder.Entity("Zadanie3.Model.Produkty", b =>
                {
                    b.HasOne("Zadanie3.Model.Dostawcy", "IddostawcyNavigation")
                        .WithMany("Produkties")
                        .HasForeignKey("Iddostawcy")
                        .HasConstraintName("FK_Produkty_Dostawcy");

                    b.HasOne("Zadanie3.Model.Kategorie", "IdkategoriiNavigation")
                        .WithMany("Produkties")
                        .HasForeignKey("Idkategorii")
                        .HasConstraintName("FK_Produkty_Kategorie");

                    b.Navigation("IddostawcyNavigation");

                    b.Navigation("IdkategoriiNavigation");
                });

            modelBuilder.Entity("Zadanie3.Model.Zamówienium", b =>
                {
                    b.HasOne("Zadanie3.Model.Klienci", "IdklientaNavigation")
                        .WithMany("Zamówienia")
                        .HasForeignKey("Idklienta")
                        .HasConstraintName("FK_Zamówienia_Klienci")
                        .IsRequired();

                    b.HasOne("Zadanie3.Model.Pracownicy", "IdpracownikaNavigation")
                        .WithMany("Zamówienia")
                        .HasForeignKey("Idpracownika")
                        .HasConstraintName("FK_Zamówienia_Pracownicy");

                    b.HasOne("Zadanie3.Model.Spedytorzy", "IdspedytoraNavigation")
                        .WithMany("Zamówienia")
                        .HasForeignKey("Idspedytora")
                        .HasConstraintName("FK_Zamówienia_Spedytorzy");

                    b.Navigation("IdklientaNavigation");

                    b.Navigation("IdpracownikaNavigation");

                    b.Navigation("IdspedytoraNavigation");
                });

            modelBuilder.Entity("Zadanie3.Model.Dostawcy", b =>
                {
                    b.Navigation("Produkties");
                });

            modelBuilder.Entity("Zadanie3.Model.Kategorie", b =>
                {
                    b.Navigation("Produkties");
                });

            modelBuilder.Entity("Zadanie3.Model.Klienci", b =>
                {
                    b.Navigation("Zamówienia");
                });

            modelBuilder.Entity("Zadanie3.Model.Pracownicy", b =>
                {
                    b.Navigation("Zamówienia");
                });

            modelBuilder.Entity("Zadanie3.Model.Produkty", b =>
                {
                    b.Navigation("PozycjeZamówienia");
                });

            modelBuilder.Entity("Zadanie3.Model.Spedytorzy", b =>
                {
                    b.Navigation("Zamówienia");
                });

            modelBuilder.Entity("Zadanie3.Model.Zamówienium", b =>
                {
                    b.Navigation("PozycjeZamówienia");
                });
#pragma warning restore 612, 618
        }
    }
}
