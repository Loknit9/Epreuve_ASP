﻿CREATE TABLE [dbo].[Categorie]
(
	[Id_Categorie] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom] VARCHAR(64) NOT NULL,
	CONSTRAINT [UK_Nom] UNIQUE ([Nom]),
)
