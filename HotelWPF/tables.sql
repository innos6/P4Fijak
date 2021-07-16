USE Hotel3
GO

CREATE TABLE [Guests]
(
 [GuestId] int NOT NULL ,
 [Name]    varchar(50) NOT NULL ,
 [Surname] varchar(50) NOT NULL ,


 CONSTRAINT [PK_guests] PRIMARY KEY CLUSTERED ([GuestId] ASC)
);
GO

CREATE TABLE [Rooms]
(
 [RoomNumber] int NOT NULL ,
 [Capacity]   int NOT NULL ,
 [Type]       varchar(50) NOT NULL ,
 [ForSmokers] bit NOT NULL ,
 [Available]  bit NOT NULL ,


 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED ([RoomNumber] ASC)
);
GO

CREATE TABLE [Reservations]
(
 [Id]         int NOT NULL ,
 [Begin]      date NOT NULL ,
 [End]        date NOT NULL ,
 [RoomNumber] int NOT NULL ,
 [GuestId]    int NOT NULL ,


 CONSTRAINT [PK_reservations] PRIMARY KEY CLUSTERED ([Id] ASC),
);
GO

