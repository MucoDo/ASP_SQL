CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nomProduit nvarchar(100),
	@description nvarchar(100),
	@prix decimal(10,2),
	@ecoscore char(1),
	@cat nvarchar(100)
AS
	Insert into Produit ([NomProduit],[Description],[Prix],[EcoScore],[Cat])
		output [inserted].Id_Produit
		Values (@nomProduit,@description,@prix,@ecoscore,@cat)