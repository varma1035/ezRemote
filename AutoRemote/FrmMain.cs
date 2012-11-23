using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AutoRemote.BAL;
using System.Text.RegularExpressions;
using AutoRemote.View;
using MSTSCLib;

namespace AutoRemote
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Name = "FrmMain";
        }

        private void lbladd_Click(object sender, EventArgs e)
        {
            FrmRemote f = new FrmRemote();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] tmp2 = { f.txtip.Text, f.txttitle.Text, f.txtuser.Text };
                dg.Rows.Add(tmp2);
                dg.Rows[dg.Rows.Count - 1].Tag = f.rfile;
                dg.Rows[dg.Rows.Count - 1].Cells[0].Tag = f.txtpass.Text;
                dg.Rows[dg.Rows.Count - 1].Cells[1].Tag = f.txtdescription.Text;
                RemoteMachine.list.Add(new RemoteMachine(f.txtip.Text, f.txttitle.Text, f.txtuser.Text, f.txtpass.Text, f.txtdescription.Text, f.rfile));
            }
            f.Dispose();
        }

        private void ListRemoteMachine()
        {
            try
            {
                RemoteMachine.list.Clear();
                dg.Rows.Clear();
                if (Directory.Exists(AppUtils.datapath) == false)
                {
                    Directory.CreateDirectory(AppUtils.datapath);
                }
                DirectoryInfo dir = new DirectoryInfo(AppUtils.datapath);
                FileInfo[] rf = dir.GetFiles();

                for (int i = 0; i <= rf.Length - 1; i++)
                {
                    if (Path.GetExtension(rf[i].FullName) == ".rmt")
                    {
                        string str = File.ReadAllText(rf[i].FullName);
                        string strnew = Crypto.Decrypt(str);
                        string[] tmp = Regex.Split(strnew, "<<<<999999<<<<");
                        string[] tmp2 = { tmp[0], tmp[1], tmp[2] };
                        dg.Rows.Add(tmp2);
                        dg.Rows[dg.Rows.Count - 1].Tag = rf[i].FullName;
                        dg.Rows[dg.Rows.Count - 1].Cells[0].Tag = tmp[3];
                        dg.Rows[dg.Rows.Count - 1].Cells[1].Tag = tmp[4];
                        RemoteMachine.list.Add(new RemoteMachine(tmp[0], tmp[1], tmp[2], tmp[4], tmp[5], rf[i].FullName));
                    }
                }
            }
            catch (System.Exception ex)
            {
                AppUtils.Error(ex.ToString());
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ListRemoteMachine();
        }

        public void ManageTabs(string ip, string title, string username, string password)
        {
            try
            {
                for (int i = 0; i <= tab1.TabPages.Count - 1; i++)
                {
                    if (tab1.TabPages[i].Tag == ip)
                    {
                        tab1.TabPages[i].Select();
                        tab1.SelectedTab = tab1.TabPages[i];
                        return;
                    }
                }

                TabPage page = new TabPage();
                CtlRemote remote = new CtlRemote();
                page.Tag = ip;
                page.ImageIndex = 0;
                tab1.TabPages.Add(page);
                page.Text = title + "[" + ip + "]";
                remote.lblname.Text = title + "[" + ip + "]";
                page.Controls.Add(remote);
                remote.Visible = true;
                remote.Dock = DockStyle.Fill;
                tab1.TabPages[tab1.TabPages.Count - 1].Select();
                tab1.SelectedTab = page;
                remote.remote1.Server = ip;
                remote.remote1.UserName = username;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)remote.remote1.GetOcx();
                secured.ClearTextPassword = password;
                remote.remote1.Connect();
                remote.username = username;
                remote.password = password;
                remote.ip = ip;
                
            }
            catch (System.Exception ex)
            {
                AppUtils.Error(ex.ToString());
            }
        }

        private void dg_DoubleClick(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                ManageTabs(dg.SelectedRows[0].Cells[0].Value.ToString(), dg.SelectedRows[0].Cells[1].Value.ToString(), dg.SelectedRows[0].Cells[2].Value.ToString(), dg.SelectedRows[0].Cells[0].Tag.ToString());
            }
        }

        private void dg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                dg.SelectedRows[0].Selected = false;
            }
        }

        private void menuedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg.SelectedRows.Count > 0)
                {
                    FrmRemote f = new FrmRemote();
                    f.txtip.Text = dg.SelectedRows[0].Cells[0].Value.ToString();
                    f.txttitle.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
                    f.txtuser.Text = dg.SelectedRows[0].Cells[2].Value.ToString();
                    f.txtpass.Text = dg.SelectedRows[0].Cells[0].Tag.ToString();
                    f.txtdescription.Text = dg.SelectedRows[0].Cells[1].Tag.ToString();
                    f.rfile = dg.SelectedRows[0].Tag.ToString();
                    if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        dg.SelectedRows[0].Cells[0].Value = f.txtip.Text;
                        dg.SelectedRows[0].Cells[1].Value = f.txttitle.Text;
                        dg.SelectedRows[0].Cells[2].Value = f.txtuser.Text;
                        dg.SelectedRows[0].Cells[0].Tag = f.txtpass.Text;
                        dg.SelectedRows[0].Cells[1].Tag = f.txtdescription.Text;
                    }
                    f.Dispose();
                }
                else
                {
                    MessageBox.Show("Please select any remote computer.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                AppUtils.Error(ex.ToString());
            }
        }

        private void menudelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(dg.SelectedRows[0].Tag.ToString());
                        dg.Rows.RemoveAt(dg.SelectedRows[0].Index);
                    }
                }
                else
                {
                    MessageBox.Show("Please select any remote computer.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                AppUtils.Error(ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.ShowDialog();
            f.Dispose();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                ListRemoteMachine();
            }
            else
            {
                dg.Rows.Clear();
                List<RemoteMachine> list = RemoteMachine.GetList(txtsearch.Text);
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    if (Path.GetExtension(list[i].FilePath) == ".rmt")
                    {
                        string[] tmp2 = { list[i].IP, list[i].Title, list[i].Username };
                        dg.Rows.Add(tmp2);
                        dg.Rows[dg.Rows.Count - 1].Tag = list[i].FilePath;
                        dg.Rows[dg.Rows.Count - 1].Cells[0].Tag = list[i].Password;
                        dg.Rows[dg.Rows.Count - 1].Cells[1].Tag = list[i].Description;
                    }
                }
            }
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dg_DoubleClick(sender, e);
            }
        }
    }
}
