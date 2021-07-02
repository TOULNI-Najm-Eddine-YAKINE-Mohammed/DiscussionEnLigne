using DiscussionDesktop.DAO;
using DiscussionDesktop.srv;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiscussionDesktop.Forms
{
    public partial class FormParticipation : Form
    {
        srv.wsChatSoapClient srvCli = new srv.wsChatSoapClient();
        UserDAO userDAO;
        public string pseudo;

        public FormParticipation()
        {
            InitializeComponent();
            userDAO = new UserDAO();
            srvCli.existCompleted += existSrv;
            srvCli.addUserCompleted += addUserSrv;
        }

        private void addUserSrv(object sender, AsyncCompletedEventArgs e)
        {
            this.Hide();
        }

        private void existSrv(object sender, existCompletedEventArgs e)
        {
            try
            {
                if (e.Result)
                {
                    errorProv.SetError(txtPseudo, "Pseudo déjà utilisé");
                    btnPart.Enabled = false;
                }
                else
                {
                    errorProv.Clear();
                    btnPart.Enabled = true;
                    if (txtPseudo.Text.Trim() == "")
                        btnPart.Enabled = false;
                }
            }
            catch (Exception)
            {
                showFirstInfo();
            }
        }

        private void txtPseudo_TextChanged(object sender, System.EventArgs e)
        {
            srvCli.existAsync(txtPseudo.Text);
        }

        private void FormParticipation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPart_Click(object sender, EventArgs e)
        {
            srv.User u = new srv.User();
            u.Pseudo = txtPseudo.Text;
            srvCli.addUserAsync(u);
            if (userDAO.getByPseudo(txtPseudo.Text) == null)
                userDAO.add(new Model.User(0, txtPseudo.Text));
            pseudo = txtPseudo.Text;
        }

        public void showFirstInfo()
        {
            txtPseudo.Text = "";
            txtPseudo.Enabled = false;
            btnPart.Enabled = false;
            errorProv.SetError(
                btnPart,
                "Vous devez d'abord mettre à jour la référence du web service dans :" +
                "\n DiscussionDesktop --> Connected Services --> srv"
            );
        }
    }
}
