using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace ThirtyFifthExptType
{
    public partial class Form1 : Form
    {
        bool draw=false;
        bool IsMouseDown=false;
        bool imgsave = false;
        Rectangle rect;
        OpenCvSharp.Point LocationXY;
        OpenCvSharp.Point LocationX1Y1;
        Rect v;
        Mat imgInput = new Mat();
        Mat templ1=new Mat();
        Mat result = new Mat();
        int i = 0;
        int tx, ty, th, tw;
        int var_ind = 0;
        int countpixel = 0;
        Rect Rect_crop;
        bool[] mousedraw = new bool[5];
        int[] Pos_tx = new int[5];
        int[] Pos_ty = new int[5];
        int[] Pos_tw = new int[5];
        int[] Pos_th = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                progressBar1.Value = 50;
                imgInput = new Mat(openFileDialog1.FileName, ImreadModes.Color);
            }
            else
            {
                textBox1.Text = "No picture selected";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void button2_Click(object sender, EventArgs e)
        {
            draw = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {}

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {}

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {}

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                if (rect != null)
                {
                    e.Graphics.DrawRectangle(Pens.Red, GetRect());
                }
            }
        }

        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rect;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                IsMouseDown = true;
                LocationXY = new OpenCvSharp.Point(e.X,e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (IsMouseDown == true)
                {
                    LocationX1Y1 = new OpenCvSharp.Point(e.X, e.Y);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {}

        private void img_disp_Click(object sender, EventArgs e)
        {}

        private void progressBar1_Click(object sender, EventArgs e)
        {}

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Where do you want to store the images?";
            folderBrowserDialog1.ShowDialog();
            if(folderBrowserDialog1.SelectedPath=="")
            {
                MessageBox.Show("Cannot log images", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            imgsave = true;
            if (imgsave)
            {
                Cv2.ImWrite(folderBrowserDialog1.SelectedPath + "\\" + i.ToString() + ".bmp", imgInput);
            }
            i++;
        }
        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {}

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (IsMouseDown == true)
                {
                    LocationX1Y1 = new OpenCvSharp.Point(e.X, e.Y);
                    IsMouseDown = false;
                    if(rect!=null)
                    {
                        double scaleX = (double)imgInput.Width / pictureBox1.Size.Width;
                        double scaleY = (double)imgInput.Height / pictureBox1.Size.Height;
                        tx = (int)(rect.X * scaleX) + 5 ;
                        ty = (int)(rect.Y * scaleY) + 10;
                        tw = (int)(rect.Width * scaleX);
                        th = (int)(rect.Height * scaleY);
                        OpenCvSharp.Rect t = new OpenCvSharp.Rect(tx, ty, tw, th);
                        Mat temp = new Mat(imgInput, t);
                        //if(mousedraw[var_ind]==true)
                        
                            Pos_tx[var_ind] = tx;
                            Pos_ty[var_ind] = ty;
                            Pos_tw[var_ind] = tw;
                            Pos_th[var_ind] = th;
                        
                        Bitmap bmp = BitmapConverter.ToBitmap(temp);
                        img_disp.Image = bmp;
                        img_disp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            process_image(new Mat(openFileDialog1.FileName, ImreadModes.Color), true);
        }

        private void process_image(Mat imgIn, bool offline = false)
        {
            Rect_crop = new Rect(tx, ty, tw, th);
            Mat tempa = new Mat();
            imgIn.CopyTo(imgInput);
            tempa = new Mat(imgInput, Rect_crop);
            
            Cv2.CvtColor(tempa, tempa, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(tempa, tempa, (int)numericUpDown1.Value, 255, ThresholdTypes.Binary);
            Cv2.NamedWindow("s", WindowMode.Normal);
            Cv2.ImShow("s", tempa);
            Bitmap bmp1 = BitmapConverter.ToBitmap(tempa);
            pictureBox2.Image = bmp1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

           

            for (int x = 0; x < tempa.Rows; x++)
            {
                for (int y = 0; y < tempa.Cols; y++)
                {
                    if (tempa.At<char>(x, y) == 255)
                    {
                        countpixel++; 
                    }
                }
            }
            textBox4.Text = countpixel.ToString();
        }
    }
}
