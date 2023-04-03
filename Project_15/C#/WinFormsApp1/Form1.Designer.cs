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
            this.orgImg = new System.Windows.Forms.PictureBox();
            this.sobelImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thresh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImg)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImg
            // 
            this.orgImg.Location = new System.Drawing.Point(22, 56);
            this.orgImg.Name = "orgImg";
            this.orgImg.Size = new System.Drawing.Size(420, 420);
            this.orgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImg.TabIndex = 0;
            this.orgImg.TabStop = false;
            // 
            // sobelImg
            // 
            this.sobelImg.Location = new System.Drawing.Point(488, 56);
            this.sobelImg.Name = "sobelImg";
            this.sobelImg.Size = new System.Drawing.Size(420, 420);
            this.sobelImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sobelImg.TabIndex = 1;
            this.sobelImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sobel";
            // 
            // thresh
            // 
            this.thresh.Location = new System.Drawing.Point(317, 499);
            this.thresh.Name = "thresh";
            this.thresh.Size = new System.Drawing.Size(125, 27);
            this.thresh.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Threshold:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sobelImg);
            this.Controls.Add(this.orgImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox orgImg;
        private PictureBox sobelImg;
        private Label label1;
        private Label label2;
        private TextBox thresh;
        private Button button1;
        private Label label3;
    }
}