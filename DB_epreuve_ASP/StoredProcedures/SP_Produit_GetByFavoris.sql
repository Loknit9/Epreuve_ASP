CREATE PROCEDURE [dbo].[SP_Produit_GetByFavoris]
AS
	SELECT TOP 10 Produit.Id_Produit, Produit.Nom, sum(DetailCommande.Quantite) as TotalQuantiteProduit
	FROM Produit INNER JOIN DetailCommande
	ON Produit.Id_Produit = DetailCommande.Id_Produit
	GROUP BY Produit.Id_Produit, Produit.Nom
	ORDER BY sum(DetailCommande.Quantite) DESC
