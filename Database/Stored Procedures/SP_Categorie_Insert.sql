CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@categorie NVARCHAR(100)

AS
	INSERT INTO [dbo].[Categorie] ([Cat])
		OUTPUT [inserted].[Cat]
		VALUES (@categorie) 