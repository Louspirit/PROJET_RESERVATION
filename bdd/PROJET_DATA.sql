USE [PROJET_DATA]
GO
/****** Object:  Table [dbo].[HOTELS]    Script Date: 07/02/2014 10:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOTELS](
	[VILLE] [varchar](50) NOT NULL,
	[NOM_HOTEL] [varchar](50) NOT NULL,
	[TARIF_NUIT] [numeric](19, 6) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VOLS]    Script Date: 07/02/2014 10:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VOLS](
	[VILLE_DEPART] [varchar](50) NOT NULL,
	[VILLE_ARRIVEE] [varchar](50) NOT NULL,
	[DATE_DEPART] [datetime] NOT NULL,
	[DATE_ARRIVEE] [datetime] NOT NULL,
	[TARIF] [numeric](19, 6) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HOTELS] ([VILLE], [NOM_HOTEL], [TARIF_NUIT]) VALUES (N'LONDRES', N'The London Bed', CAST(75.000000 AS Numeric(19, 6)))
INSERT [dbo].[HOTELS] ([VILLE], [NOM_HOTEL], [TARIF_NUIT]) VALUES (N'LONDRES', N'London Sleeper', CAST(90.000000 AS Numeric(19, 6)))
INSERT [dbo].[HOTELS] ([VILLE], [NOM_HOTEL], [TARIF_NUIT]) VALUES (N'MARRAKECH', N'La Babouche Paresseuse', CAST(50.000000 AS Numeric(19, 6)))
INSERT [dbo].[HOTELS] ([VILLE], [NOM_HOTEL], [TARIF_NUIT]) VALUES (N'MARRAKECH', N'Au Thé Dormant', CAST(60.000000 AS Numeric(19, 6)))
INSERT [dbo].[VOLS] ([VILLE_DEPART], [VILLE_ARRIVEE], [DATE_DEPART], [DATE_ARRIVEE], [TARIF]) VALUES (N'NANTES', N'LONDRES', CAST(0x0000A2CA00C5C100 AS DateTime), CAST(0x0000A2CA0107AC00 AS DateTime), CAST(150.000000 AS Numeric(19, 6)))
INSERT [dbo].[VOLS] ([VILLE_DEPART], [VILLE_ARRIVEE], [DATE_DEPART], [DATE_ARRIVEE], [TARIF]) VALUES (N'PARIS', N'MARRAKECH', CAST(0x0000A2CB00C5C100 AS DateTime), CAST(0x0000A2CB00E6B680 AS DateTime), CAST(200.000000 AS Numeric(19, 6)))
