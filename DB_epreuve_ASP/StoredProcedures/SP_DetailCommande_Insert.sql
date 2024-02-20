CREATE PROCEDURE [dbo].[SP_DetailCommande_Insert]
	@id_produit INT,
	@id_commande INT,
	@quantite INT

AS
	INSERT INTO [DetailCommande] ([Id_Produit], [Id_Commande], [Quantite])
		OUTPUT [inserted].[Id_DetailCommande]
		VALUES (@id_produit, @id_commande, @quantite)
