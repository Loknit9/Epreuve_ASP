CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_produit INT,
	@nom NVARCHAR(64),
	@description NVARCHAR(MAX),
	@prix DECIMAL,
	@ecoscore NCHAR,
	@categorie NVARCHAR(64)
AS
	UPDATE [Produit]
			SET [Nom] = @nom,
				[Description] = @description,
				[Prix] = @prix,
				[Ecoscore] = @ecoscore,
				[Categorie] = @categorie
			WHERE [Id_Produit] = @id_produit
