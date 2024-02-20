CREATE PROCEDURE [dbo].[SP_Produit_GetAll]
	
AS
	SELECT [Id_Produit],
			[Nom],	
			[Description],
			[Prix],
			[Ecoscore],
			[Categorie]
	FROM [Produit]       
