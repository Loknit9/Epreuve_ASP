CREATE PROCEDURE [dbo].[SP_DetailCommande_GetById]
	@id_detailcommande INT
AS
	SELECT [Id_DetailCommande],
			[Id_Commande],
			[Id_Produit],
			[Quantite]
	FROM [DetailCommande]
	WHERE [Id_DetailCommande] = @id_detailcommande
