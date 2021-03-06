USE [PROJET_DATA]
GO

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'KOUSKOUS', N'1 rue de la rue de sable rouge', N'ALG', CAST(6.500000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Thimotel Opera Madeleine', N'113, rue de st Lazare Monreal, Quebec', N'YQB', CAST(80.000000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Antin Trinité Hôtel', N'1bis, rue Victor Massé Sydney, Australie', N'SYD', CAST(320.000000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Hôtel de la charité', N'4, rue Eddy Malou Sydney, Australie', N'SXF', CAST(5.330000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Hôtel du grand clairon', N'6, avenue Edith Piaf Paris, France', N'SXF', CAST(320.000000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Hôtel familial', N'6, avenue du petit bonheur Paris, France', N'SXF', CAST(19.000000 AS Numeric(19, 6)))

INSERT [dbo].[HOTELS] ([NOM], [ADRESSE], [AEROPORT_PROCHE], [TARIF_NUIT]) VALUES (N'Grand Hôtel de Turin', N'3, rue de la rennete Rennes, France', N'RNS', CAST(6.500000 AS Numeric(19, 6)))

INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'AGA', N'ALG', CAST(0x0000A2D600C5C100 AS DateTime), CAST(22.000000 AS Numeric(19, 6)))

INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'IAH', N'YQB', CONVERT(datetime, '2014-02-21 08:14', 120), CAST(98.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'LYS', N'SYD', CONVERT(datetime, '2014-02-21 11:25', 120), CAST(650.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'GVA', N'MRS', CONVERT(datetime, '2014-02-17 11:00', 120), CAST(24.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'NCE', N'YYZ', CONVERT(datetime, '2014-02-18 15:00', 120), CAST(210.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'XPG', N'SXF', CONVERT(datetime, '2014-02-18 15:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'XPG', N'SXF', CONVERT(datetime, '2014-02-19 10:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'XPG', N'SXF', CONVERT(datetime, '2014-02-20 11:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'XPG', N'SXF', CONVERT(datetime, '2014-02-21 18:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'XPG', N'SYD', CONVERT(datetime, '2014-02-21 13:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'LAX', N'RNS', CONVERT(datetime, '2014-02-22 8:00', 120), CAST(75.000000 AS Numeric(19, 6)))


INSERT [dbo].[VOLS] ([AEROPORT_DEPART], [AEROPORT_ARRIVEE], [DATE_DEPART], [TARIF]) VALUES (N'MSP', N'RNS', CONVERT(datetime, '2014-02-22 9:00', 120), CAST(75.000000 AS Numeric(19, 6)))

