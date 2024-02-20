CREATE PROCEDURE [dbo].[SP_Produit_GetByEcoscore]
	@ecoscore NCHAR
AS
	SELECT [Id_Produit],
			[Nom],	
			[Description],
			[Prix],
			[Ecoscore],
			[Categorie]
	FROM [Produit] WHERE [Ecoscore] = @ecoscore
