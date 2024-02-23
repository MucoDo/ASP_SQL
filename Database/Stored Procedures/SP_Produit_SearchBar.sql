CREATE PROCEDURE [dbo].[SP_Produit_SearchBar]
	@search NVARCHAR(100),
    @ecoscore CHAR(1)
AS
    DECLARE @searchTerm NVARCHAR(100);
    SET @searchTerm = '%' + @search + '%';
    
    SELECT * 
    FROM [dbo].[Produit] 
    WHERE (UPPER([NomProduit]) LIKE UPPER(@searchTerm) OR UPPER([Cat]) LIKE UPPER(@searchTerm) AND [EcoScore]=@ecoscore);