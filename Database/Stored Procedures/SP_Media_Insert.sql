CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@lienMedia nvarchar(256),
	@idProduit int
AS
	INSERT INTO [dbo].[Media] ([LienMedia], [Id_Produit]) 
	output inserted.Id_Media
	VALUES (@lienMedia, @idProduit);
