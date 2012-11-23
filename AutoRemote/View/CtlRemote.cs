using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace AutoRemote.View
{
    public partial class CtlRemote : UserControl
    {
        bool zoom = false;
        public string username, password, ip;

        public CtlRemote()
        {
            InitializeComponent();
            //remote1.DisconnectedText = "Disconnected from remote machine, please close and reconnect";
        }

        private void remote1_OnConnected(object sender, EventArgs e)
        {
            pload.Visible = false;
        }

        private void pclose_Click(object sender, EventArgs e)
        {
            FrmMain f = (FrmMain)Application.OpenForms["FrmMain"];
            if (f != null)
            {
                if (remote1.Connected == 1)
                {
                    remote1.Disconnect();
                }
                TabPage p = (TabPage)this.Parent;
                f.tab1.TabPages.Remove(p);
                tmrerror.Enabled = false;
            }
            this.Dispose();
        }

        private void pfull_Click(object sender, EventArgs e)
        {
            FrmFullScreen f = new FrmFullScreen();
            f.username = username;
            f.password = password;
            f.ip = ip;
            zoom = true;
            remote1.Disconnect();
            f.Height = Screen.PrimaryScreen.WorkingArea.Height;
            f.Width = Screen.PrimaryScreen.WorkingArea.Width;
            f.Top = 0;
            f.Left = 0;
            if (f.ShowDialog() == DialogResult.OK)
            {
                pload.Visible = true;
                remote1.Server = ip;
                remote1.UserName = username;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)remote1.GetOcx();
                secured.ClearTextPassword = password;
                remote1.Connect();
            }
            else
            {
                pclose_Click(sender, e);
            }
            zoom = false;
        }

        private void tmrerror_Tick(object sender, EventArgs e)
        {
            if (pload.Visible)
            {
                MessageBox.Show("Remote connection could not be created. Please check for target machine IP, username and password are correct and your LAN and Internet connection is working.","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pclose_Click(sender, e);
            }
            tmrerror.Enabled = false;
        }

        private void remote1_OnConnected_1(object sender, EventArgs e)
        {
            pload.Visible = false;
        }

        private void remote1_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            if (zoom == false)
            {
                EventArgs ex = new EventArgs();
                pclose_Click(sender, ex);
            }
        }
    }
}
