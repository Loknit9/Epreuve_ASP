CREATE PROCEDURE [dbo].[SP_Produit_GetById]
	@id_produit INT
AS
	SELECT [Id_Produit],
			[Nom],	
			[Description],
			[Prix],
			[Ecoscore],
			[Categorie]
	FROM [Produit]
	WHERE [Id_Produit] = @id_produit

