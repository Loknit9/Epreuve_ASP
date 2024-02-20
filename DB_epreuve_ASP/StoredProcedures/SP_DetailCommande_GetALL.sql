CREATE PROCEDURE [dbo].[SP_DetailCommande_GetALL]
	
AS
	SELECT [Id_DetailCommande],
			[Id_Produit],
			[Id_Commande],
			[Quantite]
	FROM [DetailCommande]
