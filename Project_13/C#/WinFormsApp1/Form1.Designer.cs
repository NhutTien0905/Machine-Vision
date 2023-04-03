namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orgimg = new System.Windows.Forms.PictureBox();
            this.segImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.point1X = new System.Windows.Forms.TextBox();
            this.thresh = new System.Windows.Forms.TextBox();
            this.point2Y = new System.Windows.Forms.TextBox();
            this.point2X = new System.Windows.Forms.TextBox();
            this.point1Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orgimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segImg)).BeginInit();
            this.SuspendLayout();
            // 
            // orgimg
            // 
            this.orgimg.Location = new System.Drawing.Point(24, 76);
            this.orgimg.Name = "orgimg";
            this.orgimg.Size = new System.Drawing.Size(400, 400);
            this.orgimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgimg.TabIndex = 0;
            this.orgimg.TabStop = false;
            // 
            // segImg
            // 
            this.segImg.Location = new System.Drawing.Point(449, 76);
            this.segImg.Name = "segImg";
            this.segImg.Size = new System.Drawing.Size(400, 400);
            this.segImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.segImg.TabIndex = 1;
            this.segImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segmented Image";
            // 
            // point1X
            // 
            this.point1X.Location = new System.Drawing.Point(24, 507);
            this.point1X.Name = "point1X";
            this.point1X.Size = new System.Drawing.Size(125, 27);
            this.point1X.TabIndex = 5;
            // 
            // thresh
            // 
            this.thresh.Location = new System.Drawing.Point(382, 507);
            this.thresh.Name = "thresh";
            this.thresh.Size = new System.Drawing.Size(125, 27);
            this.thresh.TabIndex = 6;
            // 
            // point2Y
            // 
            this.point2Y.Location = new System.Drawing.Point(202, 571);
            this.point2Y.Name = "point2Y";
            this.point2Y.Size = new System.Drawing.Size(125, 27);
            this.point2Y.TabIndex = 7;
            // 
            // point2X
            // 
            this.point2X.Location = new System.Drawing.Point(202, 507);
            this.point2X.Name = "point2X";
            this.point2X.Size = new System.Drawing.Size(125, 27);
            this.point2X.TabIndex = 8;
            // 
            // point1Y
            // 
            this.point1Y.Location = new System.Drawing.Point(24, 571);
            this.point1Y.Name = "point1Y";
            this.point1Y.Size = new System.Drawing.Size(125, 27);
            this.point1Y.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Threshold";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "x2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "y1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(382, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Convert Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.point1Y);
            this.Controls.Add(this.point2X);
            this.Controls.Add(this.point2Y);
            this.Controls.Add(this.thresh);
            this.Controls.Add(this.point1X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.segImg);
            this.Controls.Add(this.orgimg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox orgimg;
        private PictureBox segImg;
        private Label label1;
        private Label label2;
        private TextBox point1X;
        private TextBox thresh;
        private TextBox point2Y;
        private TextBox point2X;
        private TextBox point1Y;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}