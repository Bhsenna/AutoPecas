using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salomao.Security
{
    public class LoginService
    {
        public static bool ExisteUsuario(string login)
        {
            using var con = BancoSQLite.GetConnection();
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login";
            using var cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@login", login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public static void CriarUsuario(string login, string senha)
        {
            using var con = BancoSQLite.GetConnection();

            string hash = PasswordManager.HashPassword(senha, out string salt);

            string query = @"INSERT INTO Usuarios (Login, SenhaHash, Salt)
                         VALUES (@login, @senha, @salt)";
            using var cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", hash);
            cmd.Parameters.AddWithValue("@salt", salt);

            cmd.ExecuteNonQuery();
        }

        public static void TrocarSenha(string login, string novaSenha)
        {
            using var con = BancoSQLite.GetConnection();

            string hash = PasswordManager.HashPassword(novaSenha, out string salt);

            string query = @"UPDATE Usuarios SET SenhaHash = @senha, Salt = @salt WHERE Login = @login";
            using var cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@senha", hash);
            cmd.Parameters.AddWithValue("@salt", salt);
            cmd.Parameters.AddWithValue("@login", login);

            cmd.ExecuteNonQuery();
        }
        public static bool TentarLogin(string usuario, string senha, out string mensagemErro, out bool isFirstLogin)
        {
            isFirstLogin = false;
            mensagemErro = "";

            using var con = BancoSQLite.GetConnection();
            string query = "SELECT SenhaHash, Salt FROM Usuarios WHERE Login = @login";
            using var cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@login", usuario);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                mensagemErro = "Usuário não encontrado.";
                return false;
            }

            string senhaHash = reader.GetString(0);
            string salt = reader.GetString(1);

            bool senhaValida = PasswordManager.VerifyPassword(senha, senhaHash, salt);

            if (!senhaValida)
            {
                mensagemErro = "Senha incorreta.";
                return false;
            }

            if (usuario.ToLower() == "admin" && senha == "Auto@Admin")
            {
                isFirstLogin = true;
            }

            return true;
        }
    }
}
