CREATE PROCEDURE [dbo].[SP_Produit_GetByName]
	@nom VARCHAR(64)
AS
	SELECT [Id_Produit],
			[Nom],	
			[Description],
			[Prix],
			[Ecoscore],
			[Categorie]
	FROM [Produit] WHERE [Nom] LIKE LEFT(@nom, 3) + '%'
