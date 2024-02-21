CREATE TABLE [dbo].[Commande]
(
	[Id_Commande] INT IDENTITY(1,1) NOT NULL , 
    [DateCommande] DATETIME NOT NULL, 
    CONSTRAINT [PK_Commande] PRIMARY KEY ([Id_Commande]) 
)
