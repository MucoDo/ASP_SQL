CREATE PROCEDURE [dbo].[SP_ProduitCommande_Insert]
	@quantite INT,
	@idProduit INT,
	@idCommande INT
AS
	
INSERT INTO [dbo].[ProduitCommande] ([Quantité], [Id_Produit], [Id_Commande])
	VALUES (@quantite, @idProduit,@idCommande);
