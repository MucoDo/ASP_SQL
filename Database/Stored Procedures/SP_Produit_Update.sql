CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_Produit int,
	@nomProduit nvarchar(100),
	@description nvarchar(100),
	@prix decimal(10,2),
	@ecoscore char(1),
	@cat nvarchar(100)
AS
	UPDATE Produit
		SET 
			[NomProduit]=@nomProduit,
			[Description]=@description,
			[Prix]=@prix,
			[EcoScore]=@ecoscore,
			[Cat]=@cat
		WHERE Id_Produit=@id_Produit
