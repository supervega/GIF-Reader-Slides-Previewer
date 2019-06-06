using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Collections;

namespace MM_SlideShow
{
    public class GIF
    {
        private int Index;
        private byte[] Data;
        private string path;
        public int Width, Height;
        public int ScreenWidth, ScreenHeight;
        private int NumberofGlobalColors;
        private int BackGroundColorIndex;
        private bool UseGlobalPalette;
        public Color[] GlobalPalette;
        private ArrayList Frames;
        private Image Result;
        public string ImageKind = "";

        public struct Color
        {
            public int Red;
            public int Green;
            public int Blue;
        }

        private struct Frame
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
            public bool UseGlobalMap;
            public bool Interlaced;
            public int bitsPerpixel;
            public Color[] LocalPalette;
        }

        public GIF(string P)
        {
            UseGlobalPalette = false;
            path = P;
            Index=0;
            NumberofGlobalColors = 0;
            ScreenHeight = 0;
            ScreenWidth = 0;
            BackGroundColorIndex = 0;
            Frames = new ArrayList();
        }

        private void GetGlobalPalette()
        {
            GlobalPalette = new Color[(int)Math.Pow((double)2,(double)NumberofGlobalColors)];
            string s = "";
            for (int i = 0; i < GlobalPalette.Length; i++)
            {
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Red += GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Green += GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Blue += GetNumericalValue(s);
            }
        }
        int NumBytesPerCode = 1;
        private int ReadCode(byte reader)
        {
            int code = 0;
            int shift = 0;

            for (int i = 0; i < 255; i++)
            {
                byte nextByte = reader;
                code += nextByte << shift;
                shift += 8;
            }

            return code;
        }

        int StreamIndex = 0;
        private int ReadCode(string DataStream)
        {
            if (StreamIndex + 3 < DataStream.Length)
            {
                int REsult= Get_3bit_NumericalValue(GetBits(Convert.ToByte(DataStream.Substring(StreamIndex, 3))));
                StreamIndex += 3;
                return REsult;
            }
            else
                return 0;
        }

        int InputIndex = 0;
        private void Decompress(string input, ArrayList output)
        {
            List<string> table = new List<string>();

            for (int i = 0; i < 8; i++)
            {
                table.Add(i.ToString());
            }

            int firstCode = ReadCode(input);
            InputIndex++;
            char matchChar = char.Parse(firstCode.ToString());
            string match = matchChar.ToString();

            output.Add(match);

            while (input.Length > InputIndex)
            {
                int nextCode = ReadCode(input);
                //nextCode = Get_3bit_NumericalValue(nextCode.ToString());
                InputIndex++;

                string nextMatch;
                if (nextCode < table.Count)
                    nextMatch = table[nextCode];
                else
                    nextMatch = match + match[0];
                if (nextMatch.Length > 1)
                {
                    ;
                }
                output.Add(nextMatch);

                table.Add(match + nextMatch[0]);
                match = nextMatch;
            }        
        }
        private void Decompress(byte[] input, ArrayList output)
        {
            List<string> table = new List<string>();

            for (int i = 0; i < 256; i++)
            {
                char ch = (char)i;
                table.Add(ch.ToString());
            }

            int firstCode = ReadCode(input[InputIndex]);
            InputIndex++;
            char matchChar = (char)firstCode;
            string match = matchChar.ToString();

            output.Add(match);

            while (input.Length > InputIndex)
            {
                int nextCode = ReadCode(input[InputIndex]);
                InputIndex++;

                string nextMatch;
                if (nextCode < table.Count)
                    nextMatch = table[nextCode];
                else
                    nextMatch = match + match[0];
                if (nextMatch.Length > 1)
                {
                    ;
                }
                output.Add(nextMatch);

                table.Add(match + nextMatch[0]);
                match = nextMatch;
            }
        }

        private void GetRasterData(Frame F,Graphics g)
        {
            Index+=2;
            string s = GetBits(Data[Index]);
            int NumBytesPerCodee = 3;
            ArrayList outt = new ArrayList();
            if (Data[Index] != ',' && Data[Index] != '!' && NumBytesPerCodee > 0)
            {
                string bits = "";
                byte[] Temp = new byte[NumBytesPerCodee];
                int TEmpIndex = 0;
                do
                {
                    NumBytesPerCodee = GetNumericalValue(s);
                    Temp = new byte[NumBytesPerCodee];
                    string BytesStremData = "";
                    for (int k = 0; k < NumBytesPerCodee; k++)
                    {
                        Index++;
                        //Temp[TEmpIndex]=Data[Index];
                        //TEmpIndex++;
                        BytesStremData =GetBits(Data[Index]) + BytesStremData;
                    }
                    Index++;
                    //if(Temp.Length>0 )
                    if(Data.Length>0)
                        Decompress(BytesStremData, outt);
                    s = GetBits(Data[Index]);
                    TEmpIndex = 0;
                    InputIndex = 0;
                } while (Data[Index] != ',' && Data[Index] != '!' && NumBytesPerCodee > 0);

                int BitIndex = 0;
                int ColorIndex =0;
                int L = bits.Length;
                Bitmap B = new Bitmap(F.Width, F.Height,g);
                for (int i = 0; i < F.Width; i++)
                {
                    for (int j = 0; j < F.Height; j++)
                    {
                        if (true)//F.UseGlobalMap)
                        {
                            if (BitIndex < outt.Count)
                            {
                                ColorIndex = (byte)outt[BitIndex].ToString()[0];
                                BitIndex += 1;
                                System.Drawing.Color C = System.Drawing.Color.FromArgb(GlobalPalette[ColorIndex].Red, GlobalPalette[ColorIndex].Green, GlobalPalette[ColorIndex].Blue);
                                B.SetPixel(i, j, C);
                            }
                            //if (Data[Index] != ',' && Data[Index] != '!')
                            //{
                            //    s = GetBits(Data[Index]);
                            //    Index = GetNumericalValue(s);
                            //}
                            //else
                            //{
                            //    Result = B;
                            //    return;
                            //}
                        }
                    }
                }
                Result = B;

            }
        }

