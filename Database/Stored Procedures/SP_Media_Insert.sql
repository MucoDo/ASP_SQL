CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@lienMedia NVARCHAR(256),
	@idProduit INT
AS
	INSERT INTO [dbo].[Media] ([LienMedia], [Id_Produit]) 
		OUTPUT [inserted].[Id_Media]
		VALUES (@lienMedia, @idProduit);
