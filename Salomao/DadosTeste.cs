using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace Salomao
{
    internal static class DadosTeste
    {
        public static void CarregarDadosTeste(SQLiteConnection connection)
        {
            try
            {
                CarregarCategorias(connection);
                CarregarFornecedores(connection);
                CarregarProdutos(connection);
                CarregarClientes(connection);
                CarregarVeiculos(connection);
                CarregarServicos(connection);
                CarregarServicoProdutos(connection);
                CarregarAtendimentos(connection);
                CarregarMovimentosEstoque(connection);

                System.Windows.Forms.MessageBox.Show("Dados de teste carregados com sucesso!\n\n" +
                    "Usuário Admin: admin\n" +
                    "Senha: Auto@Admin\n\n" +
                    "Dados incluídos:\n" +
                    "• 5 Categorias\n" +
                    "• 3 Fornecedores\n" +
                    "• 10 Produtos\n" +
                    "• 3 Clientes\n" +
                    "• 3 Veículos\n" +
                    "• 5 Serviços\n" +
                    "• 2 Atendimentos\n" +
                    "• Movimentos de Estoque", 
                    "Dados de Teste", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Erro ao carregar dados de teste: {ex.Message}", 
                    "Erro", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        private static void CarregarCategorias(SQLiteConnection connection)
        {
            string[] categorias = {
                "Motor e Transmissão",
                "Suspensão e Freios",
                "Elétrica e Eletrônica",
                "Carroceria e Pintura",
                "Acessórios e Customização"
            };

            string sql = "INSERT INTO Categorias (NomeCategoria) VALUES (@nome)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (string categoria in categorias)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nome", categoria);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarFornecedores(SQLiteConnection connection)
        {
            var fornecedores = new[]
            {
                new { Nome = "Auto Parts Ltda", Endereco = "Rua das Peças, 123 - Centro", Telefone = "(11) 3333-4444", Email = "contato@autoparts.com.br" },
                new { Nome = "Mega Fornecedor", Endereco = "Av. Industrial, 456 - Zona Norte", Telefone = "(11) 5555-6666", Email = "vendas@megafornecedor.com.br" },
                new { Nome = "Peças Express", Endereco = "Rua do Comércio, 789 - Zona Sul", Telefone = "(11) 7777-8888", Email = "pedidos@pecasexpress.com.br" }
            };

            string sql = "INSERT INTO Fornecedores (NomeFornecedor, Endereco, Telefone, Email) VALUES (@nome, @endereco, @telefone, @email)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var fornecedor in fornecedores)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nome", fornecedor.Nome);
                    command.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                    command.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                    command.Parameters.AddWithValue("@email", fornecedor.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarProdutos(SQLiteConnection connection)
        {
            var produtos = new[]
            {
                new { Nome = "Óleo de Motor 5W30", Codigo = "OLE001", Custo = 25.50m, Marca = "Mobil", Descricao = "Óleo sintético para motor", Categoria = 1, Fornecedor = 1 },
                new { Nome = "Filtro de Ar", Codigo = "FIL001", Custo = 15.00m, Marca = "Fram", Descricao = "Filtro de ar do motor", Categoria = 1, Fornecedor = 1 },
                new { Nome = "Pastilha de Freio", Codigo = "FRE001", Custo = 45.00m, Marca = "Ferodo", Descricao = "Pastilha de freio dianteira", Categoria = 2, Fornecedor = 2 },
                new { Nome = "Amortecedor Dianteiro", Codigo = "SUS001", Custo = 180.00m, Marca = "Monroe", Descricao = "Amortecedor dianteiro esquerdo", Categoria = 2, Fornecedor = 2 },
                new { Nome = "Bateria 60Ah", Codigo = "BAT001", Custo = 320.00m, Marca = "Moura", Descricao = "Bateria automotiva 60Ah", Categoria = 3, Fornecedor = 3 },
                new { Nome = "Farol Principal", Codigo = "FAR001", Custo = 95.00m, Marca = "Osram", Descricao = "Farol principal H4", Categoria = 3, Fornecedor = 3 },
                new { Nome = "Tinta Automotiva", Codigo = "TIN001", Custo = 75.00m, Marca = "Dupont", Descricao = "Tinta automotiva 1L", Categoria = 4, Fornecedor = 1 },
                new { Nome = "Tapete de Borracha", Codigo = "TAP001", Custo = 35.00m, Marca = "Auto Access", Descricao = "Tapete de borracha completo", Categoria = 5, Fornecedor = 2 },
                new { Nome = "Alto Falante", Codigo = "SOM001", Custo = 120.00m, Marca = "Pioneer", Descricao = "Alto falante 6 polegadas", Categoria = 5, Fornecedor = 3 },
                new { Nome = "Correia Dentada", Codigo = "COR001", Custo = 85.00m, Marca = "Gates", Descricao = "Correia dentada do motor", Categoria = 1, Fornecedor = 1 }
            };

            string sql = "INSERT INTO Produtos (NomeProduto, CodigoProduto, CustoAquisicao, Marca, Descricao, CategoriaID, FornecedorID) VALUES (@nome, @codigo, @custo, @marca, @descricao, @categoria, @fornecedor)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var produto in produtos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nome", produto.Nome);
                    command.Parameters.AddWithValue("@codigo", produto.Codigo);
                    command.Parameters.AddWithValue("@custo", produto.Custo);
                    command.Parameters.AddWithValue("@marca", produto.Marca);
                    command.Parameters.AddWithValue("@descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@categoria", produto.Categoria);
                    command.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);
                    command.ExecuteNonQuery();
                }
            }

            string sqlEstoque = "INSERT INTO EstoqueAtual (ProdutoID, QuantidadeAtual) SELECT ProdutoID, 50 FROM Produtos";
            using (var command = new SQLiteCommand(sqlEstoque, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void CarregarClientes(SQLiteConnection connection)
        {
            var clientes = new[]
            {
                new { Nome = "João Silva", Telefone = "(11) 99999-1111", Email = "joao.silva@email.com" },
                new { Nome = "Maria Santos", Telefone = "(11) 99999-2222", Email = "maria.santos@email.com" },
                new { Nome = "Pedro Oliveira", Telefone = "(11) 99999-3333", Email = "pedro.oliveira@email.com" }
            };

            string sql = "INSERT INTO Clientes (NomeCliente, Telefone, Email) VALUES (@nome, @telefone, @email)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var cliente in clientes)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nome", cliente.Nome);
                    command.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    command.Parameters.AddWithValue("@email", cliente.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarVeiculos(SQLiteConnection connection)
        {
            var veiculos = new[]
            {
                new { Placa = "ABC1234", Modelo = "Civic", Marca = "Honda", Cliente = 1 },
                new { Placa = "DEF5678", Modelo = "Corolla", Marca = "Toyota", Cliente = 2 },
                new { Placa = "GHI9012", Modelo = "Golf", Marca = "Volkswagen", Cliente = 3 }
            };

            string sql = "INSERT INTO Veiculos (Placa, Modelo, Marca, ClienteID) VALUES (@placa, @modelo, @marca, @cliente)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var veiculo in veiculos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@placa", veiculo.Placa);
                    command.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    command.Parameters.AddWithValue("@marca", veiculo.Marca);
                    command.Parameters.AddWithValue("@cliente", veiculo.Cliente);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarServicos(SQLiteConnection connection)
        {
            var servicos = new[]
            {
                new { Nome = "Troca de Óleo", Descricao = "Troca de óleo e filtros", Margem = 30.0 },
                new { Nome = "Revisão Completa", Descricao = "Revisão completa do veículo", Margem = 25.0 },
                new { Nome = "Troca de Pastilhas", Descricao = "Troca de pastilhas de freio", Margem = 35.0 },
                new { Nome = "Alinhamento", Descricao = "Alinhamento e balanceamento", Margem = 20.0 },
                new { Nome = "Troca de Bateria", Descricao = "Troca de bateria automotiva", Margem = 25.0 }
            };

            string sql = "INSERT INTO Servicos (NomeServico, Descricao, MargemLucro) VALUES (@nome, @descricao, @margem)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var servico in servicos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nome", servico.Nome);
                    command.Parameters.AddWithValue("@descricao", servico.Descricao);
                    command.Parameters.AddWithValue("@margem", servico.Margem);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarServicoProdutos(SQLiteConnection connection)
        {
            var servicoProdutos = new[]
            {
                new { Servico = 1, Produto = 1, Quantidade = 1.0 }, // Troca de Óleo - Óleo
                new { Servico = 1, Produto = 2, Quantidade = 1.0 }, // Troca de Óleo - Filtro
                new { Servico = 2, Produto = 1, Quantidade = 1.0 }, // Revisão - Óleo
                new { Servico = 2, Produto = 2, Quantidade = 1.0 }, // Revisão - Filtro
                new { Servico = 2, Produto = 3, Quantidade = 4.0 }, // Revisão - Pastilhas
                new { Servico = 3, Produto = 3, Quantidade = 4.0 }, // Troca Pastilhas - Pastilhas
                new { Servico = 4, Produto = 4, Quantidade = 2.0 }, // Alinhamento - Amortecedores
                new { Servico = 5, Produto = 5, Quantidade = 1.0 }  // Troca Bateria - Bateria
            };

            string sql = "INSERT INTO ServicoParaProduto (ServicoID, ProdutoID, Quantidade) VALUES (@servico, @produto, @quantidade)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var sp in servicoProdutos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@servico", sp.Servico);
                    command.Parameters.AddWithValue("@produto", sp.Produto);
                    command.Parameters.AddWithValue("@quantidade", sp.Quantidade);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarAtendimentos(SQLiteConnection connection)
        {
            var atendimentos = new[]
            {
                new { 
                    Data = DateTime.Now.AddDays(-5), 
                    DataPrestacao = DateTime.Now.AddDays(-5), 
                    PrevisaoConclusao = DateTime.Now.AddDays(-4),
                    Cliente = 1, 
                    Veiculo = 1, 
                    ValorSugerido = 180.00m, 
                    ValorPraticado = 140.00m, 
                    LucroBruto = 35.00m,
                    Observacoes = "Troca de óleo completa"
                },
                new { 
                    Data = DateTime.Now.AddDays(-2), 
                    DataPrestacao = DateTime.Now.AddDays(-2), 
                    PrevisaoConclusao = DateTime.Now.AddDays(1),
                    Cliente = 2, 
                    Veiculo = 2, 
                    ValorSugerido = 450.00m, 
                    ValorPraticado = 420.00m, 
                    LucroBruto = 105.00m,
                    Observacoes = "Revisão completa em andamento"
                },
                new { 
                    Data = DateTime.Now.AddDays(1), 
                    DataPrestacao = DateTime.Now.AddDays(1), 
                    PrevisaoConclusao = DateTime.Now.AddDays(2),
                    Cliente = 3, 
                    Veiculo = 3, 
                    ValorSugerido = 250.00m, 
                    ValorPraticado = 250.00m, 
                    LucroBruto = 62.50m,
                    Observacoes = "Troca de pastilhas agendada"
                }
            };

            string sql = "INSERT INTO Atendimentos (Data, DataPrestacao, PrevisaoConclusao, ClienteID, VeiculoID, ValorSugerido, ValorPraticado, LucroBruto, Observacoes) VALUES (@data, @dataPrestacao, @previsao, @cliente, @veiculo, @valorSugerido, @valorPraticado, @lucro, @observacoes)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var atendimento in atendimentos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@data", atendimento.Data.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@dataPrestacao", atendimento.DataPrestacao.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@previsao", atendimento.PrevisaoConclusao.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@cliente", atendimento.Cliente);
                    command.Parameters.AddWithValue("@veiculo", atendimento.Veiculo);
                    command.Parameters.AddWithValue("@valorSugerido", atendimento.ValorSugerido);
                    command.Parameters.AddWithValue("@valorPraticado", atendimento.ValorPraticado);
                    command.Parameters.AddWithValue("@lucro", atendimento.LucroBruto);
                    command.Parameters.AddWithValue("@observacoes", atendimento.Observacoes);
                    command.ExecuteNonQuery();
                }
            }

            // Adiciona serviços aos atendimentos
            var atendimentoServicos = new[]
            {
                new { Atendimento = 1, Servico = 1, Quantidade = 1.0, ValorUnitario = 140.00m },
                new { Atendimento = 2, Servico = 2, Quantidade = 1.0, ValorUnitario = 420.00m },
                new { Atendimento = 3, Servico = 3, Quantidade = 1.0, ValorUnitario = 250.00m }
            };

            string sqlServicos = "INSERT INTO AtendimentoServicos (AtendimentoID, ServicoID, Quantidade, ValorUnitario) VALUES (@atendimento, @servico, @quantidade, @valor)";
            using (var command = new SQLiteCommand(sqlServicos, connection))
            {
                foreach (var as_servico in atendimentoServicos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@atendimento", as_servico.Atendimento);
                    command.Parameters.AddWithValue("@servico", as_servico.Servico);
                    command.Parameters.AddWithValue("@quantidade", as_servico.Quantidade);
                    command.Parameters.AddWithValue("@valor", as_servico.ValorUnitario);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void CarregarMovimentosEstoque(SQLiteConnection connection)
        {
            var movimentos = new[]
            {
                new { Produto = 1, Data = DateTime.Now.AddDays(-10), Quantidade = 100.0, Tipo = "E", Origem = "Compra inicial", Observacao = "Estoque inicial", Atendimento = 0 },
                new { Produto = 2, Data = DateTime.Now.AddDays(-10), Quantidade = 50.0, Tipo = "E", Origem = "Compra inicial", Observacao = "Estoque inicial", Atendimento = 0 },
                new { Produto = 3, Data = DateTime.Now.AddDays(-10), Quantidade = 80.0, Tipo = "E", Origem = "Compra inicial", Observacao = "Estoque inicial", Atendimento = 0 },
                new { Produto = 1, Data = DateTime.Now.AddDays(-5), Quantidade = 1.0, Tipo = "S", Origem = "Atendimento", Observacao = "Troca de óleo", Atendimento = 1 },
                new { Produto = 2, Data = DateTime.Now.AddDays(-5), Quantidade = 1.0, Tipo = "S", Origem = "Atendimento", Observacao = "Troca de filtro", Atendimento = 1 },
                new { Produto = 1, Data = DateTime.Now.AddDays(-2), Quantidade = 1.0, Tipo = "S", Origem = "Atendimento", Observacao = "Revisão completa", Atendimento = 2 },
                new { Produto = 2, Data = DateTime.Now.AddDays(-2), Quantidade = 1.0, Tipo = "S", Origem = "Atendimento", Observacao = "Revisão completa", Atendimento = 2 },
                new { Produto = 3, Data = DateTime.Now.AddDays(-2), Quantidade = 4.0, Tipo = "S", Origem = "Atendimento", Observacao = "Revisão completa", Atendimento = 2 }
            };
        
            string sql = "INSERT INTO MovimentoEstoque (ProdutoID, DataMovimento, Quantidade, TipoMovimento, Origem, Observacao, AtendimentoID) VALUES (@produto, @data, @quantidade, @tipo, @origem, @observacao, @atendimento)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                foreach (var movimento in movimentos)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@produto", movimento.Produto);
                    command.Parameters.AddWithValue("@data", movimento.Data.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@quantidade", movimento.Quantidade);
                    command.Parameters.AddWithValue("@tipo", movimento.Tipo);
                    command.Parameters.AddWithValue("@origem", movimento.Origem);
                    command.Parameters.AddWithValue("@observacao", movimento.Observacao);
                    command.Parameters.AddWithValue("@atendimento", (object)movimento.Atendimento ?? DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}