CREATE TABLE [dbo].[Clientes]
(
	[ClienteID] INT NOT NULL PRIMARY KEY, 
    [NomeCliente] NVARCHAR(250) NOT NULL, 
    [Telefone] CHAR(11) NULL, 
    [Email] NVARCHAR(150) NULL
)
