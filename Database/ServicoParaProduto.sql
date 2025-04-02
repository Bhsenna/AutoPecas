CREATE TABLE [dbo].[ServicoParaProduto]
(
	[ServicoID] INT NOT NULL, 
    [ProdutoID] INT NOT NULL, 
    CONSTRAINT [FK_ServicoParaProduto_Servicos] FOREIGN KEY ([ServicoID]) REFERENCES [Servicos]([ServicoID]), 
    CONSTRAINT [FK_ServicoParaProduto_Produtos] FOREIGN KEY ([ProdutoID]) REFERENCES [Produtos]([ProdutoID]) 
)
