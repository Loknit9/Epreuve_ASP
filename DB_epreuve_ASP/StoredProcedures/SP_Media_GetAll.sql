CREATE PROCEDURE [dbo].[SP_Media_GetAll]
	AS
	SELECT [Id_Media],	
			[ImageUrl],
			[Id_Produit]
		
	FROM [Media]   
