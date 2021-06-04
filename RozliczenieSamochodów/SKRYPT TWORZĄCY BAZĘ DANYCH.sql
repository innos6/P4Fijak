USE [master]
GO
CREATE DATABASE [RozliczenieSamochodów]
CONTAINMENT = NONE
ON PRIMARY
( NAME = N'RozliczenieSamochodów', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ASUS\MSSQL\DATA\RozliczenieSamochodów.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
LOG ON
( NAME = N'RozliczenieSamochodów_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ASUS\MSSQL\DATA\RozliczenieSamochodów_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RozliczenieSamochodów].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RozliczenieSamochodów] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ANSI_NULLS OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ANSI_PADDING OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ARITHABORT OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [RozliczenieSamochodów] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET CURSOR_DEFAULT GLOBAL
GO
ALTER DATABASE [RozliczenieSamochodów] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ENABLE_BROKER
GO
ALTER DATABASE [RozliczenieSamochodów] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [RozliczenieSamochodów] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET RECOVERY FULL
GO
ALTER DATABASE [RozliczenieSamochodów] SET MULTI_USER
GO
ALTER DATABASE [RozliczenieSamochodów] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [RozliczenieSamochodów] SET DB_CHAINING OFF
GO
ALTER DATABASE [RozliczenieSamochodów] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [RozliczenieSamochodów] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [RozliczenieSamochodów] SET DELAYED_DURABILITY = DISABLED
GO

USE RozliczenieSamochodów
GO

CREATE TABLE [Samochody]
(
 [Nr rejestracyjny] varchar(8) NOT NULL ,
 [Typ]              varchar(50) NOT NULL ,
 [Marka]            varchar(50) NOT NULL ,
 [Model]            varchar(50) NOT NULL ,
 [W³asnoœæ]         varchar(50) NOT NULL ,
 [Paliwo]           varchar(50) NOT NULL ,
 [Pojemnoœæ]        money NOT NULL CONSTRAINT [CH_Samochody_Pojemnoœæ] CHECK ([Pojemnoœæ]>0),


 CONSTRAINT [PK_samochody] PRIMARY KEY CLUSTERED ([Nr rejestracyjny] ASC)
);
GO

CREATE TABLE [U¿ytkownicy]
(
 [Id pracownika]     int NOT NULL CONSTRAINT [CH_U¿ytkownicy_Id pracownika] CHECK ([Id pracownika]>0),
 [Imie]              varchar(50) NOT NULL ,
 [Nazwisko]          varchar(50) NOT NULL ,
 [Dzieñ urodzenia]   int NOT NULL CONSTRAINT [CH_U¿ytkownicy_Dzieñ urodzenia] CHECK ([Dzieñ urodzenia]>0), 
 [Miesiac urodzenia] int NOT NULL CONSTRAINT [CH_U¿ytkownicy_Miesiac urodzenia] CHECK([Miesiac urodzenia]>0 AND [Miesiac urodzenia]<13),
 [Rok urodzenia]     int NOT NULL CONSTRAINT [CH_U¿ytkownicy_Rok urodzenia] CHECK (YEAR(GETDATE())-[Rok urodzenia]>=18),
 [Stanowisko]        varchar(50) NULL ,
 [Rodzaj uprawnieñ]  varchar(50) NOT NULL ,


 CONSTRAINT [PK_u¿ytkownicy] PRIMARY KEY CLUSTERED ([Id pracownika] ASC)
);
GO

CREATE TABLE [Faktura]
(
 [Id faktury]          int NOT NULL CONSTRAINT [CH_Faktura_Id faktury] CHECK ([Id faktury]>0),
 [Sprzedawca]          varchar(50) NOT NULL ,
 [Nabywca]             varchar(50) NOT NULL ,
 [Suma]                money NOT NULL CONSTRAINT [CH_Faktura_Suma] CHECK ([Suma]>0),
 [Dzieñ wystawienia]   int NOT NULL CONSTRAINT [CH_Faktura_Dzieñ wystawienia] CHECK ([Dzieñ wystawienia]>0),
 [Miesi¹c wystawienia] int NOT NULL CONSTRAINT [CH_Faktura_Miesi¹c wystawienia] CHECK ([Miesi¹c wystawienia]>0),
 [Rok wystawienia]     int NOT NULL CONSTRAINT [CH_Faktura_Rok wystawienia] CHECK ([Rok wystawienia]>0),
 [Dzieñ Sprzeda¿y]     int NOT NULL CONSTRAINT [CH_Faktura_Dzieñ Sprzeda¿y] CHECK ([Dzieñ Sprzeda¿y]>0),
 [Miesi¹c Sprzeda¿y]   int NOT NULL CONSTRAINT [CH_Faktura_Miesi¹c Sprzeda¿y] CHECK ([Miesi¹c Sprzeda¿y]>0),
 [Rok Sprzeda¿y]       int NOT NULL CONSTRAINT [CH_Faktura_Rok Sprzeda¿y] CHECK ([Rok Sprzeda¿y]>0),


 CONSTRAINT [PK_faktura] PRIMARY KEY CLUSTERED ([Id faktury] ASC)
);
GO

CREATE TABLE [Pozycje faktury]
(
 [Id pozycji]              int NOT NULL CONSTRAINT [CH_Pozycje faktury_Id pozycji] CHECK ([Id pozycji]>0),
 [Id faktury]              int NOT NULL CONSTRAINT [CH_Pozycje faktury_Id faktury] CHECK ([Id faktury]>0),
 [Nazwa]                   varchar(50) NOT NULL ,
 [Iloœæ]                   int NOT NULL CONSTRAINT [CH_Pozycje faktury_Iloœæ] CHECK ([Iloœæ]>0),
 [Cena jednostkowa brutto] money NOT NULL CONSTRAINT [CH_Pozycje faktury_Cena jednostkowa brutto] CHECK ([Cena jednostkowa brutto]>0),
 [Wartoœæ netto]           money NOT NULL CONSTRAINT [CH_Pozycje faktury_Wartoœæ netto] CHECK ([Wartoœæ netto]>0),
 [Stawka]                  int NOT NULL CONSTRAINT [CH_Pozycje faktury_Stawka] CHECK ([Stawka]>0),
 [Podatek]                 money NOT NULL CONSTRAINT [CH_Pozycje faktury_Podatek]  CHECK ([Podatek] >0),
 [Wartoœæ brutto]          money NOT NULL CONSTRAINT [CH_Pozycje faktury_Wartoœæ brutto] CHECK ([Wartoœæ brutto]>0),
 [Suma]                    money NOT NULL CONSTRAINT [CH_Pozycje faktury_Suma] CHECK ([Suma]>0),


 CONSTRAINT [PK_pozycje faktury] PRIMARY KEY CLUSTERED ([Id pozycji] ASC),
 CONSTRAINT [FK_99] FOREIGN KEY ([Id faktury])  REFERENCES [Faktura]([Id faktury])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_100] ON [Pozycje faktury] 
 (
  [Id faktury] ASC
 )

GO

CREATE TABLE [Miesiêczna Karta Drogowa]
(
 [Miesi¹c]          int NOT NULL CONSTRAINT [CH_Miesiêczna Karta Drogowa_Miesi¹c] CHECK ([Miesi¹c]>0 AND [Miesi¹c]<13) ,
 [Rok]              int NOT NULL CONSTRAINT [CH_Miesiêczna Karta Drogowa_Rok] CHECK ([Rok]>1900),
 [Nr rejestracyjny] varchar(8) NOT NULL ,

 CONSTRAINT [PK_miesiêczna karta drogowa] PRIMARY KEY CLUSTERED ([Miesi¹c] ASC, [Rok] ASC, [Nr rejestracyjny] ASC),
 CONSTRAINT [FK_96] FOREIGN KEY ([Nr rejestracyjny])  REFERENCES [Samochody]([Nr rejestracyjny])
);
GO

CREATE NONCLUSTERED INDEX [fkIdx_97] ON [Miesiêczna Karta Drogowa] 
 (
  [Nr rejestracyjny] ASC
 )

GO


CREATE TABLE [Przejazd]
(
 [Id przejazdu]                 int NOT NULL CONSTRAINT [CH_Id przejazdu] CHECK ([Id przejazdu]>0),
 [Dzieñ Miesi¹ca]               int NOT NULL CONSTRAINT [CH_Dzieñ Miesi¹ca]  CHECK ([Dzieñ Miesi¹ca] >0),
 [Cel wyjazdu]                  varchar(50) NOT NULL CONSTRAINT [Cel wyjazdu] CHECK ([Cel wyjazdu] LIKE 'prywatny' OR [Cel wyjazdu] LIKE 's³u¿bowy'),
 [Trasa]                        varchar(50) NOT NULL ,
 [Stan licznika przy wyjeŸdzie] int NOT NULL CONSTRAINT [CH_Przejazd_Stan licznika przy wyjeŸdzie] CHECK ([Stan licznika przy wyjeŸdzie]>0),
 [Stan licznika po powrocie]    int NOT NULL CONSTRAINT [CH_Przejazd_Stan licznika po powrocie]  CHECK ([Stan licznika po powrocie] >0),
 [Iloœæ przejechanych km.]      int NOT NULL CONSTRAINT [CH_Przejazd_Iloœæ przejechanych km.] CHECK ([Iloœæ przejechanych km.]>0),
 [Id pracownika]                int NOT NULL CONSTRAINT [CH_Przejazd_Id pracownika] CHECK ([Id pracownika]>0),
 [Id faktury]                   int NULL CONSTRAINT [CH_Przejazd_Id faktury]  CHECK ([Id faktury] >0),
 [Miesi¹c]                      int NOT NULL CONSTRAINT [CH_Przejazd_Miesi¹c] CHECK ([Miesi¹c]>0),
 [Rok]                          int NOT NULL CONSTRAINT [CH_Przejazd_Rok] CHECK ([Rok]>0),
 [Nr rejestracyjny]             varchar(8) NOT NULL ,


 CONSTRAINT [PK_przejazd] PRIMARY KEY CLUSTERED ([Id przejazdu] ASC),
 CONSTRAINT [FK_115] FOREIGN KEY ([Id pracownika])  REFERENCES [U¿ytkownicy]([Id pracownika]),
 CONSTRAINT [FK_118] FOREIGN KEY ([Id faktury])  REFERENCES [Faktura]([Id faktury]),
 CONSTRAINT [FK_157] FOREIGN KEY ([Miesi¹c], [Rok], [Nr rejestracyjny])  REFERENCES [Miesiêczna Karta Drogowa]([Miesi¹c], [Rok], [Nr rejestracyjny])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_116] ON [Przejazd] 
 (
  [Id pracownika] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_119] ON [Przejazd] 
 (
  [Id faktury] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_158] ON [Przejazd] 
 (
  [Miesi¹c] ASC, 
  [Rok] ASC
 )

GO

