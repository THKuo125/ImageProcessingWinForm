﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_R)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(403, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 770);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}

