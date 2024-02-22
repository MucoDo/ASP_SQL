CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nomProduit NVARCHAR(100),
	@description NVARCHAR(100),
	@prix DECIMAL(10,2),
	@ecoscore CHAR(1),
	@cat NVARCHAR(100)
AS
	INSERT INTO  [dbo].[Produit] ([NomProduit],[Description],[Prix],[EcoScore],[Cat])
		output [inserted].[Id_Produit]
		Values (@nomProduit,@description,@prix,@ecoscore,@cat)