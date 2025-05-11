namespace Salomao
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Verifica e cria o banco de dados se não existir
            BancoSQLite.CheckAndCreateDB();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Login login = new Login();
            login.Show();

            Application.Run();
        }
    }
}