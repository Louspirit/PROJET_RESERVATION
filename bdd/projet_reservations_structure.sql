USE [PROJET_RESERVATIONS]
GO
/****** Object:  StoredProcedure [dbo].[sp_addClient]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addClient]
@Nom varchar(50),
@Prenom varchar(50),
@Adresse varchar(200),
@Num_carte numeric(20,0)

AS
 INSERT INTO CLIENTS(NOM, PRENOM, ADRESSE, NUM_CARTE)
 VALUES (@Nom, @Prenom, @Adresse, @Num_carte)

GO
/****** Object:  StoredProcedure [dbo].[sp_addCmdHotel]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addCmdHotel]
@IdHotel int,
@IdClient int,
@DateArrivee datetime,
@Duree int,
@Montant numeric(19,6)

AS
 INSERT INTO CMD_HOTELS (ID_HOTEL, ID_CLIENT, DATE_ARRIVEE, DUREE, MONTANT)
 VALUES (@IdHotel, @IdClient, @DateArrivee, @Duree, @Montant) 

GO
/****** Object:  StoredProcedure [dbo].[sp_addCmdVol]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addCmdVol]
@IdVol int,
@IdClient int,
@Montant numeric(19,6)

AS
 INSERT INTO CMD_VOLS (ID_VOL, ID_CLIENT, MONTANT)
 VALUES (@IdVol,@IdClient,@Montant) 

GO
/****** Object:  StoredProcedure [dbo].[sp_getClient]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getClient]
@Nom varchar(50),
@Prenom varchar(50),
@Adresse varchar(200)

AS
 SELECT * FROM CLIENTS WHERE NOM = @Nom AND PRENOM = @Prenom AND ADRESSE = @Adresse

GO
/****** Object:  Table [dbo].[CLIENTS]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOM] [varchar](50) NOT NULL,
	[PRENOM] [varchar](50) NOT NULL,
	[ADRESSE] [varchar](200) NOT NULL,
	[NUM_CARTE] [numeric](20, 0) NOT NULL,
 CONSTRAINT [PK_CLIENTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CMD_HOTELS]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMD_HOTELS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_HOTEL] [int] NOT NULL,
	[ID_CLIENT] [int] NOT NULL,
	[DATE_ARRIVEE] datetime NOT NULL,
	[DUREE] [int] NOT NULL,
	[MONTANT] [numeric](19, 6) NOT NULL,
 CONSTRAINT [PK_CMD_HOTELS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CMD_VOLS]    Script Date: 11/02/2014 01:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMD_VOLS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_VOL] [int] NOT NULL,
	[ID_CLIENT] [int] NOT NULL,
	[MONTANT] [numeric](19, 6) NOT NULL,
 CONSTRAINT [PK_CMD_VOLS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CMD_HOTELS]  WITH CHECK ADD  CONSTRAINT [FK_CMD_HOTELS_CLIENTS1] FOREIGN KEY([ID_CLIENT])
REFERENCES [dbo].[CLIENTS] ([ID])
GO
ALTER TABLE [dbo].[CMD_HOTELS] CHECK CONSTRAINT [FK_CMD_HOTELS_CLIENTS1]
GO
ALTER TABLE [dbo].[CMD_VOLS]  WITH CHECK ADD  CONSTRAINT [FK_CMD_VOLS_CLIENTS] FOREIGN KEY([ID_CLIENT])
REFERENCES [dbo].[CLIENTS] ([ID])
GO
ALTER TABLE [dbo].[CMD_VOLS] CHECK CONSTRAINT [FK_CMD_VOLS_CLIENTS]
GO
