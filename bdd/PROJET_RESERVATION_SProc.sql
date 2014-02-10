USE [PROJET_RESERVATION]
GO
/****** Object:  StoredProcedure [dbo].[sp_addTransactionHotels]    Script Date: 10/02/2014 10:17:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addTransactionHotels]
@Ville nvarchar(50),
@NomHotel nvarchar(50),
@TarifNuit numeric(5,0),
@Duree numeric(2,0),
@Nom nvarchar(50),
@Prenom nvarchar(50),
@Adresse nvarchar(50),
@NumeroCarte numeric(16,0),
@PrixTrans numeric(19,6)

AS
 INSERT INTO CMDHOTELS (VILLE
      ,NOM_HOTEL
      ,TARIF_NUIT
      ,DUREE
      ,NOM
      ,PRENOM
      ,ADRESSE
      ,NUMERO_CARTE
      ,PRIX_TRANSACTION) 
 VALUES (@Ville,@NomHotel,@TarifNuit,@Duree,@Nom,@Prenom,@Adresse,@NumeroCarte,@PrixTrans) 

GO
/****** Object:  StoredProcedure [dbo].[sp_addTransactionVols]    Script Date: 10/02/2014 10:17:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addTransactionVols]
@VilleDepart nvarchar(50),
@VilleArrivee nvarchar(50),
@DateDepart datetime,
@DateArrivee datetime,
@Nom nvarchar(50),
@Prenom nvarchar(50),
@Adresse nvarchar(50),
@NumeroCarte numeric(16,0),
@PrixTrans numeric(5,0)

AS
 INSERT INTO CMDVOLS (VILLE_DEPART,VILLE_ARRIVEE,DATE_DEPART,DATE_ARRIVEE,NOM,PRENOM,ADRESSE,NUMERO_CARTE,PRIX_TRANSACTION) 
 VALUES (@VilleDepart,@VilleArrivee,@DateDepart,@DateArrivee,@Nom,@Prenom,@Adresse,@NumeroCarte,@PrixTrans) 

GO
