using GTANetworkAPI;
using MySql.Data.MySqlClient;

namespace WRP_Gamemode
{
    public class AccountService : Script
    {
        private readonly Connection connection = new Connection();
        private readonly MySqlConnection con;

        public AccountService()
        {
            con = new MySqlConnection(connection.ConnectionString);
        }

        public bool CheckAccountData(string username, string password)
        {
            string pass = default(string);

            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT password FROM accounts WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pass = reader.GetString("password");
            }

            reader.Close();
            cmd.Dispose();
            con.Close();

            if (pass != password)
            {
                NAPI.Util.ConsoleOutput($"[W-RP] --> Nieudana próba zalogowania się na konto {username}");
                return false;
            }
            return true;
        }

        public bool RegisterValidate(string username, string password, string password2)
        {
            if (username.Length > 3)
            {
                return false;
            }

            if (password != password2)
            {
                return false;
            }

            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO accounts (id, username, password, admin_level) VALUES('NULL', '@username', '@password', 0)";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            return true;
        }
    }
}
