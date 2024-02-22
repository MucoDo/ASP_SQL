CREATE PROCEDURE [dbo].[SP_Produit_SearchBar]
	@search NVARCHAR(100)
AS
    DECLARE @searchTerm NVARCHAR(100);
    SET @searchTerm = '%' + @search + '%';
    
    SELECT * 
    FROM [dbo].[Produit] 
    WHERE UPPER([NomProduit]) LIKE UPPER(@searchTerm);