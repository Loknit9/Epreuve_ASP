CREATE PROCEDURE [dbo].[SP_Produit_GetByCategorie]
	@categorie NVARCHAR(64)
AS
	SELECT [Id_Produit],
			[Nom],	
			[Description],
			[Prix],
			[Ecoscore],
			[Categorie]
	FROM [Produit] WHERE [Categorie] = @categorie
