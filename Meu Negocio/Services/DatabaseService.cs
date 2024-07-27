using MySql.Data.MySqlClient;

namespace Meu_Negocio.Services
{
    internal class DatabaseService
    {

        public MySqlConnection? connection(string connectionString)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
