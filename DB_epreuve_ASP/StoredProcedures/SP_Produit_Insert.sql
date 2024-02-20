CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nom NVARCHAR(64),
	@description NVARCHAR(MAX),
	@prix DECIMAL,
	@ecoscore NVARCHAR(2),
	@categorie NVARCHAR(64)
	AS
	INSERT	INTO [Produit] ([Nom], [Description], [Prix], [Ecoscore], [Categorie])
			OUTPUT [inserted].[Id_Produit]
			VALUES (@nom, @description, @prix, @ecoscore, @categorie)
