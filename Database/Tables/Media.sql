CREATE TABLE [dbo].[Media]
(
	[Id_Media] INT NOT NULL PRIMARY KEY, 
    [LienMedia] NVARCHAR(256) NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    CONSTRAINT [FK_Media_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit])
)
