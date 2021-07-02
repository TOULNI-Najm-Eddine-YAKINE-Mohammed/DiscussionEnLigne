using DiscussionDesktop.DAO;
using DiscussionDesktop.Forms;
using DiscussionDesktop.srv;
using DiscussionDesktop.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiscussionDesktop
{
    public partial class FormApp : Form
    {
        FormParticipation fp;
        Timer timer;
        srv.wsChatSoapClient srvCli = new srv.wsChatSoapClient();
        private static CheckBox chTout;
        private static CheckBox chAucun;
        UserDAO userDAO;
        MessageDAO messageDAO;
        bool loggedIn = false;

        public FormApp()
        {
            InitializeComponent();
            userDAO = new UserDAO();
            messageDAO = new MessageDAO();
            chTout = chkbxTout;
            chAucun = chkbxAucun;

            srvCli.dropUserCompleted += dropUserSrv;
            srvCli.getAllUsersCompleted += allUsersSrv;
        }

        private void allUsersSrv(object sender, getAllUsersCompletedEventArgs e)
        {
            try
            {
                List<Control> l = new List<Control>();
                foreach (Control item in layoutUsers.Controls)
                {
                    if (!(item is Panel) && loggedOut((ConnectedUser)item, e.Result))
                        l.Add(item);
                }
                foreach (Control item in l)
                {
                    layoutUsers.Controls.Remove(item);
                }
                foreach (srv.User u in e.Result)
                {
                    if (u.Pseudo != fp.pseudo)
                    {
                        ConnectedUser c = new ConnectedUser(u.Pseudo);
                        c.Width = layoutUsers.Width - 6;
                        int i = 0;
                        foreach (Control item in layoutUsers.Controls)
                        {
                            if ((!(item is Panel) && ((ConnectedUser)item).Pseudo == u.Pseudo))
                                break;
                            i++;
                        }
                        if (i == layoutUsers.Controls.Count)
                            layoutUsers.Controls.Add(c);
                    }
                }
            }
            catch (Exception)
            {
                fp.showFirstInfo();
            }
        }

        private bool loggedOut(ConnectedUser usr, srv.User[] users)
        {
            foreach (srv.User u in users)
            {
                if (usr.Pseudo.Equals(u.Pseudo))
                    return false;
            }
            return true;
        }

        private void dropUserSrv(object sender, AsyncCompletedEventArgs e)
        {
            Application.Exit();
        }

        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 2000; // in miliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            srvCli.getAllUsersAsync();
            if(loggedIn)
                afficheMsgs();
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            InitTimer();

            layoutUsers.HorizontalScroll.Maximum = 0;
            layoutUsers.AutoScroll = false;
            layoutUsers.HorizontalScroll.Visible = false;
            layoutUsers.AutoScroll = true;

            layoutMsgs.HorizontalScroll.Maximum = 0;
            layoutMsgs.AutoScroll = false;
            layoutMsgs.HorizontalScroll.Enabled = false;
            layoutMsgs.AutoScroll = true;
        }

        private void FormApp_Shown(object sender, EventArgs e)
        {
            fp = new FormParticipation();
            fp.StartPosition = FormStartPosition.Manual;
            fp.ShowInTaskbar = false;
            fp.Location = new Point(
                this.Location.X + (this.Width / 4),
                this.Location.Y + (this.Height / 4)
            );

            srvCli.getAllUsersAsync();
            fp.ShowDialog(this);
            loggedIn = true;
            this.Text = this.Text + " (" + fp.pseudo + ")";
            btnSend.Text = "\u27A4";
        }

        private void FormApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            deconnecter();
        }

        private void btnDecon_Click(object sender, EventArgs e)
        {
            deconnecter();
        }

        private void deconnecter()
        {
            srv.User u = new srv.User();
            u.Pseudo = fp.pseudo;
            srvCli.dropUserAsync(u);
        }

        private void layoutUsers_Resize(object sender, EventArgs e)
        {
            foreach (Control c in layoutUsers.Controls)
            {
                c.Width = layoutUsers.Width - 6;
            }
            layoutUsers.HorizontalScroll.Enabled = false;
            layoutUsers.HorizontalScroll.Visible = false;
            layoutUsers.HorizontalScroll.Maximum = 0;
            layoutUsers.AutoScroll = false;
            layoutUsers.HorizontalScroll.Visible = false;
            layoutUsers.AutoScroll = true;
        }

        public static CheckBox getChkbxTout()
        {
            return chTout;
        }

        public static CheckBox getChkbxAucun()
        {
            return chAucun;
        }

        private void chkbxTout_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxTout.Checked == true)
            {
                foreach (Control item in layoutUsers.Controls)
                {
                    if (!(item is Panel))
                        ((ConnectedUser)item).chek.Checked = true;
                }
            }
        }

        private void chkbxAucun_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxAucun.Checked == true)
            {
                foreach (Control item in layoutUsers.Controls)
                {
                    if (!(item is Panel))
                        ((ConnectedUser)item).chek.Checked = false;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text.Trim() != "")
            {
                DateTime dt = DateTime.Now;
                int id_sender = userDAO.getByPseudo(fp.pseudo).Id;
                int i = 0;
                foreach (Control item in layoutUsers.Controls)
                {
                    if (!(item is Panel) && ((ConnectedUser)item).chek.Checked)
                    {
                        i = 1;
                        int id_receiver = userDAO.getByPseudo(((ConnectedUser)item).Pseudo).Id;
                        messageDAO.add(new Model.Message(0, txtMsg.Text, dt, id_sender, id_receiver));
                    }
                }
                if (i == 1)
                {
                    afficheMsgs();
                    txtMsg.Text = "";
                    ScrollToBottom(layoutMsgs);
                }
            }
        }

        private void afficheMsgs()
        {
            int myId = userDAO.getByPseudo(fp.pseudo).Id;
            foreach (Model.Message m in messageDAO.getMessages(myId))
            {
                int nbr = 0;
                foreach (Control item in layoutMsgs.Controls)
                {
                    if (item is MessageEnvoye && ((MessageEnvoye)item).Date.Equals(m.Date + ""))
                        break;
                    nbr++;
                }
                int nbr2 = 0;
                foreach (Control item in layoutMsgs.Controls)
                {
                    if (item is MessageRecu && ((MessageRecu)item).Date.Equals(m.Date + ""))
                        break;
                    nbr2++;
                }
                if (m.Id_receiver == myId && nbr2 == layoutMsgs.Controls.Count)
                {
                    MessageRecu mr = new MessageRecu(
                        messageDAO.getReceivers(m.Date),
                        userDAO.getById(m.Id_sender).Pseudo,
                        m.Msg,
                        m.Date.ToString()
                    );
                    mr.Width = layoutMsgs.Width - (int)(layoutMsgs.Width * 0.042);
                    layoutMsgs.Controls.Add(mr);
                    ScrollToBottom(layoutMsgs);
                } 
                else if(m.Id_sender == myId && nbr == layoutMsgs.Controls.Count)
                {
                    MessageEnvoye me = new MessageEnvoye(
                        messageDAO.getReceivers(m.Date),
                        m.Msg,
                        m.Date.ToString()
                    );
                    me.Width = layoutMsgs.Width - (int)(layoutMsgs.Width*0.042);
                    layoutMsgs.Controls.Add(me);
                    ScrollToBottom(layoutMsgs);
                }
            }
        }

        public void ScrollToBottom(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom })
            {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        private void layoutMsgs_Resize(object sender, EventArgs e)
        {
            foreach (Control c in layoutMsgs.Controls)
            {
                c.Width = layoutMsgs.Width - (int)(layoutMsgs.Width * 0.042);
            }
            layoutMsgs.HorizontalScroll.Enabled = false;
            layoutMsgs.HorizontalScroll.Visible = false;
        }
    }
}
