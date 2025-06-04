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
        public static bool TentarLogin(string usuario, string senha, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using var con = BancoSQLite.GetConnection();
                var cmd = new SQLiteCommand("SELECT SenhaHash, Salt FROM Usuarios WHERE Login = @usuario", con);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                using var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    mensagemErro = "Usuário não encontrado.";
                    return false;
                }

                var hash = reader["SenhaHash"].ToString();
                var salt = reader["Salt"].ToString();

                if (!PasswordManager.VerifyPassword(senha, hash, salt))
                {
                    mensagemErro = "Senha incorreta.";
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                mensagemErro = "Erro interno na autenticação.";
                return false;
            }
        }
    }
}
