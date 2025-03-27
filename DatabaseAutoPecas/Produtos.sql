CREATE TABLE [dbo].[Produtos]
(
	[ProdutoID] INT NOT NULL PRIMARY KEY, 
    [NomeProduto] NVARCHAR(MAX) NOT NULL, 
    [CodigoProduto] INT NOT NULL, 
    [PrecoCusto] MONEY NULL, 
    [Status] BIT NOT NULL DEFAULT 0
)
