CREATE PROCEDURE [dbo].[SP_Produit_SearchBarOnlyEcoscore]
	@ecoscore CHAR(1)
AS
   
    SELECT * 
    FROM [dbo].[Produit] 
    WHERE  [EcoScore]=@ecoscore;