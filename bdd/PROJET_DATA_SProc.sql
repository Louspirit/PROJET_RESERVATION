USE [PROJET_DATA]
GO
/****** Object:  StoredProcedure [dbo].[sp_getHotels]    Script Date: 07/02/2014 13:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getHotels]
@Ville nvarchar(50)
AS
 SELECT * FROM HOTELS WHERE VILLE = @Ville

GO
/****** Object:  StoredProcedure [dbo].[sp_getVillesArrivee]    Script Date: 07/02/2014 13:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getVillesArrivee]	

AS
 SELECT VILLE_ARRIVEE FROM VOLS

GO
/****** Object:  StoredProcedure [dbo].[sp_getVillesDepart]    Script Date: 07/02/2014 13:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getVillesDepart]	

AS
 SELECT VILLE_DEPART FROM VOLS

GO
/****** Object:  StoredProcedure [dbo].[sp_getVols]    Script Date: 07/02/2014 13:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getVols]
@VilleDepart nvarchar(50),
@VilleArrivee nvarchar(50)

AS
 SELECT * FROM VOLS WHERE VILLE_DEPART = @VilleDepart AND VILLE_ARRIVEE = @VilleArrivee

GO
