using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {   
        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);
        static Bitmap img_result = new Bitmap(1, 1);
        GrayScale grayScale = new GrayScale();
        Stack<Bitmap> StepStack = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }
        private void InitForm()
        {
            O_R_Band.Image = null;
            O_G_Band.Image = null;
            O_B_Band.Image = null;
            O_R_Band_R.Image = null;
            O_G_Band_R.Image = null;
            O_B_Band_R.Image = null;
            PhotoWH.Text = "0x0";
            PhotoWH_R.Text = "0x0";
            StepStack.Clear();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image File";
            openFileDialog.Filter = "All Files (*.jpg)|*.jpg*|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //initial
                InitForm();
                //read image
                img = new Bitmap(Image.FromFile(openFileDialog.FileName));  //圖片轉Bitmap格式
                img_origin = new Bitmap(img);

                StepStack.Push(img);

                Original_Image_Box.Image = img_origin;
                PhotoWH.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();

                ShowBand();
                Histogram();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image File";
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.Filter = "All Files (*.jpg)|*.jpg*|All Files (*.*)|*.*";
            // Safe File
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveFileDialog.FileName + ".Jpg", ImageFormat.Jpeg);
            }
        }
        
        public static int[,,] GetRGBData(Bitmap bitImg)
        {
            int height = bitImg.Height;
            int width = bitImg.Width;
            //鎖Bitmap的影像內容
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //取得起始位置
            IntPtr imgPtr = bitmapData.Scan0;
            
            int stride = bitmapData.Stride;     //影像scan寬度
            int widthByte = width * 3;          //影像陣列實際寬度
            int skipByte = stride - widthByte;  //鎖padding的byte數

            int[,,] rgbData = new int[width, height, 3];

            unsafe
            {
                byte* p = (byte*)imgPtr;
                for (int j=0; j<height; j++)
                {
                    for(int i=0; i<width; i++)
                    {
                        //B channel
                        rgbData[i, j, 2] = p[0];
                        p++;
                        //G channel
                        rgbData[i, j, 1] = p[0];
                        p++;
                        //R channel
                        rgbData[i, j, 0] = p[0];
                        p++;
                    }
                    p += skipByte;
                }
            }
            bitImg.UnlockBits(bitmapData);      //解mem.鎖
            return rgbData;
        }

        public static Bitmap SetRGBData(int[,,] rgbData)
        {
            Bitmap bitImg;
            int width = rgbData.GetLength(0);
            int height = rgbData.GetLength(1);

            //依照陣列長寬 設定Bitmap新物件
            bitImg = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            //鎖住Bitmap影像內容
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            //取得影像data起始位置
            IntPtr imgPtr = bitmapData.Scan0;
            //影像scan之寬度
            int stride = bitmapData.Stride;
            //影像arr的實際寬
            int widthByte = width * 3;
            //鎖padding的byte數
            int skipByte = stride - widthByte;

            unsafe
            {
                byte* p = (byte*)(void*)imgPtr;
                for(int j=0; j<height; j++)
                {
                    for(int i=0; i<width; i++)
                    {
                        //B channel
                        p[0] = (byte)rgbData[i, j, 2];
                        p++;
                        //G channel
                        p[0] = (byte)rgbData[i, j, 1];
                        p++;
                        //R channel
                        p[0] = (byte)rgbData[i, j, 0];
                        p++;
                    }
                    p += skipByte;
                }
            }
            //unlock mem.鎖
            bitImg.UnlockBits(bitmapData);
            return bitImg;
        }

        private void ShowBand()
        {
            int[,,] RBand = new int[img.Width, img.Height, 3];
            int[,,] GBand = new int[img.Width, img.Height, 3];
            int[,,] BBand = new int[img.Width, img.Height, 3];

            BitmapData bitmapData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int ByteOfSkip = bitmapData.Stride - bitmapData.Width * 3;
            unsafe
            {
                byte* imgPtr = (byte*)(bitmapData.Scan0);
                for(int y=0; y<bitmapData.Height; y++)
                {
                    for(int x=0; x<bitmapData.Width; x++)
                    {
                        BBand[x, y, 2] = (int)*(imgPtr);
                        BBand[x, y, 1] = (int)*(imgPtr);
                        BBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;

                        GBand[x, y, 2] = (int)*(imgPtr);
                        GBand[x, y, 1] = (int)*(imgPtr);
                        GBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;

                        RBand[x, y, 2] = (int)*(imgPtr);
                        RBand[x, y, 1] = (int)*(imgPtr);
                        RBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;
                    }
                    imgPtr += ByteOfSkip;
                }
            }

            img.UnlockBits(bitmapData);
            //設定圖片顯示R
            O_R_Band.Image = SetRGBData(RBand);
            //圖片顯示G
            O_G_Band.Image = SetRGBData(GBand);
            //圖片顯示B
            O_B_Band.Image = SetRGBData(BBand);
        }

        private void Histogram()
        {
            int[] origin_r = new int[256];
            int[] origin_g = new int[256];
            int[] origin_b = new int[256];

            for (int x=0; x<img.Width; x++)
            {
                for (int y=0; y<img.Height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);
                    origin_r[pixelColor.R]++;
                    origin_g[pixelColor.G]++;
                    origin_b[pixelColor.B]++;
                }
            }
            int max_times = 0;

            for (int i=0; i<256; i++)
            {
                if(max_times < origin_r[i])
                {
                    max_times = origin_r[i];
                }
                if (max_times < origin_g[i])
                {
                    max_times = origin_g[i];
                }
                if (max_times < origin_b[i])
                {
                    max_times = origin_b[i];
                }
            }

            Bitmap imgR = new Bitmap(256, 100);
            for(int x=0; x<imgR.Width; x++)
            {
                for (int y=0; y<(int)(((float)origin_r[x] / max_times)*100); y++)
                {
                    imgR.SetPixel(x, imgR.Height - 1 - y, Color.FromArgb(255, 0, 0));
                }
            }
            H_R.Image = imgR;

            Bitmap imgG = new Bitmap(256, 100);
            for (int x = 0; x < imgG.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_g[x] / max_times) * 100); y++)
                {
                    imgG.SetPixel(x, imgG.Height - 1 - y, Color.FromArgb(0, 255, 0));
                }
            }
            H_G.Image = imgG;

            Bitmap imgB = new Bitmap(256, 100);
            for (int x = 0; x < imgB.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_b[x] / max_times) * 100); y++)
                {
                    imgB.SetPixel(x, imgB.Height - 1 - y, Color.FromArgb(0, 0, 255));
                }
            }
            H_B.Image = imgB;
        }

        private void ShowBand_R()
        {
            int[,,] RBand = new int[img.Width, img.Height, 3];
            int[,,] GBand = new int[img.Width, img.Height, 3];
            int[,,] BBand = new int[img.Width, img.Height, 3];

            BitmapData byteArray = img_result.LockBits(new Rectangle(0, 0, img_result.Width, img_result.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int ByteOfSkip = byteArray.Stride - byteArray.Width * 3;
            unsafe
            {
                byte* imgPtr = (byte*)(byteArray.Scan0);
                for (int y = 0; y < byteArray.Height; y++)
                {
                    for (int x = 0; x < byteArray.Width; x++)
                    {
                        BBand[x, y, 2] = (int)*(imgPtr);
                        BBand[x, y, 1] = (int)*(imgPtr);
                        BBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;

                        GBand[x, y, 2] = (int)*(imgPtr);
                        GBand[x, y, 1] = (int)*(imgPtr);
                        GBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;

                        RBand[x, y, 2] = (int)*(imgPtr);
                        RBand[x, y, 1] = (int)*(imgPtr);
                        RBand[x, y, 0] = (int)*(imgPtr);
                        imgPtr++;
                    }
                    imgPtr += ByteOfSkip;
                }
            }

            img_result.UnlockBits(byteArray);
            //設定圖片顯示R
            O_R_Band_R.Image = SetRGBData(RBand);
            //圖片顯示G
            O_G_Band_R.Image = SetRGBData(GBand);
            //圖片顯示B
            O_B_Band_R.Image = SetRGBData(BBand);
        }

        private void Histogram_R()
        {
            int[] result_r = new int[256];
            int[] result_g = new int[256];
            int[] result_b = new int[256];
            PhotoWH_R.Text = img_result.Width + "x" + img_result.Height;
            for (int x = 0; x < img_result.Width; x++)
            {
                for (int y = 0; y < img_result.Height; y++)
                {
                    Color pixelColor = img_result.GetPixel(x, y);
                    result_r[pixelColor.R]++;
                    result_g[pixelColor.G]++;
                    result_b[pixelColor.B]++;
                }
            }
            int max_times = 0;

            for (int i = 0; i < 256; i++)
            {
                if (max_times < result_r[i])
                {
                    max_times = result_r[i];
                }
                if (max_times < result_g[i])
                {
                    max_times = result_g[i];
                }
                if (max_times < result_b[i])
                {
                    max_times = result_b[i];
                }
            }

            Bitmap imgR = new Bitmap(256, 100);
            for (int x = 0; x < imgR.Width; x++)
            {
                for (int y = 0; y < (int)(((float)result_r[x] / max_times) * 100); y++)
                {
                    imgR.SetPixel(x, imgR.Height - 1 - y, Color.FromArgb(255, 0, 0));
                }
            }
            H_R_R.Image = imgR;

            Bitmap imgG = new Bitmap(256, 100);
            for (int x = 0; x < imgG.Width; x++)
            {
                for (int y = 0; y < (int)(((float)result_g[x] / max_times) * 100); y++)
                {
                    imgG.SetPixel(x, imgG.Height - 1 - y, Color.FromArgb(0, 255, 0));
                }
            }
            H_G_R.Image = imgG;

            Bitmap imgB = new Bitmap(256, 100);
            for (int x = 0; x < imgB.Width; x++)
            {
                for (int y = 0; y < (int)(((float)result_b[x] / max_times) * 100); y++)
                {
                    imgB.SetPixel(x, imgB.Height - 1 - y, Color.FromArgb(0, 0, 255));
                }
            }
            H_B_R.Image = imgB;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if(StepStack.Count > 0)
            {
                StepStack.Pop();
            }
            if(StepStack.Count > 0)
            {
                img = StepStack.Pop();
                Result_Image_Box.Image = img;

                img_result = img;
                ShowBand_R();
                Histogram_R();

                StepStack.Push(img);
            }
            else if(StepStack.Count == 0)
            {
                StepStack.Push(img_origin);
            }
        }

        private void OriginalButton_Click(object sender, EventArgs e)
        {
            Result_Image_Box.Image = img_origin;
            img_result = img_origin;
            ShowBand_R();
            Histogram_R();

            StepStack.Clear();
            StepStack.Push(img_origin);
            img = img_origin;
        }

        private void MeanWeightButton_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img_origin);
            Bitmap img_R = SetRGBData(grayScale.Mean_Weight(rgb, img.Width, img.Height));
            Result_Image_Box.Image = img_R;

            StepStack.Push(img_R);

            img_result = img_R;
            ShowBand_R();
            Histogram_R();
            
        }

        private void MeanValueButton_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img_origin);
            Bitmap img_R = SetRGBData(grayScale.Mean_Value(rgb, img.Width, img.Height));
            Result_Image_Box.Image = img_R;

            StepStack.Push(img_R);

            img_result = img_R;
            ShowBand_R();
            Histogram_R();
        }

        private void MaximumButton_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img_origin);
            Bitmap img_R = SetRGBData(grayScale.Maximum(rgb, img.Width, img.Height));
            Result_Image_Box.Image = img_R;

            StepStack.Push(img_R);

            img_result = img_R;
            ShowBand_R();
            Histogram_R();
        }
    }
}