        private void GetLocalPalette(Frame F)
        {
            F.LocalPalette = new Color[(int)Math.Pow((double)2, (double)F.bitsPerpixel)];
            string s = "";
            for (int i = 0; i < Math.Pow(2, F.bitsPerpixel); i++)
            {
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Red += GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Green += GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                GlobalPalette[i].Blue += GetNumericalValue(s);
            }
        }

        private void GetImageBytes()
        {
            Data=File.ReadAllBytes(path);
        }

        private bool CheckSignature()
        {
            if (Data.Length > 6 && Data[0] == 'G' && Data[1] == 'I' && Data[2] == 'F' && Data[3] == '8' && Data[4] == '7' && Data[5] == 'a')
            {
                Index = 6;
                ImageKind = "GIF87a";
                return true;
            }
            else
                if (Data.Length > 6 && Data[0] == 'G' && Data[1] == 'I' && Data[2] == 'F' && Data[3] == '8' && Data[4] == '9' && Data[5] == 'a')
                {
                    Index = 6;
                    ImageKind = "GIF89a";
                    return true;
                }
            return false;
        }

        private bool CheckScreenDescriptor()
        {
            string s = GetBits(Data[Index]);
            //s = Flip(s);
            ScreenWidth = GetNumericalValue(s);
            Index++;
            s = GetBits(Data[Index]);
            //s = Flip(s);
            ScreenWidth += GetNumericalValue(s);
            Index++;
            s = GetBits(Data[Index]);
            //s = Flip(s);
            ScreenHeight = GetNumericalValue(s);
            Index++;
            s = GetBits(Data[Index]);
            //s = Flip(s);
            ScreenHeight += GetNumericalValue(s);
            Index++;
            s = GetBits(Data[Index]);
            if (s[0] == '1')
            {
                UseGlobalPalette = true;
                s = GetBits(Data[Index]);
                NumberofGlobalColors = Get_3bit_NumericalValue(s.Substring(1, 3));
                NumberofGlobalColors++;
            }
            Index++;
            s = GetBits(Data[Index]);
            BackGroundColorIndex = GetNumericalValue(s);
            Index++;
            s = GetBits(Data[Index]);
            if (GetNumericalValue(s) == 0)
                return true;
            else
                return false;
        }

        private Frame GetImageDescriptor()
        {
            
            string s="test";
            while (s != "00101100")
            {
                s = GetBits(Data[Index]);
                Index++;
            }
            if (s == "00101100")
            {
                Frame F = new Frame();
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Left = GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Left += GetNumericalValue(s);

                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Top = GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Top += GetNumericalValue(s);

                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Width = GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Width += GetNumericalValue(s);

                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Height = GetNumericalValue(s);
                Index++;
                s = GetBits(Data[Index]);
                //Flip(s);
                F.Height += GetNumericalValue(s);

                Index++;
                s = GetBits(Data[Index]);
                if (s[0] == '0')
                {
                    F.UseGlobalMap = true;
                }
                if (s[1] == '1')
                {
                    F.Interlaced = true;
                }
                F.bitsPerpixel = Get_3bit_NumericalValue(s.Substring(4,3));
                if (!F.UseGlobalMap)
                {
                    GetLocalPalette(F);
                }
                return F;
            }
            else
                return new Frame();
        }

        private string GetBits(Byte b)
        {
            return String.Format("{0:D8}", int.Parse(Convert.ToString(b, 2)));
        }

        private int GetNumericalValue(string bits)
        {
            int Result = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    switch (i)
                    {
                        case 0: Result += 128;
                            break;
                        case 1: Result += 64;
                            break;
                        case 2: Result += 32;
                            break;
                        case 3: Result += 16;
                            break;
                        case 4: Result += 8;
                            break;
                        case 5: Result += 4;
                            break;
                        case 6: Result += 2;
                            break;
                        case 7: Result += 1;
                            break;
                        default: break;
                    }
                }
            }
            return Result;
        }

        private int Get_3bit_NumericalValue(string bits)
        {
            int Result = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    switch (i)
                    {
                        case 0: Result += 4;
                            break;
                        case 1: Result += 2;
                            break;
                        case 2: Result += 1;
                            break;
                        default: break;
                    }
                }
            }
            return Result;
        }

        private string Flip(string s)
        {
            string Result = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                Result += s[i].ToString();
            }
            return Result;
        }

        public Image GetImage()
        {
            GetImageBytes();
            string s = "fs";
            while (s != "00101100")
            {
                s = GetBits(Data[Index]);
                Index++;
            }
            Index = 0;            
            if (CheckSignature())
            {
                CheckScreenDescriptor();
                if (UseGlobalPalette)
                    GetGlobalPalette();
                Frame F=GetImageDescriptor();
                while (F.Width!=0)
                {
                    if(!F.UseGlobalMap)
                        GetLocalPalette(F);
                    //GetRasterData(F,g);
                    break;
                }
                if(Result!=null)
                    return Result;
                if (Data[Index] == ';')
                    if (Result != null)
                        return Result;
            }
            else
                return null;
            return Image.FromFile(path);
        }
    }
}
