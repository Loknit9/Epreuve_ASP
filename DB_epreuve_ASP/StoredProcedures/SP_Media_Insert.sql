CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@imageurl NVARCHAR(128),
	@id_produit INT
AS
	INSERT INTO [Media] ([ImageUrl], [Id_Produit])
			OUTPUT [inserted].[Id_Media]
			VALUES (@imageurl, @id_produit)
