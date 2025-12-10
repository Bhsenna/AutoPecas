using System;
using System.Windows.Forms;

namespace AutoPecas
{
    /// <summary>
    /// Classe para gerenciar a sessão do usuário logado
    /// Utilize esta classe para armazenar informações do usuário em todo o sistema
    /// </summary>
    public static class SessionManager
    {
        #region Propriedades da Sessão

        /// <summary>
        /// Nome do usuário logado
        /// </summary>
        public static string UsuarioAtual { get; set; }

        /// <summary>
        /// ID do usuário no banco de dados
        /// </summary>
        public static int UsuarioID { get; set; }

        /// <summary>
        /// Hora em que o usuário fez login
        /// </summary>
        public static DateTime HoraLogin { get; private set; }

        /// <summary>
        /// Tipo/Perfil do usuário (Admin, Operador, etc)
        /// </summary>
        public static string TipoUsuario { get; set; }

        /// <summary>
        /// Indica se há um usuário logado
        /// </summary>
        public static bool EstaLogado => !string.IsNullOrEmpty(UsuarioAtual);

        #endregion

        #region Métodos de Gerenciamento

        /// <summary>
        /// Inicia uma nova sessão de usuário
        /// </summary>
        public static void IniciarSessao(string usuario, int id, string tipo = "Usuario")
        {
            UsuarioAtual = usuario;
            UsuarioID = id;
            TipoUsuario = tipo;
            HoraLogin = DateTime.Now;
        }

        /// <summary>
        /// Encerra a sessão atual do usuário
        /// </summary>
        public static void EncerrarSessao()
        {
            UsuarioAtual = null;
            UsuarioID = 0;
            TipoUsuario = null;
            HoraLogin = DateTime.MinValue;
        }

        /// <summary>
        /// Retorna o tempo de sessão ativa
        /// </summary>
        public static TimeSpan TempoSessao()
        {
            if (!EstaLogado)
                return TimeSpan.Zero;

            return DateTime.Now - HoraLogin;
        }

        /// <summary>
        /// Retorna uma mensagem de boas-vindas formatada
        /// </summary>
        public static string MensagemBoasVindas()
        {
            if (!EstaLogado)
                return "Bem-vindo!";

            var hora = DateTime.Now.Hour;
            string saudacao;

            if (hora < 12)
                saudacao = "Bom dia";
            else if (hora < 18)
                saudacao = "Boa tarde";
            else
                saudacao = "Boa noite";

            return $"{saudacao}, {UsuarioAtual}!";
        }

        #endregion
    }
}
