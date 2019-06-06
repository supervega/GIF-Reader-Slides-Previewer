using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace MM_SlideShow
{
    public class SlideShowProcess
    {
        private string rootdirectory;
        private ArrayList BitmapPic;
        public bool Play_BackWard;
        private PictureBox PB;
        private int width,height;
        private Thread t1;
        private bool StopOnFinish;
        private ListBox LB;
        private decimal waittime;
        private Graphics g;
        private int tempHeight, tempWidth;
        private delegate void MainDraw();
        private bool fullscreen;

        public string RootDirectory
        {
            get { return rootdirectory; }
            set { rootdirectory = value; }
        }

        public int Height
        {
            set { height = value; }
        }

        public int Width
        {
            set { width = value; }
        }

        public bool StopONFinish
        {
            set { StopOnFinish = value; }
            get { return StopOnFinish; }
        }

        public decimal WaitTime
        {
            set { waittime = value; }
        }

        public SlideShowProcess()
        {
            rootdirectory = "";
            Play_BackWard = false;
            StopOnFinish = false;
            waittime = 2000;
            BitmapPic=new ArrayList();
        }

        private void GetImagesNames()
        {
            try
            {
                string[] Files = Directory.GetFiles(rootdirectory);
                for (int i = 0; i < Files.Length; i++)
                {
                    string Extension = Files[i].Substring(Files[i].Length - 3, 3);
                    switch (Extension.ToLower())
                    {
                        case "jpg": BitmapPic.Add(Files[i]);
                            LB.Items.Add(Files[i]);
                            break;
                        case "bmp": BitmapPic.Add(Files[i]);
                            LB.Items.Add(Files[i]);
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                ;
            }
        }

        public bool Fullscreen
        {
            get { return fullscreen; }
            set { fullscreen = value; }
        }

        private void DrawImages()
        {
            while (!StopOnFinish)
            {
                for (int i = 0; i < BitmapPic.Count; i++)
                {
                    Bitmap B = new Bitmap(BitmapPic[i].ToString());
                    B = new Bitmap(B, width, height);
                    if (!fullscreen)
                        PB.Image = B;
                    else
                    {
                        double x = tempWidth / 2 - (B.Width / 2) ;
                        double y = tempHeight / 2 - (B.Height / 2) ;
                        g.Clear(Color.Black);
                        g.DrawImage(B, new Point((int)x,(int) y));
                    }
                    //LB.SelectedIndex = i;
                    Thread.Sleep((int)waittime);
                }
            }
        }


        public void Draw(PictureBox gs,ListBox ll,Graphics gg)
        {
            PB = gs;
            LB = ll;
            g = gg;
            ll.Items.Clear();
            Screen Srn = Screen.PrimaryScreen;
            tempHeight = Srn.Bounds.Height;
            tempWidth = Srn.Bounds.Width;
            GetImagesNames();            
            t1 = new Thread(new ThreadStart(GO));
            t1.Start();
        }

        private void GO()
        {
            try
            {
                MainDraw D = new MainDraw(DrawImages);
                D.Invoke();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void Dispose()
        {
            if (t1 != null)
                t1.Abort();
        }
    }
}
