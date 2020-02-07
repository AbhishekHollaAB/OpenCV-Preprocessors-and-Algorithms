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
        OpenCvSharp.Rect t;
        Mat imgInput = new Mat();
        Mat templ1=new Mat();
        Mat result = new Mat();
        Mat result1 = new Mat();
        Mat result2 = new Mat();
        Mat result3 = new Mat();
        int i = 0, k;
        int tx, ty, th, tw;
        int var_ind = 0;
        int countpixel = 0;
        int left = 0;
        Rect Rect_crop;
        Rect Rect_crop2;
        Rect Rect_crop3;
        Rect Rect_crop4;
        bool[] mousedraw = new bool[5];
        int[] Pos_tx = new int[5];
        int[] Pos_ty = new int[5];
        int[] Pos_tw = new int[5];
        int[] Pos_th = new int[5];
        double minValue, minValue2, minValue3, minValue4;
        double maxValue, maxValue2, maxValue3, maxValue4;
        double min, max;
        private int[,] X, Y, W, H;
        OpenCvSharp.Point maxLoc, maxLoc2, maxLoc3, maxLoc4;
        OpenCvSharp.Point minLoc, minLoc2, minLoc3, minLoc4;
        OpenCvSharp.Point matchLoc, matchLoc2, matchLoc3, matchLoc4;
        OpenCvSharp.Point resLoc, resLoc2, resLoc3, resLoc4;
        OpenCvSharp.Point center;
        OpenCvSharp.Rect rect3;
        OpenCvSharp.Rect rect4;
        OpenCvSharp.Rect rect5;
        OpenCvSharp.Rect rect6;
        float rotate, angle;
        Mat temp2 = new Mat();
        OpenCvSharp.Point center1;
        OpenCvSharp.Point center2;
        OpenCvSharp.Point center3;
        OpenCvSharp.Point center4;

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

        private void btn_left_Click(object sender, EventArgs e)
        {
            Mat temp = new Mat();
            imgInput.CopyTo(temp);
            t = new Rect(tx, ty, tw, th);
            left++;
            left++;
            t.X -= left;
            Cv2.Rectangle(temp, t, Scalar.Aqua,2);

            Bitmap img1 = BitmapConverter.ToBitmap(temp);
            pictureBox1.Image = img1;
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
                //Cv2.Circle(imgInput, LocationXY, 10, Scalar.Red, 3);
                //if (IsMouseDown == false)
                //{
                //    Cv2.Circle(imgInput, LocationXY, 10, Scalar.Red, 3);
                //}
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {}

        private void button5_Click(object sender, EventArgs e)
        {
            rect3 = new Rect(695, 684, 100, 100);
            Cv2.Rectangle(imgInput, rect3, Scalar.Red, 2);

            rect4 = new Rect(695, 1229, 60, 56);
            Cv2.Rectangle(imgInput, rect4, Scalar.Red, 2);

            rect5 = new Rect(1843, 711, 97, 50);
            Cv2.Rectangle(imgInput, rect5, Scalar.Red, 2);

            rect6 = new Rect(1828, 1222, 78, 70);
            Cv2.Rectangle(imgInput, rect6, Scalar.Red, 2);

            Mat temp2 = new Mat(imgInput, rect3);
            Mat temp3 = new Mat(imgInput, rect4);
            Mat temp4 = new Mat(imgInput, rect5);
            Mat temp5 = new Mat(imgInput, rect6);

            //Bitmap bmp = BitmapConverter.ToBitmap(temp2);
            //img_disp.Image = bmp;
            //img_disp.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap bmp2 = BitmapConverter.ToBitmap(temp3);
            //pictureBox3.Image = bmp2;
            //pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap bmp3 = BitmapConverter.ToBitmap(temp4);
            //pictureBox4.Image = bmp3;
            //pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap bmp4 = BitmapConverter.ToBitmap(temp5);
            //pictureBox5.Image = bmp4;
            //pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap bmp5 = BitmapConverter.ToBitmap(imgInput);
            //pictureBox1.Image = bmp5;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            center1.X = 730;
            center1.Y = 745;
            Cv2.Circle(imgInput, center1, 50, Scalar.Red, 2);
            center2.X = 1860;
            center2.Y = 738;
            Cv2.Circle(imgInput, center2, 50, Scalar.Red, 2);
            center3.X = 732;
            center3.Y = 1242;
            Cv2.Circle(imgInput, center3, 50, Scalar.Red, 2);
            center4.X = 1865;
            center4.Y = 1245;
            Cv2.Circle(imgInput, center4, 50, Scalar.Red, 2);

            Bitmap bmp5 = BitmapConverter.ToBitmap(imgInput);
            pictureBox1.Image = bmp5;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

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
            //Cv2.Circle(imgInput, LocationXY, 10, Scalar.Red, 3);
            if (draw)
            {

                if (IsMouseDown == true)
                {
                    LocationX1Y1 = new OpenCvSharp.Point(e.X, e.Y);
                    IsMouseDown = false;
                    //Cv2.Circle(imgInput, LocationXY, 10, Scalar.Red, 3);
                    if (rect!=null)
                    {
                        double scaleX = (double)imgInput.Width / pictureBox1.Size.Width;
                        double scaleY = (double)imgInput.Height / pictureBox1.Size.Height;
                        tx = (int)(rect.X * scaleX) + 5 ;
                        ty = (int)(rect.Y * scaleY) + 10;
                        tw = (int)(rect.Width * scaleX);
                        th = (int)(rect.Height * scaleY);
                        t = new Rect(tx, ty, tw, th);
                        Mat temp = new Mat(imgInput, t);
                        
                        //if(mousedraw[var_ind]==true)
                       
                        Pos_tx[var_ind] = tx;
                        Pos_ty[var_ind] = ty;
                        Pos_tw[var_ind] = tw;
                        Pos_th[var_ind] = th;

                        //OpenCvSharp.Point circle;
                        //circle.X = tx-10;
                        //circle.Y = ty-10;
                        //Cv2.Circle(imgInput, circle, 10, Scalar.Red, 5);
                        //draw = false;

                        //Bitmap bmp = BitmapConverter.ToBitmap(temp2);
                        Bitmap bmp1 = BitmapConverter.ToBitmap(imgInput);
                        //img_disp.Image = bmp;
                        img_disp.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = bmp1;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            imgIn.CopyTo(imgInput);
            //Rect_crop = new Rect(695, 684, 100, 100);
            //Rect_crop2 = new Rect(695, 1229, 60, 56);
            //Rect_crop3 = new Rect(1843, 711, 97, 50);
            //Rect_crop4 = new Rect(1828, 1222, 78, 70);

            //Mat tempa = new Mat();
            Mat tempa = new Mat(imgInput, Rect_crop);
            //Mat tempa2 = new Mat(imgInput, Rect_crop2);
            //Mat tempa3 = new Mat(imgInput,Rect_crop3);
            //Mat tempa4 = new Mat(imgInput, Rect_crop4);

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

            if (cb_open.Checked)
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.Open, new Mat());
            }
            else if(comboBox1.Text=="Open")
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.Open, new Mat());
            }

            if (cb_hm.Checked)
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.HitMiss, new Mat());
            }
            else if(comboBox1.Text=="Hit or Miss")
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.HitMiss, new Mat());
            }

            if (cb_close.Checked)
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.Open, new Mat());
            }
            else if(comboBox1.Text=="Close")
            {
                Cv2.MorphologyEx(tempa, tempa, MorphTypes.Open, new Mat());
            }

            if(cb_colorpixels.Checked)
            {
                Bitmap myBitmap = BitmapConverter.ToBitmap(tempa);
                //e.Graphics.DrawImage(tempa, 0, 0, myBitmap.Width, myBitmap.Height);
                Bitmap newim = new Bitmap(myBitmap.Width, myBitmap.Height);
                // Set each pixel in myBitmap to black.
                for (int Xcount = 0; Xcount < newim.Width; Xcount++)
                {
                    for (int Ycount = 0; Ycount < newim.Height; Ycount++)
                    {
                        newim.SetPixel(Xcount, Ycount, Color.Red);
                    }
                }
                //Mat temp000 = new Mat();
                //Bitmap finalim = BitmapConverter.ToMat(newim);
                //Cv2.CvtColor(newim, newim, ColorConversionCodes.GRAY2BGR);
                pictureBox2.Image = newim;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                // Draw myBitmap to the screen again.
                //e.Graphics.DrawImage(myBitmap, myBitmap.Width, 0,myBitmap.Width, myBitmap.Height);
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
                
                
                templ1 = Cv2.ImRead(@"F:\REDBOT INNOVATIONS\cam1 img\0.bmp");
                //Cv2.CvtColor(templ1, templ1, ColorConversionCodes.BGRA2GRAY);

                //FOR THE FIRST ONE
                int result_cols = tempa.Cols - templ1.Cols + 1;
                int result_rows = tempa.Rows - templ1.Rows + 1;
                //result.Create(result_cols, result_rows, MatType.CV_8UC1);
                Cv2.MatchTemplate(tempa, templ1, result, TemplateMatchModes.CCorrNormed);
                Cv2.MinMaxLoc(result, out minValue, out maxValue, out minLoc, out maxLoc);
                matchLoc = maxLoc;
                min = minValue * 100;
                max = maxValue * 100;
                resLoc = new OpenCvSharp.Point(matchLoc.X + templ1.Cols, matchLoc.Y + templ1.Rows);
                //int mxi = Convert.ToInt32(matchLoc.X);
                //int myi = Convert.ToInt32(matchLoc.Y);
                //int rxi = Convert.ToInt32(resLoc.X);
                //int ryi = Convert.ToInt32(resLoc.Y);
                //int wi = rxi - mxi;
                //int hi = ryi - myi;
                //OpenCvSharp.Rect cro = new OpenCvSharp.Rect(mxi, myi, wi, hi);
                //int x = tx + mxi;
                //int y = ty + myi;
                //rect2 = new OpenCvSharp.Rect(x, y, cro.Width, cro.Height);
                ////Cv2.CvtColor(imgInput, imgInput, ColorConversionCodes.GRAY2BGR);
                //Cv2.Rectangle(imgInput, rect2, Scalar.Red, 5);
                if (maxValue>=0.992)
                {
                    tb_forpattern.BackColor = Color.Green;
                }
                else
                {
                    tb_forpattern.BackColor = Color.Red;
                }

                //FOR THE SECOND ONE
                //Cv2.
                //int result1_cols = tempa2.Cols - templ1.Cols + 1;
                //int result1_rows = tempa2.Rows - templ1.Rows + 1;
                //result.Create(result_cols, result_rows, MatType.CV_8UC1);
                //Cv2.MatchTemplate(tempa2, templ1, result1, TemplateMatchModes.CCorrNormed);
                Cv2.MinMaxLoc(result1, out minValue2, out maxValue2, out minLoc2, out maxLoc2);
                matchLoc2 = maxLoc2;
                if (maxValue2 >= 0.98)
                {
                    tb_forpattern2.BackColor = Color.Green;
                }
                else
                {
                    tb_forpattern2.BackColor = Color.Red;
                }

                //FOR THE THIRD ONE
               // int result2_cols = tempa3.Cols - templ1.Cols + 1;
               // int result2_rows = tempa3.Rows - templ1.Rows + 1;
                //result.Create(result_cols, result_rows, MatType.CV_8UC1);
               // Cv2.MatchTemplate(tempa3, templ1, result2, TemplateMatchModes.CCorrNormed);
                Cv2.MinMaxLoc(result2, out minValue3, out maxValue3, out minLoc3, out maxLoc3);
                matchLoc3 = maxLoc3;
                resLoc3 = new OpenCvSharp.Point(matchLoc3.X + templ1.Cols, matchLoc3.Y + templ1.Rows);
                if (maxValue3 >= 0.971)
                {
                    tb_forpattern3.BackColor = Color.Green;
                }
                else
                {
                    tb_forpattern3.BackColor = Color.Red;
                }

                //FOR THE FOURTH ONE
               // int result3_cols = tempa4.Cols - templ1.Cols + 1;
               // int result3_rows = tempa4.Rows - templ1.Rows + 1;
                //result.Create(result_cols, result_rows, MatType.CV_8UC1);
               // Cv2.MatchTemplate(tempa4, templ1, result3, TemplateMatchModes.CCorrNormed);
                Cv2.MinMaxLoc(result3, out minValue4, out maxValue4, out minLoc4, out maxLoc4);
                matchLoc4 = maxLoc4;
                resLoc4 = new OpenCvSharp.Point(matchLoc3.X + templ1.Cols, matchLoc3.Y + templ1.Rows);
                if (maxValue4 >= 0.992)
                {
                    tb_forpattern4.BackColor = Color.Green;
                }
                else
                {
                    tb_forpattern4.BackColor = Color.Red;
                }

                if(maxValue>=0.992 && maxValue2>=0.98 && maxValue3>=0.975 && maxValue4>=0.992)
                {
                    lbl_pass_fail.Text = "PASS";
                    lbl_pass_fail.BackColor = Color.Green;
                }
                else
                {
                    lbl_pass_fail.Text = "FAIL";
                    lbl_pass_fail.BackColor = Color.Red;
                }
            }

            score1.Text = Convert.ToString(maxValue);
            score2.Text = Convert.ToString(maxValue2);
            score3.Text = Convert.ToString(maxValue3);
            score4.Text = Convert.ToString(maxValue4);
            //Cv2.NamedWindow("t", WindowMode.Normal);
            //Cv2.ImShow("t", tempa);
            Bitmap bmp2 = BitmapConverter.ToBitmap(tempa);
            pictureBox2.Image = bmp2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
