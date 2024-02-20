CREATE PROCEDURE [dbo].[SP_MediaGetByProduit]
	@id_produit INT
AS
	SELECT [Id_Media],
			[ImageUrl],
			[Id_Produit]
	FROM [Media]
	WHERE [Id_Produit] = @id_produit
