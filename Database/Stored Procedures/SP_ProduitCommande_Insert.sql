CREATE PROCEDURE [dbo].[SP_ProduitCommande_Insert]
	@quantite int,
	@idProduit int,
	@idCommande int
AS
	
INSERT INTO [dbo].[ProduitCommande] ([Quantité], [Id_Produit], [Id_Commande])
VALUES (@quantite, @idProduit,@idCommande);
