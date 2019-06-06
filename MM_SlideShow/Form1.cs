using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FullScreenMode;

namespace MM_SlideShow
{
    public partial class Form1 : Form
    {
        SlideShowProcess SSP = new SlideShowProcess();
        FullScreen FS;
        bool FullScreen = false;
        Graphics g;
        Form Temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                TXTDirectory.Text = FBD.SelectedPath;
                SSP.RootDirectory = TXTDirectory.Text;
                SSP.Width = PBDataShow.Width;
                SSP.Height = PBDataShow.Height;
                SSP.Draw(PBDataShow,LBPictures,g);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SSP != null)
                SSP.Dispose();
        }

        private void CBStop_CheckedChanged(object sender, EventArgs e)
        {
            if(SSP!=null)
            {
                if (SSP.StopONFinish)
                    SSP.StopONFinish = false;
                else
                    SSP.StopONFinish = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (SSP != null)
                SSP.WaitTime = NUDWaitTime.Value;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (!FullScreen)
            {
                if (Temp.IsDisposed)
                {
                    Temp = new Form();
                    Temp.CreateControl();
                    Temp.WindowState = FormWindowState.Maximized;
                    Temp.KeyUp += new KeyEventHandler(Form1_KeyUp);
                    Temp.BackColor = Color.Black;
                    g = Temp.CreateGraphics();
                    //g.DrawImage(PBDataShow.Image, new Point(0, 0));
                    //g.ScaleTransform(1.2f, 1.2f);
                    FS = new FullScreen(Temp);
                }
                SSP.Fullscreen = true;
                FS.ShowFullScreen();     
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerAbout.Start();
            Temp = new Form();
            Temp.WindowState = FormWindowState.Maximized;
            Temp.KeyUp += new KeyEventHandler(Form1_KeyUp);
            Temp.BackColor = Color.Black;
            Temp.ShowInTaskbar = false;
            Temp.FormBorderStyle = FormBorderStyle.None;
            g = Temp.CreateGraphics();
            //g.DrawImage(PBDataShow.Image, new Point(0, 0));
            //g.ScaleTransform(1.2f, 1.2f);
            FS = new FullScreen(Temp);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Temp.Hide();
                FS.ResetTaskBar();
                SSP.Fullscreen = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PBDataShow.Image = null;
            SSP = new SlideShowProcess();
            SSP.RootDirectory = TXTDirectory.Text;
            SSP.Width = PBDataShow.Width;
            SSP.Height = PBDataShow.Height;
            SSP.Draw(PBDataShow, LBPictures, g);
        }

        private void btnGIFBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "(*.GIF)|*.GIF";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TXTGIFDirectory.Text = OFD.FileName;
                PBDataShow.Image = new System.Drawing.Bitmap(OFD.FileName);
                GIF G = new GIF(OFD.FileName);
                if (G.GetImage() != null)
                {
                    int X = 0, Y = 0;
                    LblKind.Text = G.ImageKind;
                    LblSWidth.Text =  G.ScreenWidth + " px";
                    LblSHeight.Text = G.ScreenHeight + " px";
                    int Var = 50;
                    if (G.GlobalPalette.Length == 256)
                        Var = 12;
                    if (G.GlobalPalette.Length == 128)
                        Var = 20;
                    if (G.GlobalPalette.Length == 64)
                        Var = 30;
                    if (G.GlobalPalette.Length == 32)
                        Var = 35;
                    PanelPalette.Controls.Clear();
                    for (int i = 0; i < G.GlobalPalette.Length; i++)
                    {
                        Panel p = new Panel();
                        p.Location = new Point(X, Y);
                        p.Size = new Size(Var, Var);
                        p.BorderStyle = BorderStyle.Fixed3D;
                        if (X + 2*Var >= PanelPalette.Size.Width)
                        {
                            X = 0;
                            Y += Var;
                        }
                        else
                            X += Var;
                        GIF.Color C = new GIF.Color();
                        C = G.GlobalPalette[i];
                        p.BackColor = Color.FromArgb(C.Red, C.Green, C.Blue);
                        PanelPalette.Controls.Add(p);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TimerClose.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
        }

        string Data = "Designed By VEGA..";
        int Counter = 0;

        private void TimerAbout_Tick(object sender, EventArgs e)
        {
            if (Counter < Data.Length)
            {
                LblAbout.Text += Data[Counter];
                Counter++;
            }
            else
                if (Counter == 27)
                {
                    LblAbout.Text = "";
                    Counter = 0;
                }
                else
                    Counter++;
        }

        bool Flag = false;

        private void btnToggleGIF_Click(object sender, EventArgs e)
        {
            TimerToggle.Start();
        }

        private void TimerToggle_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width < 1105 && !Flag)
            {
                this.Size = new Size(this.Size.Width + 5, this.Size.Height);
                this.Location = new Point(this.Location.X-3,this.Location.Y);
                if (this.Size.Width >= 1105)
                {
                    Flag = true;
                    btnToggleGIF.Text = "<<";
                    TimerToggle.Stop();
                }
            }
            if (Flag)
            {
                this.Size = new Size(this.Size.Width - 5, this.Size.Height);
                this.Location = new Point(this.Location.X + 3, this.Location.Y);
                if (this.Size.Width <= 853)
                {
                    Flag = false;
                    btnToggleGIF.Text = ">>";
                    TimerToggle.Stop();
                }
            }
        }

        int COunter2 = 0;
        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if (this.Size.Height > 50)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height - 5);
            }
            else
                if (COunter2 == 200)
                    Application.Exit();
                else
                    COunter2++;
        }
    }
}
