using System.Security.Cryptography;

namespace AutoPecas.Security
{
    public class PasswordManager
    {
        private const int SaltSize   = 16;
        private const int HashSize   = 32;
        private const int Iterations = 10000; 

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[SaltSize];
            RandomNumberGenerator.Fill(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, out string salt)
        {
            salt = GenerateSalt();
            return HashPassword(password, salt);
        }

        public static string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            string newHash = HashPassword(password, storedSalt);
            return newHash == storedHash;
        }
    }
}
