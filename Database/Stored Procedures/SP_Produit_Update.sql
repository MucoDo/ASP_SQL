CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_Produit INT,
	@nomProduit NVARCHAR(100),
	@description NVARCHAR(100),
	@prix DECIMAL(10,2),
	@ecoscore CHAR(1),
	@cat NVARCHAR(100)
AS
	UPDATE [dbo].[Produit]
		SET 
			[NomProduit]=@nomProduit,
			[Description]=@description,
			[Prix]=@prix,
			[EcoScore]=@ecoscore,
			[Cat]=@cat
		WHERE [Id_Produit]=@id_Produit
