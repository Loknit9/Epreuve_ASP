CREATE PROCEDURE [dbo].[Procedure1]
	@categorie NVARCHAR(64)
AS
	DELETE FROM [categorie]
		WHERE[Categorie] = @categorie
