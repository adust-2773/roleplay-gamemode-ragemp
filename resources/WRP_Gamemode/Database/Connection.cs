namespace WRP_Gamemode
{
    public class Connection
    {
        public string ConnectionString;

        private string Host { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private string Database { get; set; }

        public Connection()
        {
            Host = "localhost";
            User = "root";
            Password = "";
            Database = "ragemp";

            ConnectionString = $"server={Host};user={User};database={Database};password={Password};port=3306";
        } 
    }
}
