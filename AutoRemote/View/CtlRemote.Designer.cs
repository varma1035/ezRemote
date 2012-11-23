namespace AutoRemote.View
{
    partial class CtlRemote
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlRemote));
            this.remote1 = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pfull = new System.Windows.Forms.PictureBox();
            this.pclose = new System.Windows.Forms.PictureBox();
            this.pload = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrerror = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.remote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pload)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // remote1
            // 
            this.remote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remote1.Enabled = true;
            this.remote1.Location = new System.Drawing.Point(0, 12);
            this.remote1.Name = "remote1";
            this.remote1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("remote1.OcxState")));
            this.remote1.Size = new System.Drawing.Size(552, 345);
            this.remote1.TabIndex = 1;
            this.remote1.OnConnected += new System.EventHandler(this.remote1_OnConnected_1);
            this.remote1.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.remote1_OnDisconnected);
            // 
            // pfull
            // 
            this.pfull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pfull.BackColor = System.Drawing.Color.Transparent;
            this.pfull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pfull.Image = global::AutoRemote.Properties.Resources.arrow_out;
            this.pfull.Location = new System.Drawing.Point(517, 0);
            this.pfull.Name = "pfull";
            this.pfull.Size = new System.Drawing.Size(17, 11);
            this.pfull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfull.TabIndex = 3;
            this.pfull.TabStop = false;
            this.toolTip1.SetToolTip(this.pfull, "Open in full screen");
            this.pfull.Click += new System.EventHandler(this.pfull_Click);
            // 
            // pclose
            // 
            this.pclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pclose.BackColor = System.Drawing.Color.Transparent;
            this.pclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pclose.Image = global::AutoRemote.Properties.Resources.close_delete_2;
            this.pclose.Location = new System.Drawing.Point(535, -1);
            this.pclose.Name = "pclose";
            this.pclose.Size = new System.Drawing.Size(18, 13);
            this.pclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pclose.TabIndex = 2;
            this.pclose.TabStop = false;
            this.toolTip1.SetToolTip(this.pclose, "Close remote connection");
            this.pclose.Click += new System.EventHandler(this.pclose_Click);
            // 
            // pload
            // 
            this.pload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pload.BackColor = System.Drawing.Color.White;
            this.pload.Image = global::AutoRemote.Properties.Resources.loading7;
            this.pload.Location = new System.Drawing.Point(225, 45);
            this.pload.Name = "pload";
            this.pload.Size = new System.Drawing.Size(102, 101);
            this.pload.TabIndex = 0;
            this.pload.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AutoRemote.Properties.Resources.BlueBar;
            this.panel1.Controls.Add(this.pfull);
            this.panel1.Controls.Add(this.pclose);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 12);
            this.panel1.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(17, -1);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 12);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Computer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AutoRemote.Properties.Resources.computer_monitor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrerror
            // 
            this.tmrerror.Enabled = true;
            this.tmrerror.Interval = 30000;
            this.tmrerror.Tick += new System.EventHandler(this.tmrerror_Tick);
            // 
            // CtlRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pload);
            this.Controls.Add(this.remote1);
            this.Controls.Add(this.panel1);
            this.Name = "CtlRemote";
            this.Size = new System.Drawing.Size(552, 357);
            ((System.ComponentModel.ISupportInitialize)(this.remote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pload)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pfull;
        private System.Windows.Forms.PictureBox pclose;
        public System.Windows.Forms.Label lblname;
        public AxMSTSCLib.AxMsTscAxNotSafeForScripting remote1;
        private System.Windows.Forms.PictureBox pload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmrerror;
    }
}
