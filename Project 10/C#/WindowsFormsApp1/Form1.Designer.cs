namespace WindowsFormsApp1
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
            this.orgImg = new System.Windows.Forms.PictureBox();
            this.YCrCb = new System.Windows.Forms.PictureBox();
            this.Cb = new System.Windows.Forms.PictureBox();
            this.Cr = new System.Windows.Forms.PictureBox();
            this.Y = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCrCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImg
            // 
            this.orgImg.Location = new System.Drawing.Point(28, 37);
            this.orgImg.Name = "orgImg";
            this.orgImg.Size = new System.Drawing.Size(270, 270);
            this.orgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImg.TabIndex = 0;
            this.orgImg.TabStop = false;
            // 
            // YCrCb
            // 
            this.YCrCb.Location = new System.Drawing.Point(542, 355);
            this.YCrCb.Name = "YCrCb";
            this.YCrCb.Size = new System.Drawing.Size(270, 270);
            this.YCrCb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YCrCb.TabIndex = 1;
            this.YCrCb.TabStop = false;
            // 
            // Cb
            // 
            this.Cb.Location = new System.Drawing.Point(195, 355);
            this.Cb.Name = "Cb";
            this.Cb.Size = new System.Drawing.Size(270, 270);
            this.Cb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cb.TabIndex = 2;
            this.Cb.TabStop = false;
            // 
            // Cr
            // 
            this.Cr.Location = new System.Drawing.Point(690, 37);
            this.Cr.Name = "Cr";
            this.Cr.Size = new System.Drawing.Size(270, 270);
            this.Cr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cr.TabIndex = 3;
            this.Cr.TabStop = false;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(361, 37);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(270, 270);
            this.Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Y.TabIndex = 4;
            this.Y.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "YCrCb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 637);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.Cr);
            this.Controls.Add(this.Cb);
            this.Controls.Add(this.YCrCb);
            this.Controls.Add(this.orgImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YCrCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImg;
        private System.Windows.Forms.PictureBox YCrCb;
        private System.Windows.Forms.PictureBox Cb;
        private System.Windows.Forms.PictureBox Cr;
        private System.Windows.Forms.PictureBox Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

