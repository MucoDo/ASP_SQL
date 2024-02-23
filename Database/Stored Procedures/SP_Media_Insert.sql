CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@LienMedia NVARCHAR(256),
	@Id_Produit INT
AS
	INSERT INTO [dbo].[Media] ([LienMedia],[Id_Produit]) 
		OUTPUT [inserted].[Id_Media]
		VALUES (@LienMedia,@Id_Produit);