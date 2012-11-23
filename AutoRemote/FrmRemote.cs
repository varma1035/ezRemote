using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoRemote.BAL;
using System.IO;

namespace AutoRemote
{
    public partial class FrmRemote : Form
    {
        public string rfile = "";
        public FrmRemote()
        {
            InitializeComponent();
        }

        private void FrmRemote_Load(object sender, EventArgs e)
        {

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtip.Text == "")
                {
                    MessageBox.Show("Please enter ip.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtip.Focus();
                    return;
                }
                if (txttitle.Text == "")
                {
                    MessageBox.Show("Please enter title.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttitle.Focus();
                    return;
                }
                if (txtuser.Text == "")
                {
                    MessageBox.Show("Please enter user name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.Focus();
                    return;
                }

                string remote = txtip.Text + "<<<<999999<<<<" + txttitle.Text + "<<<<999999<<<<" + txtuser.Text + "<<<<999999<<<<" + txtpass.Text + "<<<<999999<<<<" + txtdescription.Text + "<<<<999999<<<<";
                string strnew = Crypto.Encrypt(remote);
                string vp = AppUtils.datapath;
                Random r = new Random();
                string vpfile = vp + @"\remote" + r.Next(1, 99999999).ToString() + ".rmt";
                if (rfile == "")
                {
                    while (File.Exists(vpfile))
                    {
                        vpfile = vp + @"\remote" + r.Next(1, 99999999).ToString() + ".rmt";
                    }
                }
                else
                {
                    vpfile = rfile;
                }
                File.WriteAllText(vpfile, strnew);
                rfile = vpfile;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (System.Exception ex)
            {
                AppUtils.Error(ex.ToString());
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
