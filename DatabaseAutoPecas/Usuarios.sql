﻿CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(50) NOT NULL, 
    [SenhaHash] NVARCHAR(256) NOT NULL, 
    [Salt] NVARCHAR(64) NOT NULL
)
