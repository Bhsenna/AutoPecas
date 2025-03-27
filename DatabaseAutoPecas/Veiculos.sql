CREATE TABLE [dbo].[Veiculos]
(
	[VeiculoID] INT NOT NULL PRIMARY KEY, 
    [PlacaVeiculo] NCHAR(8) NULL, 
    [Modelo] NVARCHAR(250) NULL, 
    [Marca] NVARCHAR(100) NULL, 
    [ClienteID] INT NOT NULL, 
    CONSTRAINT [FK_Veiculos_Clientes] FOREIGN KEY ([ClienteID]) REFERENCES [Clientes]([ClienteID])
)
