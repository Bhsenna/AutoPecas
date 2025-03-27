CREATE TABLE [dbo].[Fornecedores]
(
	[FornecedorID] INT NOT NULL PRIMARY KEY, 
    [NomeFornecedor] NVARCHAR(100) NOT NULL, 
    [Endereco] NVARCHAR(250) NOT NULL, 
    [Telefone] CHAR(11) NULL, 
    [Email] NVARCHAR(150) NULL
)
