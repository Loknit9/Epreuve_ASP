CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom] VARCHAR(64) NOT NULL,
	[Description] VARCHAR(MAX) NOT NULL,
	[Prix] DECIMAL NOT NULL,
	[Ecoscore] VARCHAR(2) NOT NULL,
	[Id_Categorie] INT NOT NULL,
	CONSTRAINT [FK_Produit_Ecoscore] FOREIGN KEY ([Ecoscore]) REFERENCES [Ecoscore] ([Ecoscore]),
	CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Id_Categorie]) REFERENCES [Categorie] ([Id_categorie]),

)
