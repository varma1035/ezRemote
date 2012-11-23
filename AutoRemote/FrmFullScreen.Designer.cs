namespace AutoRemote
{
    partial class FrmFullScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFullScreen));
            this.remote1 = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pfull = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.remote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfull)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pload)).BeginInit();
            this.SuspendLayout();
            // 
            // remote1
            // 
            this.remote1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.remote1.Enabled = true;
            this.remote1.Location = new System.Drawing.Point(2, 2);
            this.remote1.Name = "remote1";
            this.remote1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("remote1.OcxState")));
            this.remote1.Size = new System.Drawing.Size(537, 382);
            this.remote1.TabIndex = 2;
            this.remote1.OnConnected += new System.EventHandler(this.remote1_OnConnected);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pfull
            // 
            this.pfull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pfull.BackColor = System.Drawing.Color.Transparent;
            this.pfull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pfull.Image = global::AutoRemote.Properties.Resources.arrow_in;
            this.pfull.Location = new System.Drawing.Point(530, 3);
            this.pfull.Name = "pfull";
            this.pfull.Size = new System.Drawing.Size(9, 8);
            this.pfull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfull.TabIndex = 5;
            this.pfull.TabStop = false;
            this.toolTip1.SetToolTip(this.pfull, "Restore to tab view");
            this.pfull.Click += new System.EventHandler(this.pfull_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AutoRemote.Properties.Resources.image001;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(294, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 67);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restore from here";
            // 
            // pload
            // 
            this.pload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pload.BackColor = System.Drawing.Color.White;
            this.pload.Image = global::AutoRemote.Properties.Resources.loading7;
            this.pload.Location = new System.Drawing.Point(218, 22);
            this.pload.Name = "pload";
            this.pload.Size = new System.Drawing.Size(102, 101);
            this.pload.TabIndex = 4;
            this.pload.TabStop = false;
            // 
            // FrmFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 383);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pfull);
            this.Controls.Add(this.pload);
            this.Controls.Add(this.remote1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFullScreen";
            this.ShowInTaskbar = false;
            this.Text = "FrmFullScreen";
            this.Load += new System.EventHandler(this.FrmFullScreen_Load);
            this.Resize += new System.EventHandler(this.FrmFullScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.remote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfull)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxMSTSCLib.AxMsTscAxNotSafeForScripting remote1;
        private System.Windows.Forms.PictureBox pload;
        private System.Windows.Forms.PictureBox pfull;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}