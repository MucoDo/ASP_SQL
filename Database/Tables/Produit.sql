CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [NomProduit] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL, 
    [Prix] DECIMAL(10, 2) NOT NULL, 
    [EcoScore] CHAR NOT NULL, 
    [Cat] NVARCHAR(100) NOT NULL,
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Cat]) REFERENCES [Categorie]([Cat]), 
    CONSTRAINT [CK_Produit_EcoScore] CHECK (EcoScore IN ('A', 'B', 'C', 'D', 'E'))
)
