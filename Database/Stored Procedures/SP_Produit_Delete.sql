CREATE PROCEDURE [dbo].[SP_Produit_Delete]
	@id_produit INT 
AS
	DELETE FROM [dbo].[Produit]
		WHERE [Id_Produit] = @id_produit