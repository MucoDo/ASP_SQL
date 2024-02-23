CREATE PROCEDURE [dbo].[SP_Produit_SearchBarOnlySearch]
	@search NVARCHAR(100)
    
AS
    DECLARE @searchTerm NVARCHAR(100);
    SET @searchTerm = '%' + @search + '%';
    
    SELECT * 
    FROM [dbo].[Produit] 
    WHERE UPPER([NomProduit]) LIKE UPPER(@searchTerm) OR UPPER([Cat]) LIKE UPPER(@searchTerm);