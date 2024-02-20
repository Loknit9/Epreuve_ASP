CREATE PROCEDURE [dbo].[SP_Produit_GetByCategorie]
	@categorie NVARCHAR(64)
AS
	SELECT *
	FROM [Produit] WHERE [Categorie] = @categorie
