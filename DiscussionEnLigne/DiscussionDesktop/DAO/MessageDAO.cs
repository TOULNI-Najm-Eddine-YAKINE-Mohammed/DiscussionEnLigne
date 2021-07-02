using DiscussionDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using db = Npgsql;

namespace DiscussionDesktop.DAO
{
    class MessageDAO
    {
        private db.NpgsqlCommand cmd;
        private db.NpgsqlDataAdapter ada;

        public void add(Message m)
        {
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "insert into message (msg,date,id_sender,id_receiver) values ('" 
                + m.Msg + "', '"+m.Date+ "', '" + m.Id_sender + "', '" + m.Id_receiver + "')",
                Connection.getConnection()
            );
            cmd.ExecuteNonQuery();
            Connection.getConnection().Close();
        }

        public List<Message> getMessages(int myId)
        {
            List<Message> list = new List<Message>();
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "select * from message where id_sender = '" +
                myId + "' or id_receiver = '" + myId + "' order by date asc",
                Connection.getConnection()
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Connection.getConnection().Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Message(
                    (int)row["id"],
                    (string)row["msg"],
                    (DateTime)row["date"],
                    (int)row["id_sender"],
                    (int)row["id_receiver"]
                ));
            }
            return list;
        }

        public String getReceivers(DateTime date)
        {
            List<String> list = new List<String>();
            Connection.getConnection().Open();
            cmd = new db.NpgsqlCommand(
                "select pseudo from public.user where id in (select id_receiver as id from message where date  = '" + date + "')",
                Connection.getConnection()
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Connection.getConnection().Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add((string)row["pseudo"]);
            }
            string s = "";
            foreach (string item in list)
            {
                s += item+" ";
            }
            return s ;
        }
    }
}
