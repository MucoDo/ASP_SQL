﻿CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@categorie nvarchar(100)

AS
	INSERT into Categorie ([Cat])
	output inserted.Cat
	Values (@categorie) 