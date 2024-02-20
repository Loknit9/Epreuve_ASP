CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@categorie NVARCHAR(64)
AS
	INSERT INTO [Categorie] ([Categorie])
	VALUES (@categorie)

