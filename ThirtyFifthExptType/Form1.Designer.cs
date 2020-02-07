namespace ThirtyFifthExptType
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_disp = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cb_threshold = new System.Windows.Forms.CheckBox();
            this.cb_blur = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_close = new System.Windows.Forms.CheckBox();
            this.cb_hm = new System.Windows.Forms.CheckBox();
            this.cb_open = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.cb_threinvert = new System.Windows.Forms.CheckBox();
            this.cb_otsu = new System.Windows.Forms.CheckBox();
            this.cb_dilate = new System.Windows.Forms.CheckBox();
            this.cb_erode = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cb_canny = new System.Windows.Forms.CheckBox();
            this.cb_adaptive = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.score4 = new System.Windows.Forms.TextBox();
            this.tb_forpattern4 = new System.Windows.Forms.TextBox();
            this.score3 = new System.Windows.Forms.TextBox();
            this.score2 = new System.Windows.Forms.TextBox();
            this.tb_forpattern3 = new System.Windows.Forms.TextBox();
            this.score1 = new System.Windows.Forms.TextBox();
            this.tb_forpattern2 = new System.Windows.Forms.TextBox();
            this.tb_forpattern = new System.Windows.Forms.TextBox();
            this.cb_pattern = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cb_contour = new System.Windows.Forms.CheckBox();
            this.cb_count = new System.Windows.Forms.CheckBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_pass_fail = new System.Windows.Forms.Label();
            this.btn_left = new System.Windows.Forms.Button();
            this.cb_colorpixels = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "To Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 38);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_rotate);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Checking";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "Draw Rectangles";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Location = new System.Drawing.Point(580, 21);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(87, 40);
            this.btn_rotate.TabIndex = 9;
            this.btn_rotate.Text = "Draw Circles";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(442, 77);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 34);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(360, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 15);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Pixel Count";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(564, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(208, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(134, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 18);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Set Threshold";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Draw Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1204, 711);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 27);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(21, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // img_disp
            // 
            this.img_disp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.img_disp.Location = new System.Drawing.Point(983, 25);
            this.img_disp.Margin = new System.Windows.Forms.Padding(2);
            this.img_disp.Name = "img_disp";
            this.img_disp.Size = new System.Drawing.Size(133, 126);
            this.img_disp.TabIndex = 34;
            this.img_disp.TabStop = false;
            this.img_disp.Click += new System.EventHandler(this.img_disp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(953, 327);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 368);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // cb_threshold
            // 
            this.cb_threshold.AutoSize = true;
            this.cb_threshold.Location = new System.Drawing.Point(7, 47);
            this.cb_threshold.Name = "cb_threshold";
            this.cb_threshold.Size = new System.Drawing.Size(75, 19);
            this.cb_threshold.TabIndex = 36;
            this.cb_threshold.Text = "Threshold";
            this.cb_threshold.UseVisualStyleBackColor = true;
            this.cb_threshold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_blur
            // 
            this.cb_blur.AutoSize = true;
            this.cb_blur.Location = new System.Drawing.Point(7, 66);
            this.cb_blur.Name = "cb_blur";
            this.cb_blur.Size = new System.Drawing.Size(94, 19);
            this.cb_blur.TabIndex = 37;
            this.cb_blur.Text = "Gaussian Blur";
            this.cb_blur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_colorpixels);
            this.groupBox2.Controls.Add(this.cb_close);
            this.groupBox2.Controls.Add(this.cb_hm);
            this.groupBox2.Controls.Add(this.cb_open);
            this.groupBox2.Controls.Add(this.cb_threshold);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.cb_threinvert);
            this.groupBox2.Controls.Add(this.cb_otsu);
            this.groupBox2.Controls.Add(this.cb_dilate);
            this.groupBox2.Controls.Add(this.cb_erode);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.cb_canny);
            this.groupBox2.Controls.Add(this.cb_adaptive);
            this.groupBox2.Controls.Add(this.cb_blur);
            this.groupBox2.Location = new System.Drawing.Point(738, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 305);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pre-Processors";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cb_close
            // 
            this.cb_close.AutoSize = true;
            this.cb_close.Location = new System.Drawing.Point(7, 267);
            this.cb_close.Name = "cb_close";
            this.cb_close.Size = new System.Drawing.Size(53, 19);
            this.cb_close.TabIndex = 52;
            this.cb_close.Text = "Close";
            this.cb_close.UseVisualStyleBackColor = true;
            // 
            // cb_hm
            // 
            this.cb_hm.AutoSize = true;
            this.cb_hm.Location = new System.Drawing.Point(7, 249);
            this.cb_hm.Name = "cb_hm";
            this.cb_hm.Size = new System.Drawing.Size(83, 19);
            this.cb_hm.TabIndex = 51;
            this.cb_hm.Text = "Hit or Miss";
            this.cb_hm.UseVisualStyleBackColor = true;
            // 
            // cb_open
            // 
            this.cb_open.AutoSize = true;
            this.cb_open.Location = new System.Drawing.Point(7, 233);
            this.cb_open.Name = "cb_open";
            this.cb_open.Size = new System.Drawing.Size(53, 19);
            this.cb_open.TabIndex = 50;
            this.cb_open.Text = "Open";
            this.cb_open.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Threshold",
            "Gaussian Blur",
            "Adaptive Threshold",
            "Canny",
            "Erode",
            "Dilate",
            "Threshold Otsu",
            "Threshold Invert",
            "Open",
            "Hit or Miss",
            "Close",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 41;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(141, 194);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown4.TabIndex = 49;
            // 
            // cb_threinvert
            // 
            this.cb_threinvert.AutoSize = true;
            this.cb_threinvert.Location = new System.Drawing.Point(7, 217);
            this.cb_threinvert.Name = "cb_threinvert";
            this.cb_threinvert.Size = new System.Drawing.Size(107, 19);
            this.cb_threinvert.TabIndex = 48;
            this.cb_threinvert.Text = "Threshold Invert";
            this.cb_threinvert.UseVisualStyleBackColor = true;
            // 
            // cb_otsu
            // 
            this.cb_otsu.AutoSize = true;
            this.cb_otsu.Location = new System.Drawing.Point(7, 200);
            this.cb_otsu.Name = "cb_otsu";
            this.cb_otsu.Size = new System.Drawing.Size(102, 19);
            this.cb_otsu.TabIndex = 47;
            this.cb_otsu.Text = "Threshold Otsu";
            this.cb_otsu.UseVisualStyleBackColor = true;
            // 
            // cb_dilate
            // 
            this.cb_dilate.AutoSize = true;
            this.cb_dilate.Location = new System.Drawing.Point(7, 183);
            this.cb_dilate.Name = "cb_dilate";
            this.cb_dilate.Size = new System.Drawing.Size(55, 19);
            this.cb_dilate.TabIndex = 44;
            this.cb_dilate.Text = "Dilate";
            this.cb_dilate.UseVisualStyleBackColor = true;
            // 
            // cb_erode
            // 
            this.cb_erode.AutoSize = true;
            this.cb_erode.Location = new System.Drawing.Point(7, 165);
            this.cb_erode.Name = "cb_erode";
            this.cb_erode.Size = new System.Drawing.Size(54, 19);
            this.cb_erode.TabIndex = 43;
            this.cb_erode.Text = "Erode";
            this.cb_erode.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(56, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(85, 15);
            this.textBox6.TabIndex = 42;
            this.textBox6.Text = "Threshold 2";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(56, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 15);
            this.textBox5.TabIndex = 39;
            this.textBox5.Text = "Threshold 1";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(141, 142);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown3.TabIndex = 41;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(141, 118);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown2.TabIndex = 40;
            // 
            // cb_canny
            // 
            this.cb_canny.AutoSize = true;
            this.cb_canny.Location = new System.Drawing.Point(7, 102);
            this.cb_canny.Name = "cb_canny";
            this.cb_canny.Size = new System.Drawing.Size(58, 19);
            this.cb_canny.TabIndex = 39;
            this.cb_canny.Text = "Canny";
            this.cb_canny.UseVisualStyleBackColor = true;
            this.cb_canny.CheckedChanged += new System.EventHandler(this.cb_canny_CheckedChanged);
            // 
            // cb_adaptive
            // 
            this.cb_adaptive.AutoSize = true;
            this.cb_adaptive.Location = new System.Drawing.Point(7, 84);
            this.cb_adaptive.Name = "cb_adaptive";
            this.cb_adaptive.Size = new System.Drawing.Size(123, 19);
            this.cb_adaptive.TabIndex = 38;
            this.cb_adaptive.Text = "Adaptive Threshold";
            this.cb_adaptive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.score4);
            this.groupBox3.Controls.Add(this.tb_forpattern4);
            this.groupBox3.Controls.Add(this.score3);
            this.groupBox3.Controls.Add(this.score2);
            this.groupBox3.Controls.Add(this.tb_forpattern3);
            this.groupBox3.Controls.Add(this.score1);
            this.groupBox3.Controls.Add(this.tb_forpattern2);
            this.groupBox3.Controls.Add(this.tb_forpattern);
            this.groupBox3.Controls.Add(this.cb_pattern);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.cb_contour);
            this.groupBox3.Controls.Add(this.cb_count);
            this.groupBox3.Location = new System.Drawing.Point(738, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 218);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Algorithms";
            // 
            // score4
            // 
            this.score4.Location = new System.Drawing.Point(30, 191);
            this.score4.MaxLength = 6;
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(154, 21);
            this.score4.TabIndex = 47;
            // 
            // tb_forpattern4
            // 
            this.tb_forpattern4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_forpattern4.Location = new System.Drawing.Point(4, 190);
            this.tb_forpattern4.Name = "tb_forpattern4";
            this.tb_forpattern4.Size = new System.Drawing.Size(22, 22);
            this.tb_forpattern4.TabIndex = 56;
            // 
            // score3
            // 
            this.score3.Location = new System.Drawing.Point(30, 164);
            this.score3.MaxLength = 6;
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(154, 21);
            this.score3.TabIndex = 46;
            // 
            // score2
            // 
            this.score2.Location = new System.Drawing.Point(30, 135);
            this.score2.MaxLength = 6;
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(154, 21);
            this.score2.TabIndex = 45;
            // 
            // tb_forpattern3
            // 
            this.tb_forpattern3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_forpattern3.Location = new System.Drawing.Point(4, 163);
            this.tb_forpattern3.Name = "tb_forpattern3";
            this.tb_forpattern3.Size = new System.Drawing.Size(21, 22);
            this.tb_forpattern3.TabIndex = 55;
            // 
            // score1
            // 
            this.score1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.score1.Location = new System.Drawing.Point(30, 107);
            this.score1.MaxLength = 6;
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(154, 21);
            this.score1.TabIndex = 44;
            // 
            // tb_forpattern2
            // 
            this.tb_forpattern2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_forpattern2.Location = new System.Drawing.Point(3, 135);
            this.tb_forpattern2.Name = "tb_forpattern2";
            this.tb_forpattern2.Size = new System.Drawing.Size(22, 22);
            this.tb_forpattern2.TabIndex = 54;
            // 
            // tb_forpattern
            // 
            this.tb_forpattern.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_forpattern.Location = new System.Drawing.Point(3, 107);
            this.tb_forpattern.Name = "tb_forpattern";
            this.tb_forpattern.Size = new System.Drawing.Size(21, 22);
            this.tb_forpattern.TabIndex = 53;
            // 
            // cb_pattern
            // 
            this.cb_pattern.AutoSize = true;
            this.cb_pattern.Location = new System.Drawing.Point(7, 82);
            this.cb_pattern.Name = "cb_pattern";
            this.cb_pattern.Size = new System.Drawing.Size(96, 19);
            this.cb_pattern.TabIndex = 52;
            this.cb_pattern.Text = "Pattern Match";
            this.cb_pattern.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Count Pixels",
            "Contours",
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(3, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 50;
            // 
            // cb_contour
            // 
            this.cb_contour.AutoSize = true;
            this.cb_contour.Location = new System.Drawing.Point(7, 65);
            this.cb_contour.Name = "cb_contour";
            this.cb_contour.Size = new System.Drawing.Size(66, 19);
            this.cb_contour.TabIndex = 51;
            this.cb_contour.Text = "Contour";
            this.cb_contour.UseVisualStyleBackColor = true;
            this.cb_contour.CheckedChanged += new System.EventHandler(this.cb_contour_CheckedChanged);
            // 
            // cb_count
            // 
            this.cb_count.AutoSize = true;
            this.cb_count.Location = new System.Drawing.Point(7, 47);
            this.cb_count.Name = "cb_count";
            this.cb_count.Size = new System.Drawing.Size(56, 19);
            this.cb_count.TabIndex = 50;
            this.cb_count.Text = "Count";
            this.cb_count.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(1204, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 126);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.Location = new System.Drawing.Point(983, 181);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 126);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox5.Location = new System.Drawing.Point(1204, 181);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(133, 126);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_pass_fail
            // 
            this.lbl_pass_fail.AutoSize = true;
            this.lbl_pass_fail.BackColor = System.Drawing.Color.LawnGreen;
            this.lbl_pass_fail.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass_fail.Location = new System.Drawing.Point(788, 560);
            this.lbl_pass_fail.Name = "lbl_pass_fail";
            this.lbl_pass_fail.Size = new System.Drawing.Size(88, 36);
            this.lbl_pass_fail.TabIndex = 43;
            this.lbl_pass_fail.Text = "PASS";
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(728, 631);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 45;
            this.btn_left.Text = "left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // cb_colorpixels
            // 
            this.cb_colorpixels.AutoSize = true;
            this.cb_colorpixels.Location = new System.Drawing.Point(7, 287);
            this.cb_colorpixels.Name = "cb_colorpixels";
            this.cb_colorpixels.Size = new System.Drawing.Size(84, 19);
            this.cb_colorpixels.TabIndex = 53;
            this.cb_colorpixels.Text = "Color Pixels";
            this.cb_colorpixels.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_pass_fail);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.img_disp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experimenting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox img_disp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox cb_threshold;
        private System.Windows.Forms.CheckBox cb_blur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_adaptive;
        private System.Windows.Forms.CheckBox cb_canny;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox cb_erode;
        private System.Windows.Forms.CheckBox cb_dilate;
        private System.Windows.Forms.CheckBox cb_otsu;
        private System.Windows.Forms.CheckBox cb_threinvert;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_count;
        private System.Windows.Forms.CheckBox cb_contour;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox cb_pattern;
        private System.Windows.Forms.TextBox tb_forpattern;
        private System.Windows.Forms.CheckBox cb_open;
        private System.Windows.Forms.CheckBox cb_hm;
        private System.Windows.Forms.CheckBox cb_close;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tb_forpattern4;
        private System.Windows.Forms.TextBox tb_forpattern3;
        private System.Windows.Forms.TextBox tb_forpattern2;
        private System.Windows.Forms.Label lbl_pass_fail;
        private System.Windows.Forms.TextBox score1;
        private System.Windows.Forms.TextBox score2;
        private System.Windows.Forms.TextBox score3;
        private System.Windows.Forms.TextBox score4;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.CheckBox cb_colorpixels;
    }
}

