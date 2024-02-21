CREATE PROCEDURE [dbo].SP_Produit_GetALL_favoris
AS
	SELECT TOP 10 Produit.Id_Produit, Produit.NomProduit, sum(ProduitCommande.Quantité) as TotalQuantiteParProduit
	From Produit inner join ProduitCommande
	on Produit.Id_Produit=ProduitCommande.Id_Produit
	Group by Produit.Id_Produit, Produit.NomProduit
	order by sum(ProduitCommande.Quantité) desc
