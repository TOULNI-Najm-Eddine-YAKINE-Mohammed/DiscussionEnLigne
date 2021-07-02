using db=Npgsql;

namespace DiscussionDesktop.DAO
{
    class Connection
    {
        private static db.NpgsqlConnection Cnx { get; set; }

        public static db.NpgsqlConnection getConnection()
        {
            string cnxStr = "" +
                "Server=127.0.0.1;" +
                "Port=5432;" +
                "Database=discussion;" +
                "User Id=postgres;" +
                "Password=yakine;";
            if (Cnx == null)
                Cnx = new db.NpgsqlConnection(cnxStr);
            return Cnx;
        }
    }
}
