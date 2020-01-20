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
        OpenCvSharp.Rect rect2;
        Mat imgInput = new Mat();
        Mat templ1=new Mat();
        Mat result = new Mat();
        int i = 0, k;
        int tx, ty, th, tw;
        int var_ind = 0;
        int countpixel = 0;
        Rect Rect_crop;
        bool[] mousedraw = new bool[5];
        int[] Pos_tx = new int[5];
        int[] Pos_ty = new int[5];
        int[] Pos_tw = new int[5];
        int[] Pos_th = new int[5];
        double minValue;
        double maxValue;
        double min, max;
        private int[,] X, Y, W, H;
        OpenCvSharp.Point maxLoc;
        OpenCvSharp.Point minLoc;
        OpenCvSharp.Point matchLoc, resLoc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                progressBar1.Value = 50;
                imgInput = new Mat(openFileDialog1.FileName, ImreadModes.Color);
            }
            else
            {
                textBox1.Text = "No picture selected";
                MessageBox.Show("Nothing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {}
        private void cb_canny_CheckedChanged(object sender, EventArgs e)
        {}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {}

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void cb_contour_CheckedChanged(object sender, EventArgs e)
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

            //PRE_PROCESSORS
            Cv2.CvtColor(tempa, tempa, ColorConversionCodes.BGRA2GRAY);
            if (comboBox1.Text == "None"||comboBox2.Text=="None")
            {}

            if (cb_blur.Checked)
            {
                OpenCvSharp.Size aa = new OpenCvSharp.Size(3, 3);
                Cv2.GaussianBlur(tempa, tempa, aa, 3, 3);
            }
            else if(comboBox1.Text=="Gaussian Blur")
            {
                OpenCvSharp.Size aa = new OpenCvSharp.Size(3, 3);
                Cv2.GaussianBlur(tempa, tempa, aa, 3, 3);
            }

            if (cb_threshold.Checked)
            {
                Cv2.Threshold(tempa, tempa, (int)numericUpDown1.Value, 255, ThresholdTypes.Binary);
            }
            else if(comboBox1.Text=="Threshold")
            {
                Cv2.Threshold(tempa, tempa, (int)numericUpDown1.Value, 255, ThresholdTypes.Binary);
            }

            if (cb_adaptive.Checked)
            {
                Cv2.AdaptiveThreshold(tempa, tempa, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 3, 2);
            }
            else if(comboBox1.Text=="Adaptive Threshold")
            {
                Cv2.AdaptiveThreshold(tempa, tempa, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 3, 2);
            }

            if (cb_canny.Checked)
            {
                Cv2.Canny(tempa, tempa, (int)numericUpDown2.Value, (int)numericUpDown3.Value, 3, false);
            }
            else if(comboBox1.Text=="Canny")
            {
                Cv2.Canny(tempa, tempa, (int)numericUpDown2.Value, (int)numericUpDown3.Value, 3, false);
            }

            if (cb_erode.Checked)
            {
                Cv2.Erode(tempa, tempa, new Mat());
            }
            else if(comboBox1.Text=="Erode")
            {
                Cv2.Erode(tempa, tempa, new Mat());
            }

            if (cb_dilate.Checked)
            {
                Cv2.Dilate(tempa, tempa, new Mat());
            }
            else if(comboBox1.Text=="Dilate")
            {
                Cv2.Erode(tempa, tempa, new Mat());
            }
            
            if (cb_otsu.Checked)
            {
                Cv2.Threshold(tempa, tempa, 0, 255, ThresholdTypes.Otsu);
            }
            else if(comboBox1.Text=="Threshold Otsu")
            {
                Cv2.Threshold(tempa, tempa, 0, 255, ThresholdTypes.Otsu);
            }

            if(cb_threinvert.Checked)
            {
                Cv2.Threshold(tempa, tempa, (int)numericUpDown4.Value, 255, ThresholdTypes.BinaryInv);
            }
            else if(comboBox1.Text=="Threshold Invert")
            {
                Cv2.Threshold(tempa, tempa, (int)numericUpDown4.Value, 255, ThresholdTypes.BinaryInv);
            }

            //ALGORITHMS
            if (cb_count.Checked)
            {
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
            else if(comboBox2.Text=="Count Pixels")
            {
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

            if (cb_contour.Checked)
            {
                OpenCvSharp.Point[][] first;
                HierarchyIndex[] hi;
                Cv2.FindContours(tempa, out first, out hi, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                Cv2.CvtColor(tempa, tempa, ColorConversionCodes.GRAY2BGR);
                for (int i = 0; i < first.Length; i++)
                {
                    Cv2.DrawContours(tempa, first, i, Scalar.Red, 20);
                }
            }
            else if(comboBox2.Text=="Contours")
            {
                OpenCvSharp.Point[][] first;
                HierarchyIndex[] hi;
                Cv2.FindContours(tempa, out first, out hi, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                Cv2.CvtColor(tempa, tempa, ColorConversionCodes.GRAY2BGR);
                for (int i = 0; i < first.Length; i++)
                {
                    Cv2.DrawContours(tempa, first, i, Scalar.Red, 20);
                }
            }

            if (cb_pattern.Checked)
            {
                Mat result1 = new Mat();
                templ1 = Cv2.ImRead(@"F:\REDBOT INNOVATIONS\Brakes img\RHS\562\69_1.bmp");
                Cv2.CvtColor(templ1, templ1, ColorConversionCodes.BGRA2GRAY);
                int result1_cols = tempa.Cols - templ1.Cols + 1;
                int result1_rows = tempa.Rows - templ1.Rows + 1;
                //result1.Create(result1_cols, result1_rows, MatType.CV_32FC1);

                Cv2.MatchTemplate(tempa, templ1, result, TemplateMatchModes.CCoeff);
                Cv2.MinMaxLoc(result, out minValue, out maxValue, out minLoc, out maxLoc);
                matchLoc = maxLoc;
                min = minValue * 100;
                max = maxValue * 100;

                resLoc = new OpenCvSharp.Point(matchLoc.X + templ1.Cols, matchLoc.Y + templ1.Rows);
                int mxi = Convert.ToInt32(matchLoc.X);
                int myi = Convert.ToInt32(matchLoc.Y);
                int rxi = Convert.ToInt32(resLoc.X);
                int ryi = Convert.ToInt32(resLoc.Y);
                int wi = rxi - mxi;
                int hi = ryi - myi;
                OpenCvSharp.Rect cro = new OpenCvSharp.Rect(mxi, myi, wi, hi);
                int x = tx + mxi;
                int y = ty + myi;
                rect2 = new OpenCvSharp.Rect(x, y, cro.Width, cro.Height);
                //Cv2.CvtColor(imgInput, imgInput, ColorConversionCodes.GRAY2BGR);
                Cv2.Rectangle(imgInput, rect2, Scalar.Red, 5);

                Mat roi = new Mat(imgInput, rect2);
                if (result == templ1)
                {
                    tb_forpattern.Text = "PASS";
                    tb_forpattern.BackColor = Color.Green;
                }
                else
                {
                    tb_forpattern.Text = "FAIL";
                    tb_forpattern.BackColor = Color.Red;
                }

            }
            
            Cv2.NamedWindow("s", WindowMode.Normal);
            Cv2.ImShow("s", imgInput);
            Bitmap bmp1 = BitmapConverter.ToBitmap(imgInput);
            pictureBox2.Image = bmp1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Image = bmp1;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


        }
    }
}
