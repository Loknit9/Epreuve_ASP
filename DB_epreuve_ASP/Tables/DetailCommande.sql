CREATE TABLE [dbo].[DetailCommande]
(
	[Id_DetailCommande] INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_Produit] INT NOT NULL,
	[Id_Commande] Int NOT NULL,
	[Quantite] INT NOT NULL,
	CONSTRAINT [FK_DetailCommande_Commande] FOREIGN KEY ([Id_Commande]) REFERENCES [Commande] ([Id_Commande]),
	CONSTRAINT [FK_DetailCommande_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit] ([Id_Produit]),

)
