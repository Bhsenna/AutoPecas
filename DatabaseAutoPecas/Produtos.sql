CREATE TABLE [dbo].[Produtos]
(
	[ProdutoID] INT NOT NULL PRIMARY KEY, 
    [NomeProduto] NVARCHAR(250) NOT NULL, 
    [CodigoProduto] NVARCHAR(12) NULL, 
    [CustoAquisicao] MONEY NOT NULL DEFAULT 0, 
    [Status] NCHAR(1) NOT NULL DEFAULT 0, 
    [Marca] NVARCHAR(100) NULL, 
    [Descricao] NVARCHAR(250) NULL, 
    [CategoriaID] INT NOT NULL, 
    [FornecedorID] INT NOT NULL, 
    CONSTRAINT [FK_Produtos_Categorias] FOREIGN KEY ([CategoriaID]) REFERENCES [Categorias]([CategoriaID]), 
    CONSTRAINT [FK_Produtos_Fornecedores] FOREIGN KEY ([FornecedorID]) REFERENCES [Fornecedores]([FornecedorID])
)
