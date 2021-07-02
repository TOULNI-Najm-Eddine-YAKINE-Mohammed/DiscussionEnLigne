using System;
using System.Windows.Forms;

namespace DiscussionDesktop.UC
{
    public partial class ConnectedUser : UserControl
    {
        public string Pseudo = "";
        public CheckBox chek;

        public ConnectedUser(string pseudo)
        {
            InitializeComponent();
            chek = chkbx;
            Pseudo = pseudo;
            chkbx.Text = Pseudo;
        }

        private void chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx.Checked == false && FormApp.getChkbxTout().Checked == true)
                FormApp.getChkbxTout().Checked = false;
            if (chkbx.Checked == true && FormApp.getChkbxAucun().Checked == true)
                FormApp.getChkbxAucun().Checked = false;
        }
    }
}
