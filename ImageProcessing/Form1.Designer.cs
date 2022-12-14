
namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Original_Image_Box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhotoWH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.O_R_Band = new System.Windows.Forms.PictureBox();
            this.O_G_Band = new System.Windows.Forms.PictureBox();
            this.O_B_Band = new System.Windows.Forms.PictureBox();
            this.H_R = new System.Windows.Forms.PictureBox();
            this.H_G = new System.Windows.Forms.PictureBox();
            this.H_B = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Result_Image_Box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhotoWH_R = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.O_R_Band_R = new System.Windows.Forms.PictureBox();
            this.O_G_Band_R = new System.Windows.Forms.PictureBox();
            this.O_B_Band_R = new System.Windows.Forms.PictureBox();
            this.H_R_R = new System.Windows.Forms.PictureBox();
            this.H_G_R = new System.Windows.Forms.PictureBox();
            this.H_B_R = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.Button();
            this.OriginalButton = new System.Windows.Forms.Button();
            this.MeanWeightButton = new System.Windows.Forms.Button();
            this.MeanValueButton = new System.Windows.Forms.Button();
            this.MaximumButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EqualizationButton = new System.Windows.Forms.Button();
            this.MaxFilterButton = new System.Windows.Forms.Button();
            this.GammaButton = new System.Windows.Forms.Button();
            this.MedFilterButton = new System.Windows.Forms.Button();
            this.MeanFilterButton = new System.Windows.Forms.Button();
            this.MinFilterButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Laplacian4Button = new System.Windows.Forms.Button();
            this.LaplacianM4Button = new System.Windows.Forms.Button();
            this.LaplacianA4Button = new System.Windows.Forms.Button();
            this.Laplacian9Button = new System.Windows.Forms.Button();
            this.LaplacianM9Button = new System.Windows.Forms.Button();
            this.LaplacianA9Button = new System.Windows.Forms.Button();
            this.SobelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Original_Image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_R)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OpenButton.Location = new System.Drawing.Point(29, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(74, 29);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveButton.Location = new System.Drawing.Point(119, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 29);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Original_Image_Box
            // 
            this.Original_Image_Box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Original_Image_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original_Image_Box.Location = new System.Drawing.Point(29, 77);
            this.Original_Image_Box.Name = "Original_Image_Box";
            this.Original_Image_Box.Size = new System.Drawing.Size(360, 360);
            this.Original_Image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Original_Image_Box.TabIndex = 2;
            this.Original_Image_Box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // PhotoWH
            // 
            this.PhotoWH.AutoSize = true;
            this.PhotoWH.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhotoWH.Location = new System.Drawing.Point(306, 53);
            this.PhotoWH.Name = "PhotoWH";
            this.PhotoWH.Size = new System.Drawing.Size(39, 21);
            this.PhotoWH.TabIndex = 4;
            this.PhotoWH.Text = "0x0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(77, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(200, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(325, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "B";
            // 
            // O_R_Band
            // 
            this.O_R_Band.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_R_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_R_Band.Location = new System.Drawing.Point(29, 471);
            this.O_R_Band.Name = "O_R_Band";
            this.O_R_Band.Size = new System.Drawing.Size(116, 116);
            this.O_R_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_R_Band.TabIndex = 8;
            this.O_R_Band.TabStop = false;
            // 
            // O_G_Band
            // 
            this.O_G_Band.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_G_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_G_Band.Location = new System.Drawing.Point(151, 471);
            this.O_G_Band.Name = "O_G_Band";
            this.O_G_Band.Size = new System.Drawing.Size(116, 116);
            this.O_G_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_G_Band.TabIndex = 9;
            this.O_G_Band.TabStop = false;
            // 
            // O_B_Band
            // 
            this.O_B_Band.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_B_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_B_Band.Location = new System.Drawing.Point(273, 471);
            this.O_B_Band.Name = "O_B_Band";
            this.O_B_Band.Size = new System.Drawing.Size(116, 116);
            this.O_B_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_B_Band.TabIndex = 10;
            this.O_B_Band.TabStop = false;
            // 
            // H_R
            // 
            this.H_R.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_R.Location = new System.Drawing.Point(29, 633);
            this.H_R.Name = "H_R";
            this.H_R.Size = new System.Drawing.Size(116, 116);
            this.H_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_R.TabIndex = 11;
            this.H_R.TabStop = false;
            // 
            // H_G
            // 
            this.H_G.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_G.Location = new System.Drawing.Point(151, 633);
            this.H_G.Name = "H_G";
            this.H_G.Size = new System.Drawing.Size(116, 116);
            this.H_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_G.TabIndex = 11;
            this.H_G.TabStop = false;
            // 
            // H_B
            // 
            this.H_B.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_B.Location = new System.Drawing.Point(273, 633);
            this.H_B.Name = "H_B";
            this.H_B.Size = new System.Drawing.Size(116, 116);
            this.H_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_B.TabIndex = 11;
            this.H_B.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(41, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "直方圖";
            // 
            // Result_Image_Box
            // 
            this.Result_Image_Box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Result_Image_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Image_Box.Location = new System.Drawing.Point(403, 77);
            this.Result_Image_Box.Name = "Result_Image_Box";
            this.Result_Image_Box.Size = new System.Drawing.Size(360, 360);
            this.Result_Image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_Image_Box.TabIndex = 2;
            this.Result_Image_Box.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(399, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result Image";
            // 
            // PhotoWH_R
            // 
            this.PhotoWH_R.AutoSize = true;
            this.PhotoWH_R.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhotoWH_R.Location = new System.Drawing.Point(680, 53);
            this.PhotoWH_R.Name = "PhotoWH_R";
            this.PhotoWH_R.Size = new System.Drawing.Size(39, 21);
            this.PhotoWH_R.TabIndex = 4;
            this.PhotoWH_R.Text = "0x0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(451, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "R";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(574, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "G";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(699, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "B";
            // 
            // O_R_Band_R
            // 
            this.O_R_Band_R.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_R_Band_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_R_Band_R.Location = new System.Drawing.Point(403, 471);
            this.O_R_Band_R.Name = "O_R_Band_R";
            this.O_R_Band_R.Size = new System.Drawing.Size(116, 116);
            this.O_R_Band_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_R_Band_R.TabIndex = 8;
            this.O_R_Band_R.TabStop = false;
            // 
            // O_G_Band_R
            // 
            this.O_G_Band_R.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_G_Band_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_G_Band_R.Location = new System.Drawing.Point(525, 471);
            this.O_G_Band_R.Name = "O_G_Band_R";
            this.O_G_Band_R.Size = new System.Drawing.Size(116, 116);
            this.O_G_Band_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_G_Band_R.TabIndex = 9;
            this.O_G_Band_R.TabStop = false;
            // 
            // O_B_Band_R
            // 
            this.O_B_Band_R.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.O_B_Band_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_B_Band_R.Location = new System.Drawing.Point(647, 471);
            this.O_B_Band_R.Name = "O_B_Band_R";
            this.O_B_Band_R.Size = new System.Drawing.Size(116, 116);
            this.O_B_Band_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_B_Band_R.TabIndex = 10;
            this.O_B_Band_R.TabStop = false;
            // 
            // H_R_R
            // 
            this.H_R_R.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_R_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_R_R.Location = new System.Drawing.Point(403, 633);
            this.H_R_R.Name = "H_R_R";
            this.H_R_R.Size = new System.Drawing.Size(116, 116);
            this.H_R_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_R_R.TabIndex = 11;
            this.H_R_R.TabStop = false;
            // 
            // H_G_R
            // 
            this.H_G_R.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_G_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_G_R.Location = new System.Drawing.Point(525, 633);
            this.H_G_R.Name = "H_G_R";
            this.H_G_R.Size = new System.Drawing.Size(116, 116);
            this.H_G_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_G_R.TabIndex = 11;
            this.H_G_R.TabStop = false;
            // 
            // H_B_R
            // 
            this.H_B_R.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_B_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_B_R.Location = new System.Drawing.Point(647, 633);
            this.H_B_R.Name = "H_B_R";
            this.H_B_R.Size = new System.Drawing.Size(116, 116);
            this.H_B_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_B_R.TabIndex = 11;
            this.H_B_R.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(415, 610);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Result 直方圖";
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.UndoButton.Location = new System.Drawing.Point(877, 12);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(74, 29);
            this.UndoButton.TabIndex = 14;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // OriginalButton
            // 
            this.OriginalButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.OriginalButton.Location = new System.Drawing.Point(784, 12);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.Size = new System.Drawing.Size(74, 29);
            this.OriginalButton.TabIndex = 15;
            this.OriginalButton.Text = "Original";
            this.OriginalButton.UseVisualStyleBackColor = true;
            this.OriginalButton.Click += new System.EventHandler(this.OriginalButton_Click);
            // 
            // MeanWeightButton
            // 
            this.MeanWeightButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MeanWeightButton.Location = new System.Drawing.Point(8, 44);
            this.MeanWeightButton.Name = "MeanWeightButton";
            this.MeanWeightButton.Size = new System.Drawing.Size(96, 37);
            this.MeanWeightButton.TabIndex = 0;
            this.MeanWeightButton.Text = "Mean-Weight";
            this.MeanWeightButton.UseVisualStyleBackColor = true;
            this.MeanWeightButton.Click += new System.EventHandler(this.MeanWeightButton_Click);
            // 
            // MeanValueButton
            // 
            this.MeanValueButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MeanValueButton.Location = new System.Drawing.Point(110, 44);
            this.MeanValueButton.Name = "MeanValueButton";
            this.MeanValueButton.Size = new System.Drawing.Size(96, 37);
            this.MeanValueButton.TabIndex = 0;
            this.MeanValueButton.Text = "Mean-Value";
            this.MeanValueButton.UseVisualStyleBackColor = true;
            this.MeanValueButton.Click += new System.EventHandler(this.MeanValueButton_Click);
            // 
            // MaximumButton
            // 
            this.MaximumButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaximumButton.Location = new System.Drawing.Point(212, 44);
            this.MaximumButton.Name = "MaximumButton";
            this.MaximumButton.Size = new System.Drawing.Size(96, 37);
            this.MaximumButton.TabIndex = 0;
            this.MaximumButton.Text = "Maximum";
            this.MaximumButton.UseVisualStyleBackColor = true;
            this.MaximumButton.Click += new System.EventHandler(this.MaximumButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.EqualizationButton);
            this.panel1.Controls.Add(this.MaxFilterButton);
            this.panel1.Controls.Add(this.GammaButton);
            this.panel1.Controls.Add(this.MedFilterButton);
            this.panel1.Controls.Add(this.MeanFilterButton);
            this.panel1.Controls.Add(this.LaplacianA9Button);
            this.panel1.Controls.Add(this.LaplacianA4Button);
            this.panel1.Controls.Add(this.LaplacianM9Button);
            this.panel1.Controls.Add(this.Laplacian9Button);
            this.panel1.Controls.Add(this.LaplacianM4Button);
            this.panel1.Controls.Add(this.SobelButton);
            this.panel1.Controls.Add(this.Laplacian4Button);
            this.panel1.Controls.Add(this.MinFilterButton);
            this.panel1.Controls.Add(this.LogButton);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.NegativeButton);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MaximumButton);
            this.panel1.Controls.Add(this.MeanValueButton);
            this.panel1.Controls.Add(this.MeanWeightButton);
            this.panel1.Location = new System.Drawing.Point(784, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 568);
            this.panel1.TabIndex = 16;
            // 
            // EqualizationButton
            // 
            this.EqualizationButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EqualizationButton.Location = new System.Drawing.Point(8, 176);
            this.EqualizationButton.Name = "EqualizationButton";
            this.EqualizationButton.Size = new System.Drawing.Size(96, 37);
            this.EqualizationButton.TabIndex = 17;
            this.EqualizationButton.Text = "Equalization";
            this.EqualizationButton.UseVisualStyleBackColor = true;
            this.EqualizationButton.Click += new System.EventHandler(this.EqualizationButton_Click);
            // 
            // MaxFilterButton
            // 
            this.MaxFilterButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxFilterButton.Location = new System.Drawing.Point(212, 271);
            this.MaxFilterButton.Name = "MaxFilterButton";
            this.MaxFilterButton.Size = new System.Drawing.Size(96, 37);
            this.MaxFilterButton.TabIndex = 17;
            this.MaxFilterButton.Text = "Maximum";
            this.MaxFilterButton.UseVisualStyleBackColor = true;
            this.MaxFilterButton.Click += new System.EventHandler(this.MaxFilterButton_Click);
            // 
            // GammaButton
            // 
            this.GammaButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GammaButton.Location = new System.Drawing.Point(212, 133);
            this.GammaButton.Name = "GammaButton";
            this.GammaButton.Size = new System.Drawing.Size(96, 37);
            this.GammaButton.TabIndex = 17;
            this.GammaButton.Text = "Gamma";
            this.GammaButton.UseVisualStyleBackColor = true;
            this.GammaButton.Click += new System.EventHandler(this.GammaButton_Click);
            // 
            // MedFilterButton
            // 
            this.MedFilterButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MedFilterButton.Location = new System.Drawing.Point(110, 271);
            this.MedFilterButton.Name = "MedFilterButton";
            this.MedFilterButton.Size = new System.Drawing.Size(96, 37);
            this.MedFilterButton.TabIndex = 17;
            this.MedFilterButton.Text = "Median";
            this.MedFilterButton.UseVisualStyleBackColor = true;
            this.MedFilterButton.Click += new System.EventHandler(this.MedFilterButton_Click);
            // 
            // MeanFilterButton
            // 
            this.MeanFilterButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MeanFilterButton.Location = new System.Drawing.Point(8, 314);
            this.MeanFilterButton.Name = "MeanFilterButton";
            this.MeanFilterButton.Size = new System.Drawing.Size(96, 37);
            this.MeanFilterButton.TabIndex = 17;
            this.MeanFilterButton.Text = "Mean";
            this.MeanFilterButton.UseVisualStyleBackColor = true;
            this.MeanFilterButton.Click += new System.EventHandler(this.MeanFilterButton_Click);
            // 
            // MinFilterButton
            // 
            this.MinFilterButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinFilterButton.Location = new System.Drawing.Point(8, 271);
            this.MinFilterButton.Name = "MinFilterButton";
            this.MinFilterButton.Size = new System.Drawing.Size(96, 37);
            this.MinFilterButton.TabIndex = 17;
            this.MinFilterButton.Text = "Minimum";
            this.MinFilterButton.UseVisualStyleBackColor = true;
            this.MinFilterButton.Click += new System.EventHandler(this.MinFilterButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogButton.Location = new System.Drawing.Point(110, 133);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(96, 37);
            this.LogButton.TabIndex = 17;
            this.LogButton.Text = "Logarithmic";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(12, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Space Filter";
            // 
            // NegativeButton
            // 
            this.NegativeButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NegativeButton.Location = new System.Drawing.Point(8, 133);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(96, 37);
            this.NegativeButton.TabIndex = 17;
            this.NegativeButton.Text = "Negative";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(12, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Contrast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "GrayScale";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(12, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Edge Detection";
            // 
            // Laplacian4Button
            // 
            this.Laplacian4Button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Laplacian4Button.Location = new System.Drawing.Point(8, 446);
            this.Laplacian4Button.Name = "Laplacian4Button";
            this.Laplacian4Button.Size = new System.Drawing.Size(96, 37);
            this.Laplacian4Button.TabIndex = 17;
            this.Laplacian4Button.Text = "Laplacian (4)";
            this.Laplacian4Button.UseVisualStyleBackColor = true;
            this.Laplacian4Button.Click += new System.EventHandler(this.Laplacian4Button_Click);
            // 
            // LaplacianM4Button
            // 
            this.LaplacianM4Button.Font = new System.Drawing.Font("微軟正黑體", 6.5F);
            this.LaplacianM4Button.Location = new System.Drawing.Point(212, 446);
            this.LaplacianM4Button.Name = "LaplacianM4Button";
            this.LaplacianM4Button.Size = new System.Drawing.Size(96, 37);
            this.LaplacianM4Button.TabIndex = 17;
            this.LaplacianM4Button.Text = "Laplacian minus (4)";
            this.LaplacianM4Button.UseVisualStyleBackColor = true;
            this.LaplacianM4Button.Click += new System.EventHandler(this.LaplacianM4Button_Click);
            // 
            // LaplacianA4Button
            // 
            this.LaplacianA4Button.Font = new System.Drawing.Font("微軟正黑體", 6.5F);
            this.LaplacianA4Button.Location = new System.Drawing.Point(110, 446);
            this.LaplacianA4Button.Name = "LaplacianA4Button";
            this.LaplacianA4Button.Size = new System.Drawing.Size(96, 37);
            this.LaplacianA4Button.TabIndex = 17;
            this.LaplacianA4Button.Text = "Laplacian add (4)";
            this.LaplacianA4Button.UseVisualStyleBackColor = true;
            this.LaplacianA4Button.Click += new System.EventHandler(this.LaplacianA4Button_Click);
            // 
            // Laplacian9Button
            // 
            this.Laplacian9Button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Laplacian9Button.Location = new System.Drawing.Point(8, 489);
            this.Laplacian9Button.Name = "Laplacian9Button";
            this.Laplacian9Button.Size = new System.Drawing.Size(96, 37);
            this.Laplacian9Button.TabIndex = 17;
            this.Laplacian9Button.Text = "Laplacian (9)";
            this.Laplacian9Button.UseVisualStyleBackColor = true;
            this.Laplacian9Button.Click += new System.EventHandler(this.Laplacian9Button_Click);
            // 
            // LaplacianM9Button
            // 
            this.LaplacianM9Button.Font = new System.Drawing.Font("微軟正黑體", 6.5F);
            this.LaplacianM9Button.Location = new System.Drawing.Point(212, 489);
            this.LaplacianM9Button.Name = "LaplacianM9Button";
            this.LaplacianM9Button.Size = new System.Drawing.Size(96, 37);
            this.LaplacianM9Button.TabIndex = 17;
            this.LaplacianM9Button.Text = "Laplacian minus (9)";
            this.LaplacianM9Button.UseVisualStyleBackColor = true;
            this.LaplacianM9Button.Click += new System.EventHandler(this.LaplacianM9Button_Click);
            // 
            // LaplacianA9Button
            // 
            this.LaplacianA9Button.Font = new System.Drawing.Font("微軟正黑體", 6.5F);
            this.LaplacianA9Button.Location = new System.Drawing.Point(110, 490);
            this.LaplacianA9Button.Name = "LaplacianA9Button";
            this.LaplacianA9Button.Size = new System.Drawing.Size(96, 37);
            this.LaplacianA9Button.TabIndex = 17;
            this.LaplacianA9Button.Text = "Laplacian add (9)";
            this.LaplacianA9Button.UseVisualStyleBackColor = true;
            this.LaplacianA9Button.Click += new System.EventHandler(this.LaplacianA9Button_Click);
            // 
            // SobelButton
            // 
            this.SobelButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SobelButton.Location = new System.Drawing.Point(8, 403);
            this.SobelButton.Name = "SobelButton";
            this.SobelButton.Size = new System.Drawing.Size(96, 37);
            this.SobelButton.TabIndex = 17;
            this.SobelButton.Text = "Sobel";
            this.SobelButton.UseVisualStyleBackColor = true;
            this.SobelButton.Click += new System.EventHandler(this.SobelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OriginalButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.H_B_R);
            this.Controls.Add(this.H_B);
            this.Controls.Add(this.H_G_R);
            this.Controls.Add(this.H_G);
            this.Controls.Add(this.H_R_R);
            this.Controls.Add(this.H_R);
            this.Controls.Add(this.O_B_Band_R);
            this.Controls.Add(this.O_G_Band_R);
            this.Controls.Add(this.O_B_Band);
            this.Controls.Add(this.O_R_Band_R);
            this.Controls.Add(this.O_G_Band);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.O_R_Band);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhotoWH_R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhotoWH);
            this.Controls.Add(this.Result_Image_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original_Image_Box);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Original_Image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_R)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox Original_Image_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PhotoWH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox O_R_Band;
        private System.Windows.Forms.PictureBox O_G_Band;
        private System.Windows.Forms.PictureBox O_B_Band;
        private System.Windows.Forms.PictureBox H_R;
        private System.Windows.Forms.PictureBox H_G;
        private System.Windows.Forms.PictureBox H_B;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Result_Image_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PhotoWH_R;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox O_R_Band_R;
        private System.Windows.Forms.PictureBox O_G_Band_R;
        private System.Windows.Forms.PictureBox O_B_Band_R;
        private System.Windows.Forms.PictureBox H_R_R;
        private System.Windows.Forms.PictureBox H_G_R;
        private System.Windows.Forms.PictureBox H_B_R;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button OriginalButton;
        private System.Windows.Forms.Button MaximumButton;
        private System.Windows.Forms.Button MeanValueButton;
        private System.Windows.Forms.Button MeanWeightButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button GammaButton;
        private System.Windows.Forms.Button EqualizationButton;
        private System.Windows.Forms.Button MaxFilterButton;
        private System.Windows.Forms.Button MedFilterButton;
        private System.Windows.Forms.Button MeanFilterButton;
        private System.Windows.Forms.Button MinFilterButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button LaplacianA9Button;
        private System.Windows.Forms.Button LaplacianA4Button;
        private System.Windows.Forms.Button LaplacianM9Button;
        private System.Windows.Forms.Button Laplacian9Button;
        private System.Windows.Forms.Button LaplacianM4Button;
        private System.Windows.Forms.Button SobelButton;
        private System.Windows.Forms.Button Laplacian4Button;
        private System.Windows.Forms.Label label14;
    }
}

