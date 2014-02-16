USE [PROJET_DATA]
GO
/****** Object:  StoredProcedure [dbo].[sp_getAeroportsArrivee]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getAeroportsArrivee]
AS
 SELECT DISTINCT A.ID,A.NOM FROM AEROPORTS A, VOLS V WHERE A.ID = V.AEROPORT_ARRIVEE

GO
/****** Object:  StoredProcedure [dbo].[sp_getAeroportsDepart]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getAeroportsDepart]
AS
 SELECT DISTINCT A.ID,A.NOM FROM AEROPORTS A, VOLS V WHERE A.ID = V.AEROPORT_DEPART

GO
/****** Object:  StoredProcedure [dbo].[sp_getHotels]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getHotels]
@AEROPORT_PROCHE varchar(3)
AS
 SELECT DISTINCT * FROM HOTELS WHERE AEROPORT_PROCHE = @AEROPORT_PROCHE

GO
/****** Object:  StoredProcedure [dbo].[sp_getVols]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getVols]
@AEROPORT_DEPART varchar(3),
@AEROPORT_ARRIVEE varchar(3),
@DATE_DEPART_MIN datetime,
@DATE_DEPART_MAX datetime
AS
 SELECT DISTINCT V.ID as numeroVol, A1.NOM as aeroportDepart, A2.NOM as aeroportArrivee, V.DATE_DEPART as dateDepart, V.TARIF as tarif FROM VOLS V, AEROPORTS A1, AEROPORTS A2 WHERE AEROPORT_DEPART=@AEROPORT_DEPART AND AEROPORT_ARRIVEE = @AEROPORT_ARRIVEE AND DATE_DEPART >= @DATE_DEPART_MIN AND DATE_DEPART <= @DATE_DEPART_MAX AND V.AEROPORT_DEPART = A1.ID
  AND V.AEROPORT_ARRIVEE = A2.ID

GO
/****** Object:  Table [dbo].[AEROPORTS]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AEROPORTS](
	[ID] [varchar](3) NOT NULL,
	[NOM] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AEROPORTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOTELS]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOTELS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOM] [varchar](100) NULL,
	[ADRESSE] [varchar](200) NOT NULL,
	[AEROPORT_PROCHE] [varchar](3) NOT NULL,
	[TARIF_NUIT] [numeric](19, 6) NOT NULL,
 CONSTRAINT [PK_HOTELS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VOLS]    Script Date: 11/02/2014 11:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VOLS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AEROPORT_DEPART] [varchar](3) NOT NULL,
	[AEROPORT_ARRIVEE] [varchar](3) NOT NULL,
	[DATE_DEPART] [datetime] NOT NULL,
	[TARIF] [numeric](19, 6) NOT NULL,
 CONSTRAINT [PK_VOLS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[HOTELS]  WITH CHECK ADD  CONSTRAINT [FK_HOTELS_AEROPORTS1] FOREIGN KEY([AEROPORT_PROCHE])
REFERENCES [dbo].[AEROPORTS] ([ID])
GO
ALTER TABLE [dbo].[HOTELS] CHECK CONSTRAINT [FK_HOTELS_AEROPORTS1]
GO
ALTER TABLE [dbo].[VOLS]  WITH CHECK ADD  CONSTRAINT [FK_VOLS_AEROPORTS2] FOREIGN KEY([AEROPORT_ARRIVEE])
REFERENCES [dbo].[AEROPORTS] ([ID])
GO
ALTER TABLE [dbo].[VOLS] CHECK CONSTRAINT [FK_VOLS_AEROPORTS2]
GO
ALTER TABLE [dbo].[VOLS]  WITH CHECK ADD  CONSTRAINT [FK_VOLS_AEROPORTS3] FOREIGN KEY([AEROPORT_DEPART])
REFERENCES [dbo].[AEROPORTS] ([ID])
GO
ALTER TABLE [dbo].[VOLS] CHECK CONSTRAINT [FK_VOLS_AEROPORTS3]
GO
