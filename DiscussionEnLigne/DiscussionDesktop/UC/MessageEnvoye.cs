using System;
using System.Windows.Forms;

namespace DiscussionDesktop.UC
{
    public partial class MessageEnvoye : UserControl
    {
        string Receivers;
        string Msg;
        public string Date;

        public MessageEnvoye(string receivers, string msg, string date)
        {
            InitializeComponent();
            Receivers = receivers;
            Msg = msg;
            Date = date;
            receiversTxt.Text += Receivers;
            msgTxt.Text = Msg;
            dateTxt.Text = Date;
        }

        private void msgTxt_Resize(object sender, EventArgs e)
        {
            this.Height = msgTxt.Height+52;
        }
    }
}
