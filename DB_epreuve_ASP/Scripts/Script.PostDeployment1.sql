/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [Ecoscore]
    VALUES  ('A'),
            ('B'),
            ('C'),
            ('D'),
            ('E');
GO

EXEC SP_Categorie_Insert 'Alimentation';
EXEC SP_Categorie_Insert 'Entretien';
EXEC SP_Categorie_Insert 'Hygiène';
GO

EXEC SP_Produit_Insert 'Boite repas bio', 'Description de la boite repas bio', 15.50, 'A', 'Alimentation';
EXEC SP_Produit_Insert 'Lessive bio', 'Description de la lessive bio', 9, 'B', 'Entretien';
EXEC SP_Produit_Insert 'Crème hydratante bio', 'Description de la crème hydratante bio', 12.25, 'C', 'Hygiène';
EXEC SP_Produit_Insert 'Shampoing bio', 'Description du shampoing bio', 8, 'A', 'Hygiène';
EXEC SP_Produit_Insert 'Savon bio', 'Description du savon bio', 5.50, 'D', 'Hygiène';
EXEC SP_Produit_Insert 'Produit de nettoyage multi-usage bio', 'Description du produit de nettoyage multi-usage bio', 11, 'D', 'Entretien';
