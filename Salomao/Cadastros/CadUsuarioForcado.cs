using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salomao.Security;

namespace Salomao.Cadastros
{
    public partial class CadUsuarioForcado : Form
    {
        public CadUsuarioForcado()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string novoLogin = txtNovoUsuario.Text.Trim();
            string novaSenha = txtNovaSenha.Text;
            string confirmaSenha = txtConfirmaSenha.Text;

            if (string.IsNullOrEmpty(novoLogin) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmaSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LoginService.ExisteUsuario(novoLogin))
            {
                MessageBox.Show("Usuário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Cria novo usuário
                LoginService.CriarUsuario(novoLogin, novaSenha);

                // Troca a senha do admin para Auto@AdminSecurity
                LoginService.TrocarSenha("admin", "Auto@AdminSecurity");

                MessageBox.Show("Usuário cadastrado com sucesso!\nA senha do admin foi alterada para 'Auto@AdminSecurity'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
