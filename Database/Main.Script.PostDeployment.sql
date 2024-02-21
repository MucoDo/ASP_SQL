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

EXEC SP_Categorie_Insert 'Vaiselle & Ustensiles de cuisine';
EXEC SP_Produit_Insert 'gourde', 'Gourde en verre','15.90','A','Vaiselle & Ustensiles de cuisine';
EXEC SP_Media_Insert 'gourde1.png',1;

declare @TDate datetime= getdate();

EXEC SP_Commande_Insert @TDate 
EXEC SP_ProduitCommande_Insert 1,1,1
