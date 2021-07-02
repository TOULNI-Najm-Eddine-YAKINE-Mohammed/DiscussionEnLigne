using System;

namespace DiscussionDesktop.Model
{
    class Message
    {
        public int Id { get; set; }
        public string Msg { get; set; }
        public DateTime Date { get; set; }
        public int Id_sender { get; set; }
        public int Id_receiver { get; set; }

        public Message(int id, string msg, DateTime date, int id_sender, int id_receiver)
        {
            Id = id;
            Msg = msg;
            Date = date;
            Id_sender = id_sender;
            Id_receiver = id_receiver;
        }
    }
}
