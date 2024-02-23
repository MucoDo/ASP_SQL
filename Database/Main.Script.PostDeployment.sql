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
EXEC SP_Categorie_Insert 'Puériculture';
EXEC SP_Categorie_Insert 'Nettoyage';
EXEC SP_Produit_Insert 'Gourde', 'Gourde en verre','15.90','A','Vaiselle & Ustensiles de cuisine';
EXEC SP_Produit_Insert 'Lange', 'Lange en tissus','50','A','Puériculture';
EXEC SP_Produit_Insert 'Déboucheur', 'Déboucheur','50','C','Nettoyage';


declare @TDate datetime= getdate();

EXEC SP_Commande_Insert @TDate 
EXEC SP_Commande_Insert '2020-05-23T14:25:10'
EXEC SP_ProduitCommande_Insert 1,1,1
EXEC SP_ProduitCommande_Insert 8,2,1
EXEC SP_ProduitCommande_Insert 3,3,2
