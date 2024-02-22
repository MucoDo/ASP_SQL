CREATE PROCEDURE [dbo].[SP_Produit_GetById]
	@id_produit INT
	
AS
	SELECT     [Id_Produit],
               [NomProduit],
               [Description],
               [Prix],
               [EcoScore],
               [Cat]
    FROM [dbo].Produit
    WHERE [Id_Produit]=@id_produit

