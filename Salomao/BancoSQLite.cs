using System.Data.SQLite;
using System.Windows.Input;
using Salomao.Security;

namespace Salomao
{
    internal class BancoSQLite
    {
        private static string dbFile = "AutoPecasDB.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static void CheckAndCreateDB()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        CREATE TABLE Categorias (
                            CategoriaID INTEGER PRIMARY KEY AUTOINCREMENT,
                            NomeCategoria TEXT NOT NULL
                        );

                        CREATE TABLE Clientes (
                            ClienteID INTEGER PRIMARY KEY AUTOINCREMENT,
                            NomeCliente TEXT NOT NULL,
                            Telefone TEXT,
                            Email TEXT
                        );

                        CREATE TABLE Fornecedores (
                            FornecedorID INTEGER PRIMARY KEY AUTOINCREMENT,
                            NomeFornecedor TEXT NOT NULL,
                            Endereco TEXT,
                            Telefone TEXT,
                            Email TEXT
                        );

                        CREATE TABLE Produtos (
                            ProdutoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            NomeProduto TEXT NOT NULL,
                            CodigoProduto TEXT NOT NULL,
                            CustoAquisicao REAL NOT NULL DEFAULT 0,
                            Status TEXT NOT NULL DEFAULT 0, 
                            Marca TEXT NULL,
                            Descricao TEXT NULL,
                            CategoriaID INTEGER,
                            FornecedorID INTEGER,
                            FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID),
                            FOREIGN KEY (FornecedorID) REFERENCES Fornecedores(FornecedorID)
                        );

                        CREATE TABLE Veiculos (
                            VeiculoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Placa TEXT NOT NULL,
                            Modelo TEXT NOT NULL,
                            Marca TEXT NOT NULL,
                            ClienteID INTEGER,
                            FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
                        );

                        CREATE TABLE Servicos (
                            ServicoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            VeiculoID INTEGER NOT NULL,
                            MargemLucro REAL NOT NULL,
                            FOREIGN KEY (VeiculoID) REFERENCES Veiculos(VeiculoID)
                        );

                        CREATE TABLE ServicoParaProduto (
                            ServicoID INTEGER NOT NULL,
                            ProdutoID INTEGER NOT NULL,
                            FOREIGN KEY (ServicoID) REFERENCES Servicos(ServicoID),
                            FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
                        );

                        CREATE TABLE Atendimentos (
                            AtendimentoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Data DATE NOT NULL,
                            DataPrestacao DATE NOT NULL,
                            PrevisaoConclusao DATE,
                            ClienteID INTEGER NOT NULL,
                            VeiculoID INTEGER NOT NULL,
                            ValorSugerido REAL NOT NULL DEFAULT 0,
                            ValorPraticado REAL NOT NULL DEFAULT 0,
                            LucroBruto REAL NOT NULL DEFAULT 0,
                            Observacoes TEXT,
                            FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
                            FOREIGN KEY (VeiculoID) REFERENCES Veiculos(VeiculoID)
                        );

                        CREATE TABLE AtendimentoServicos (
                            AtendimentoID INTEGER NOT NULL,
                            ServicoID INTEGER NOT NULL,
                            FOREIGN KEY (AtendimentoID) REFERENCES Atendimentos(AtendimentoID),
                            FOREIGN KEY (ServicoID) REFERENCES Servicos(ServicoID)
                        );

                        CREATE TABLE AtendimentoProdutos (
                            AtendimentoID INTEGER NOT NULL,
                            ProdutoID INTEGER NOT NULL,
                            FOREIGN KEY (AtendimentoID) REFERENCES Atendimentos(AtendimentoID),
                            FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
                        );

                        CREATE TABLE Usuarios (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Login TEXT NOT NULL,
                            SenhaHash TEXT NOT NULL,
                            Salt TEXT NOT NULL
                        );

                        CREATE TABLE MovimentoEstoque (
                            MovimentoID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ProdutoID INTEGER NOT NULL,
                            DataMovimento DATE NOT NULL,
                            Quantidade REAL NOT NULL,
                            TipoMovimento TEXT NOT NULL, -- 'E' para entrada, 'S' para saída
                            Origem TEXT,
                            Observacao TEXT,
                            FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
                        );

                        CREATE TABLE EstoqueAtual (
                            ProdutoID INTEGER PRIMARY KEY,
                            QuantidadeAtual REAL NOT NULL DEFAULT 0,
                            FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
                        );
                    ";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Banco de dados criado com sucesso!");
                }
            }

            //Valida se usuário existe, caso não, adicionar usuário padrão
            using (var connection = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Login = 'admin'";
                using (var command = new SQLiteCommand(query, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        string senha = "Auto@Admin";
                        string hash = PasswordManager.HashPassword(senha, out string salt);

                        string insert = "INSERT INTO Usuarios (Login, SenhaHash, Salt) VALUES (@u, @h, @s)";
                        using (var cmd = new SQLiteCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@u", "admin");
                            cmd.Parameters.AddWithValue("@h", hash);
                            cmd.Parameters.AddWithValue("@s", salt);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void AtualizarSenhaAdminPadrao()
        {
            using (var con = GetConnection())
            {
                string novaSenha = "Auto@AdminSecurityPassword";
                string novaHash = PasswordManager.HashPassword(novaSenha, out string novoSalt);

                string query = "UPDATE Usuarios SET SenhaHash = @hash, Salt = @salt WHERE Login = 'admin'";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@hash", novaHash);
                    cmd.Parameters.AddWithValue("@salt", novoSalt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Configurações PRAGMA para o banco de dados
            using (var pragmaCmd = new SQLiteCommand(connection))
            {
                // Ativa foreign keys
                pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
                pragmaCmd.ExecuteNonQuery();

                // Define journal mode como WAL (melhor desempenho e segurança em concorrência)
                pragmaCmd.CommandText = "PRAGMA journal_mode=WAL;";
                pragmaCmd.ExecuteNonQuery();
            }

            return connection;
        }
    }
}

