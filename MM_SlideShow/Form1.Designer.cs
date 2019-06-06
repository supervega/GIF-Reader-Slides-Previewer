namespace MM_SlideShow
{
    partial class Form1
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
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDWaitTime = new System.Windows.Forms.NumericUpDown();
            this.CBStop = new System.Windows.Forms.CheckBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.LblPictures = new System.Windows.Forms.Label();
            this.LBPictures = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.TXTDirectory = new System.Windows.Forms.TextBox();
            this.LblBrowse = new System.Windows.Forms.Label();
            this.PBDataShow = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSHeight = new System.Windows.Forms.Label();
            this.LblSWidth = new System.Windows.Forms.Label();
            this.LblKind = new System.Windows.Forms.Label();
            this.LblImageKind = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.PanelPalette = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGIFBrowser = new System.Windows.Forms.Button();
            this.TXTGIFDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.LblAbout = new System.Windows.Forms.Label();
            this.TimerAbout = new System.Windows.Forms.Timer(this.components);
            this.btnToggleGIF = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerToggle = new System.Windows.Forms.Timer(this.components);
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDataShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGroupBox.Controls.Add(this.btnPlay);
            this.SettingsGroupBox.Controls.Add(this.label2);
            this.SettingsGroupBox.Controls.Add(this.label1);
            this.SettingsGroupBox.Controls.Add(this.NUDWaitTime);
            this.SettingsGroupBox.Controls.Add(this.CBStop);
            this.SettingsGroupBox.Controls.Add(this.btnToggle);
            this.SettingsGroupBox.Controls.Add(this.LblPictures);
            this.SettingsGroupBox.Controls.Add(this.LBPictures);
            this.SettingsGroupBox.Controls.Add(this.btnBrowse);
            this.SettingsGroupBox.Controls.Add(this.TXTDirectory);
            this.SettingsGroupBox.Controls.Add(this.LblBrowse);
            this.SettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 48);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(200, 366);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(55, 328);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 32);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.toolTip1.SetToolTip(this.btnPlay, "Play Your Slide Show");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "WaitTime :";
            // 
            // NUDWaitTime
            // 
            this.NUDWaitTime.Location = new System.Drawing.Point(88, 287);
            this.NUDWaitTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDWaitTime.Name = "NUDWaitTime";
            this.NUDWaitTime.Size = new System.Drawing.Size(68, 20);
            this.NUDWaitTime.TabIndex = 7;
            this.NUDWaitTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDWaitTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CBStop
            // 
            this.CBStop.AutoSize = true;
            this.CBStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBStop.Location = new System.Drawing.Point(9, 251);
            this.CBStop.Name = "CBStop";
            this.CBStop.Size = new System.Drawing.Size(107, 17);
            this.CBStop.TabIndex = 6;
            this.CBStop.Text = "Stop on Finish";
            this.CBStop.UseVisualStyleBackColor = true;
            this.CBStop.CheckedChanged += new System.EventHandler(this.CBStop_CheckedChanged);
            // 
            // btnToggle
            // 
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(9, 222);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(185, 23);
            this.btnToggle.TabIndex = 5;
            this.btnToggle.Text = "Full Screen Mode";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // LblPictures
            // 
            this.LblPictures.AutoSize = true;
            this.LblPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPictures.Location = new System.Drawing.Point(6, 66);
            this.LblPictures.Name = "LblPictures";
            this.LblPictures.Size = new System.Drawing.Size(61, 13);
            this.LblPictures.TabIndex = 4;
            this.LblPictures.Text = "Pictures :";
            // 
            // LBPictures
            // 
            this.LBPictures.FormattingEnabled = true;
            this.LBPictures.Location = new System.Drawing.Point(9, 82);
            this.LBPictures.Name = "LBPictures";
            this.LBPictures.Size = new System.Drawing.Size(185, 134);
            this.LBPictures.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(170, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.toolTip1.SetToolTip(this.btnBrowse, "Set Images Directory");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // TXTDirectory
            // 
            this.TXTDirectory.Location = new System.Drawing.Point(68, 24);
            this.TXTDirectory.Name = "TXTDirectory";
            this.TXTDirectory.Size = new System.Drawing.Size(110, 20);
            this.TXTDirectory.TabIndex = 1;
            // 
            // LblBrowse
            // 
            this.LblBrowse.AutoSize = true;
            this.LblBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrowse.Location = new System.Drawing.Point(6, 27);
            this.LblBrowse.Name = "LblBrowse";
            this.LblBrowse.Size = new System.Drawing.Size(56, 13);
            this.LblBrowse.TabIndex = 0;
            this.LblBrowse.Text = "Browse :";
            // 
            // PBDataShow
            // 
            this.PBDataShow.BackColor = System.Drawing.Color.Black;
            this.PBDataShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBDataShow.Location = new System.Drawing.Point(239, 48);
            this.PBDataShow.Name = "PBDataShow";
            this.PBDataShow.Size = new System.Drawing.Size(583, 366);
            this.PBDataShow.TabIndex = 1;
            this.PBDataShow.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LblSHeight);
            this.groupBox1.Controls.Add(this.LblSWidth);
            this.groupBox1.Controls.Add(this.LblKind);
            this.groupBox1.Controls.Add(this.LblImageKind);
            this.groupBox1.Controls.Add(this.LblHeight);
            this.groupBox1.Controls.Add(this.LblWidth);
            this.groupBox1.Controls.Add(this.PanelPalette);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGIFBrowser);
            this.groupBox1.Controls.Add(this.TXTGIFDirectory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(851, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GIF Section";
            // 
            // LblSHeight
            // 
            this.LblSHeight.AutoSize = true;
            this.LblSHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSHeight.ForeColor = System.Drawing.Color.Red;
            this.LblSHeight.Location = new System.Drawing.Point(112, 341);
            this.LblSHeight.Name = "LblSHeight";
            this.LblSHeight.Size = new System.Drawing.Size(0, 13);
            this.LblSHeight.TabIndex = 13;
            // 
            // LblSWidth
            // 
            this.LblSWidth.AutoSize = true;
            this.LblSWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSWidth.ForeColor = System.Drawing.Color.Red;
            this.LblSWidth.Location = new System.Drawing.Point(112, 314);
            this.LblSWidth.Name = "LblSWidth";
            this.LblSWidth.Size = new System.Drawing.Size(0, 13);
            this.LblSWidth.TabIndex = 12;
            // 
            // LblKind
            // 
            this.LblKind.AutoSize = true;
            this.LblKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKind.ForeColor = System.Drawing.Color.Red;
            this.LblKind.Location = new System.Drawing.Point(98, 287);
            this.LblKind.Name = "LblKind";
            this.LblKind.Size = new System.Drawing.Size(0, 13);
            this.LblKind.TabIndex = 11;
            // 
            // LblImageKind
            // 
            this.LblImageKind.AutoSize = true;
            this.LblImageKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImageKind.Location = new System.Drawing.Point(14, 287);
            this.LblImageKind.Name = "LblImageKind";
            this.LblImageKind.Size = new System.Drawing.Size(78, 13);
            this.LblImageKind.TabIndex = 10;
            this.LblImageKind.Text = "Image Kind :";
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeight.Location = new System.Drawing.Point(14, 342);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(96, 13);
            this.LblHeight.TabIndex = 9;
            this.LblHeight.Text = "Screen Height :";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWidth.ForeColor = System.Drawing.Color.Black;
            this.LblWidth.Location = new System.Drawing.Point(14, 314);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(92, 13);
            this.LblWidth.TabIndex = 8;
            this.LblWidth.Text = "Screen Width :";
            // 
            // PanelPalette
            // 
            this.PanelPalette.Location = new System.Drawing.Point(6, 82);
            this.PanelPalette.Name = "PanelPalette";
            this.PanelPalette.Size = new System.Drawing.Size(230, 202);
            this.PanelPalette.TabIndex = 7;
            this.toolTip1.SetToolTip(this.PanelPalette, "Global Color Palette");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Palette :";
            // 
            // btnGIFBrowser
            // 
            this.btnGIFBrowser.Location = new System.Drawing.Point(212, 25);
            this.btnGIFBrowser.Name = "btnGIFBrowser";
            this.btnGIFBrowser.Size = new System.Drawing.Size(24, 23);
            this.btnGIFBrowser.TabIndex = 5;
            this.btnGIFBrowser.Text = "...";
            this.toolTip1.SetToolTip(this.btnGIFBrowser, "Browse For Your GIF File");
            this.btnGIFBrowser.UseVisualStyleBackColor = true;
            this.btnGIFBrowser.Click += new System.EventHandler(this.btnGIFBrowser_Click);
            // 
            // TXTGIFDirectory
            // 
            this.TXTGIFDirectory.Location = new System.Drawing.Point(76, 27);
            this.TXTGIFDirectory.Name = "TXTGIFDirectory";
            this.TXTGIFDirectory.Size = new System.Drawing.Size(140, 20);
            this.TXTGIFDirectory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Browse :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(771, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 24);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.BackColor = System.Drawing.Color.Transparent;
            this.LblAbout.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbout.ForeColor = System.Drawing.Color.Red;
            this.LblAbout.Location = new System.Drawing.Point(242, 9);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(0, 21);
            this.LblAbout.TabIndex = 15;
            this.toolTip1.SetToolTip(this.LblAbout, "Mohamad Ammar Al-Azem");
            // 
            // TimerAbout
            // 
            this.TimerAbout.Tick += new System.EventHandler(this.TimerAbout_Tick);
            // 
            // btnToggleGIF
            // 
            this.btnToggleGIF.Location = new System.Drawing.Point(819, 217);
            this.btnToggleGIF.Name = "btnToggleGIF";
            this.btnToggleGIF.Size = new System.Drawing.Size(30, 38);
            this.btnToggleGIF.TabIndex = 17;
            this.btnToggleGIF.Text = ">>";
            this.toolTip1.SetToolTip(this.btnToggleGIF, "GIF HomeWork");
            this.btnToggleGIF.UseVisualStyleBackColor = true;
            this.btnToggleGIF.Click += new System.EventHandler(this.btnToggleGIF_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // TimerToggle
            // 
            this.TimerToggle.Interval = 1;
            this.TimerToggle.Tick += new System.EventHandler(this.TimerToggle_Tick);
            // 
            // TimerClose
            // 
            this.TimerClose.Interval = 1;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(851, 426);
            this.Controls.Add(this.btnToggleGIF);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PBDataShow);
            this.Controls.Add(this.SettingsGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiMedia Slide Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDataShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox TXTDirectory;
        private System.Windows.Forms.Label LblBrowse;
        private System.Windows.Forms.PictureBox PBDataShow;
        private System.Windows.Forms.Label LblPictures;
        private System.Windows.Forms.ListBox LBPictures;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.CheckBox CBStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDWaitTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelPalette;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGIFBrowser;
        private System.Windows.Forms.TextBox TXTGIFDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LblImageKind;
        private System.Windows.Forms.Label LblSHeight;
        private System.Windows.Forms.Label LblSWidth;
        private System.Windows.Forms.Label LblKind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.Timer TimerAbout;
        private System.Windows.Forms.Button btnToggleGIF;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer TimerToggle;
        private System.Windows.Forms.Timer TimerClose;
    }
}

