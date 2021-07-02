using System;
using System.Windows.Forms;

namespace DiscussionDesktop.UC
{
    public partial class MessageRecu : UserControl
    {
        string Receivers;
        string Sender;
        string Msg;
        public string Date;

        public MessageRecu(string receivers, string sender, string msg, string date)
        {
            InitializeComponent();
            Sender = sender;
            Msg = msg;
            Date = date;
            Receivers = receivers;
            receiversTxt.Text += Receivers;
            senderTxt.Text += Sender;
            msgTxt.Text = Msg;
            dateTxt.Text = Date;
        }

        private void msgTxt_Resize(object sender, EventArgs e)
        {
            this.Height = msgTxt.Height + 78;
        }
    }
}
