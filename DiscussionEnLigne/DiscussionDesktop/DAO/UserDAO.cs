using DiscussionDesktop.Model;
using System.Collections.Generic;
using System.Data;
using db = Npgsql;

namespace DiscussionDesktop.DAO
{
    class UserDAO
    {
        private db.NpgsqlCommand cmd;
        private db.NpgsqlDataAdapter ada;

        public void add(User u)
        {
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "insert into public.user (pseudo) values ('" + u.Pseudo + "')",
                Connection.getConnection()
            );
            cmd.ExecuteNonQuery();
            Connection.getConnection().Close();
        }

        public User getByPseudo(string pseudo)
        {
            List<User> list = new List<User>();
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "select * from public.user where pseudo = '" + pseudo + "'", 
                Connection.getConnection()
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Connection.getConnection().Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new User((int)row["id"], (string)row["pseudo"]));
            }
            if (list.Count != 0)
                return list[0];
            return null;
        }

        public User getById(int id)
        {
            List<User> list = new List<User>();
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "select * from public.user where id = '" + id + "'",
                Connection.getConnection()
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Connection.getConnection().Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new User((int)row["id"], (string)row["pseudo"]));
            }
            if (list.Count != 0)
                return list[0];
            return null;
        }

    }
}
