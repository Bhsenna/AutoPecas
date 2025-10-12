using System;
using System.Data;
using System.Data.SQLite;

namespace Salomao
{
    public static class EstoqueManager
    {
        /// <summary>
        /// Registra entrada de produtos no estoque
        /// </summary>
        public static void RegistrarEntrada(int produtoId, decimal quantidade, string origem = "Entrada Manual", string observacao = "")
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Registra o movimento
                        string sqlMovimento = @"
                            INSERT INTO MovimentoEstoque 
                            (ProdutoID, DataMovimento, Quantidade, TipoMovimento, Origem, Observacao)
                            VALUES (@ProdutoID, @DataMovimento, @Quantidade, 'E', @Origem, @Observacao)";

                        using (var cmd = new SQLiteCommand(sqlMovimento, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                            cmd.Parameters.AddWithValue("@DataMovimento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                            cmd.Parameters.AddWithValue("@Origem", origem);
                            cmd.Parameters.AddWithValue("@Observacao", observacao);
                            cmd.ExecuteNonQuery();
                        }

                        // Atualiza o saldo atual
                        AtualizarSaldoEstoque(connection, transaction, produtoId, quantidade, true);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Registra saída de produtos do estoque
        /// </summary>
        public static void RegistrarSaida(int produtoId, decimal quantidade, string origem = "Saída Manual", string observacao = "", int? atendimentoId = null)
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Verifica se há estoque suficiente
                        decimal saldoAtual = ObterSaldoAtual(connection, produtoId);
                        if (saldoAtual < quantidade)
                        {
                            throw new InvalidOperationException($"Estoque insuficiente. Saldo atual: {saldoAtual}, Quantidade solicitada: {quantidade}");
                        }

                        // Registra o movimento
                        string sqlMovimento = @"
                            INSERT INTO MovimentoEstoque 
                            (ProdutoID, DataMovimento, Quantidade, TipoMovimento, Origem, Observacao, AtendimentoID)
                            VALUES (@ProdutoID, @DataMovimento, @Quantidade, 'S', @Origem, @Observacao, @AtendimentoID)";

                        using (var cmd = new SQLiteCommand(sqlMovimento, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                            cmd.Parameters.AddWithValue("@DataMovimento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                            cmd.Parameters.AddWithValue("@Origem", origem);
                            cmd.Parameters.AddWithValue("@Observacao", observacao);
                            cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoId ?? (object)DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        // Atualiza o saldo atual
                        AtualizarSaldoEstoque(connection, transaction, produtoId, quantidade, false);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Atualiza o saldo de estoque de um produto
        /// </summary>
        private static void AtualizarSaldoEstoque(SQLiteConnection connection, SQLiteTransaction transaction, int produtoId, decimal quantidade, bool isEntrada)
        {
            // Verifica se já existe registro na tabela EstoqueAtual
            string checkSql = "SELECT COUNT(*) FROM EstoqueAtual WHERE ProdutoID = @ProdutoID";
            using (var checkCmd = new SQLiteCommand(checkSql, connection, transaction))
            {
                checkCmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    // Insere novo registro
                    string insertSql = @"
                        INSERT INTO EstoqueAtual (ProdutoID, QuantidadeAtual)
                        VALUES (@ProdutoID, @Quantidade)";
                    
                    using (var insertCmd = new SQLiteCommand(insertSql, connection, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                        insertCmd.Parameters.AddWithValue("@Quantidade", isEntrada ? quantidade : -quantidade);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Atualiza registro existente
                    string updateSql = @"
                        UPDATE EstoqueAtual 
                        SET QuantidadeAtual = QuantidadeAtual + @Quantidade
                        WHERE ProdutoID = @ProdutoID";
                    
                    using (var updateCmd = new SQLiteCommand(updateSql, connection, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                        updateCmd.Parameters.AddWithValue("@Quantidade", isEntrada ? quantidade : -quantidade);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Obtém o saldo atual de um produto
        /// </summary>
        public static decimal ObterSaldoAtual(int produtoId)
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                return ObterSaldoAtual(connection, produtoId);
            }
        }

        /// <summary>
        /// Obtém o saldo atual de um produto (versão com conexão)
        /// </summary>
        private static decimal ObterSaldoAtual(SQLiteConnection connection, int produtoId)
        {
            string sql = "SELECT QuantidadeAtual FROM EstoqueAtual WHERE ProdutoID = @ProdutoID";
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        /// <summary>
        /// Obtém todos os saldos de estoque
        /// </summary>
        public static DataTable ObterSaldosEstoque()
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                string sql = @"
                    SELECT 
                        p.NomeProduto,
                        p.CodigoProduto,
                        p.Marca,
                        c.NomeCategoria,
                        COALESCE(ea.QuantidadeAtual, 0) as SaldoAtual,
                        p.CustoAquisicao,
                        (COALESCE(ea.QuantidadeAtual, 0) * p.CustoAquisicao) as ValorTotal
                    FROM Produtos p
                    LEFT JOIN Categorias c ON c.CategoriaID = p.CategoriaID
                    LEFT JOIN EstoqueAtual ea ON ea.ProdutoID = p.ProdutoID
                    ORDER BY p.NomeProduto";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Obtém movimentos de estoque
        /// </summary>
        public static DataTable ObterMovimentosEstoque(DateTime? dataInicio = null, DateTime? dataFim = null, int? produtoId = null)
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                string sql = @"
                    SELECT 
                        me.MovimentoID,
                        me.DataMovimento,
                        p.NomeProduto,
                        p.CodigoProduto,
                        me.Quantidade,
                        me.TipoMovimento,
                        me.Origem,
                        me.Observacao,
                        a.AtendimentoID
                    FROM MovimentoEstoque me
                    INNER JOIN Produtos p ON p.ProdutoID = me.ProdutoID
                    LEFT JOIN Atendimentos a ON a.AtendimentoID = me.AtendimentoID
                    WHERE 1=1";

                if (dataInicio.HasValue)
                    sql += " AND me.DataMovimento >= @DataInicio";
                if (dataFim.HasValue)
                    sql += " AND me.DataMovimento <= @DataFim";
                if (produtoId.HasValue)
                    sql += " AND me.ProdutoID = @ProdutoID";

                sql += " ORDER BY me.DataMovimento DESC";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    if (dataInicio.HasValue)
                        cmd.Parameters.AddWithValue("@DataInicio", dataInicio.Value);
                    if (dataFim.HasValue)
                        cmd.Parameters.AddWithValue("@DataFim", dataFim.Value);
                    if (produtoId.HasValue)
                        cmd.Parameters.AddWithValue("@ProdutoID", produtoId.Value);

                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Processa a baixa automática de estoque para um atendimento
        /// </summary>
        public static void ProcessarBaixaEstoqueAtendimento(int atendimentoId)
        {
            using (var connection = BancoSQLite.GetConnection())
            {
                // Obtém todos os serviços do atendimento
                string sqlServicos = @"
                    SELECT 
                        asp.ServicoID,
                        asp.Quantidade as QtdServico,
                        sp.ProdutoID,
                        sp.Quantidade as QtdProduto
                    FROM AtendimentoServicos asp
                    INNER JOIN ServicoParaProduto sp ON sp.ServicoID = asp.ServicoID
                    WHERE asp.AtendimentoID = @AtendimentoID";

                using (var cmd = new SQLiteCommand(sqlServicos, connection))
                {
                    cmd.Parameters.AddWithValue("@AtendimentoID", atendimentoId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int produtoId = reader.GetInt32("ProdutoID");
                            decimal qtdServico = reader.GetDecimal("QtdServico");
                            decimal qtdProduto = reader.GetDecimal("QtdProduto");
                            decimal quantidadeTotal = qtdServico * qtdProduto;

                            // Registra a saída do estoque
                            RegistrarSaida(produtoId, quantidadeTotal, "Atendimento", $"Atendimento #{atendimentoId}", atendimentoId);
                        }
                    }
                }
            }
        }
    }
} 