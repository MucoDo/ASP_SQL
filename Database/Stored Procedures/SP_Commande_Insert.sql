CREATE PROCEDURE [dbo].[SP_Commande_Insert]
	@dateCommande datetime
	
AS
	INSERT INTO [dbo].[Commande] ([DateCommande]) 
	output inserted.Id_Commande
	VALUES (@dateCommande);
