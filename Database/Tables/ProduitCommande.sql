﻿CREATE TABLE [dbo].[ProduitCommande]
(
	[Id_ProduitCommande] INT NOT NULL PRIMARY KEY, 
    [Quantité] INT NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    [Id_Commande] INT NOT NULL, 
    CONSTRAINT [FK_ProduitCommande_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit]), 
    CONSTRAINT [FK_ProduitCommande_Commande] FOREIGN KEY ([Id_Commande]) REFERENCES [Commande]([Id_Commande])
)
