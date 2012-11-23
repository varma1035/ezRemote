using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace AutoRemote
{
    public partial class FrmFullScreen : Form
    {
        public string username, password, ip;
        public FrmFullScreen()
        {
            InitializeComponent();
        }

        private void FrmFullScreen_Resize(object sender, EventArgs e)
        {
            
        }

        private void FrmFullScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void remote1_OnConnected(object sender, EventArgs e)
        {
            pload.Visible = false;
        }

        private void pfull_Click(object sender, EventArgs e)
        {
            remote1.Disconnect();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void pclose_Click(object sender, EventArgs e)
        {
            remote1.Disconnect();
            this.DialogResult =System.Windows.Forms.DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remote1.Server = ip;
            remote1.UserName = username;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)remote1.GetOcx();
            secured.ClearTextPassword = password;
            remote1.Connect();
            timer1.Enabled = false;
            panel1.Visible = false;
        }
    }
}
