using System;
using System.Windows.Forms;

namespace Salomao
{
    /// <summary>
    /// Exemplo de como testar o Dashboard diretamente
    /// Este form pode ser usado para testes rápidos durante o desenvolvimento
    /// </summary>
    public partial class DashboardTester : Form
    {
        public DashboardTester()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Dashboard Tester";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Botão para testar dashboard
            var btnTestarDashboard = new Button
            {
                Text = "Abrir Dashboard",
                Size = new System.Drawing.Size(200, 40),
                Location = new System.Drawing.Point(100, 50),
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };
            btnTestarDashboard.Click += BtnTestarDashboard_Click;

            // Botão para testar com dados fake
            var btnDadosFake = new Button
            {
                Text = "Gerar Dados de Teste",
                Size = new System.Drawing.Size(200, 40),
                Location = new System.Drawing.Point(100, 110),
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };
            btnDadosFake.Click += BtnDadosFake_Click;

            // Botão para limpar dados
            var btnLimparDados = new Button
            {
                Text = "Limpar Banco de Dados",
                Size = new System.Drawing.Size(200, 40),
                Location = new System.Drawing.Point(100, 170),
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };
            btnLimparDados.Click += BtnLimparDados_Click;

            // Label de informação
            var lblInfo = new Label
            {
                Text = "Use este tester para desenvolvimento",
                Size = new System.Drawing.Size(300, 20),
                Location = new System.Drawing.Point(50, 230),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 9F)
            };

            this.Controls.Add(btnTestarDashboard);
            this.Controls.Add(btnDadosFake);
            this.Controls.Add(btnLimparDados);
            this.Controls.Add(lblInfo);
        }

        private void BtnTestarDashboard_Click(object sender, EventArgs e)
        {
            // Simular usuário logado
            SessionManager.IniciarSessao("Admin Teste", 1, "Administrador");

            // Abrir tela principal
            var telaInicial = new TelaInicial();
            telaInicial.Show();

            MessageBox.Show(
                "Tela principal aberta!\n\n" +
                $"Usuário: {SessionManager.UsuarioAtual}\n" +
                $"Tipo: {SessionManager.TipoUsuario}\n" +
                $"Hora Login: {SessionManager.HoraLogin:HH:mm:ss}",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnDadosFake_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = BancoSQLite.GetConnection())
                {
                    DadosTeste.CarregarDadosTeste(connection);
                }

                MessageBox.Show(
                    "Dados de teste carregados com sucesso!\n\n" +
                    "Você pode agora testar o dashboard com dados reais.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar dados de teste:\n{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnLimparDados_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "ATENÇÃO: Isso irá apagar todos os dados do banco!\n\n" +
                "Deseja continuar?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var connection = BancoSQLite.GetConnection())
                    {
                        var tabelas = new[] {
                            "AtendimentoServicos",
                            "ServicoParaProduto",
                            "MovimentoEstoque",
                            "EstoqueAtual",
                            "Atendimentos",
                            "Veiculos",
                            "Produtos",
                            "Servicos",
                            "Clientes",
                            "Fornecedores",
                            "Categorias"
                        };

                        foreach (var tabela in tabelas)
                        {
                            using (var cmd = new System.Data.SQLite.SQLiteCommand(
                                $"DELETE FROM {tabela}", connection))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show(
                        "Todos os dados foram removidos!\n\n" +
                        "Use o botão 'Gerar Dados de Teste' para popular novamente.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Erro ao limpar dados:\n{ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }

    /// <summary>
    /// Program.cs alternativo para testes
    /// Use este código em Program.cs para testar rapidamente
    /// </summary>
    public static class ProgramTeste
    {
        /*
        [STAThread]
        static void Main()
        {
            // Inicializar banco de dados
            BancoSQLite.CheckAndCreateDB();
            
            ApplicationConfiguration.Initialize();

            // Opção 1: Abrir diretamente a tela principal (para testes)
            SessionManager.IniciarSessao("Desenvolvedor", 999, "Admin");
            Application.Run(new TelaInicial());

            // Opção 2: Usar o tester
            // Application.Run(new DashboardTester());

            // Opção 3: Fluxo normal com login
            // Login login = new Login();
            // login.Show();
            // Application.Run();
        }
        */
    }
}
