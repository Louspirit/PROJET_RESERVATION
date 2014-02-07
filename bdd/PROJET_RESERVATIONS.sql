USE [PROJET_RESERVATION]
GO
/****** Object:  Table [dbo].[CMDHOTELS]    Script Date: 07/02/2014 10:40:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CMDHOTELS](
	[VILLE] [varchar](50) NOT NULL,
	[NOM_HOTEL] [varchar](50) NOT NULL,
	[TARIF_NUIT] [numeric](19, 6) NOT NULL,
	[DUREE] [numeric](3, 0) NOT NULL,
	[NOM] [varchar](50) NOT NULL,
	[PRENOM] [varchar](50) NOT NULL,
	[ADRESSE] [varchar](50) NULL,
	[NUMERO_CARTE] [varchar](50) NOT NULL,
	[PRIX_TRANSACTION] [numeric](19, 6) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CMDVOLS]    Script Date: 07/02/2014 10:40:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CMDVOLS](
	[VILLE_DEPART] [varchar](50) NULL,
	[VILLE_ARRIVEE] [varchar](50) NOT NULL,
	[DATE_DEPART] [datetime] NOT NULL,
	[DATE_ARRIVEE] [datetime] NOT NULL,
	[NOM] [varchar](50) NOT NULL,
	[PRENOM] [varchar](50) NOT NULL,
	[ADRESSE] [varchar](50) NULL,
	[NUMERO_CARTE] [numeric](16, 0) NOT NULL,
	[PRIX_TRANSACTION] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
