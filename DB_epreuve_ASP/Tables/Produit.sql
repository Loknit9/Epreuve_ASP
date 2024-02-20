CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom] NVARCHAR(64) NOT NULL,
	[Description] VARCHAR(MAX) NOT NULL,
	[Prix] DECIMAL NOT NULL,
	[Ecoscore] NCHAR NOT NULL,
	[Categorie] NVARCHAR(64)NOT NULL,
	CONSTRAINT [FK_Produit_Ecoscore] FOREIGN KEY ([Ecoscore]) REFERENCES [Ecoscore] ([Ecoscore]),
	CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Categorie]) REFERENCES [Categorie] ([Categorie]),

)
