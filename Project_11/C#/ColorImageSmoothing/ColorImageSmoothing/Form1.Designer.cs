namespace ColorImageSmoothing
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.picBoxSmoothedImage3x3 = new System.Windows.Forms.PictureBox();
            this.HinhGoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxSmoothedImage5x5 = new System.Windows.Forms.PictureBox();
            this.picBoxSmoothedImage7x7 = new System.Windows.Forms.PictureBox();
            this.picBoxSmoothedImage9x9 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage3x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage5x5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage7x7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage9x9)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(12, 25);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(300, 300);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // picBoxSmoothedImage3x3
            // 
            this.picBoxSmoothedImage3x3.Location = new System.Drawing.Point(329, 25);
            this.picBoxSmoothedImage3x3.Name = "picBoxSmoothedImage3x3";
            this.picBoxSmoothedImage3x3.Size = new System.Drawing.Size(300, 300);
            this.picBoxSmoothedImage3x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSmoothedImage3x3.TabIndex = 1;
            this.picBoxSmoothedImage3x3.TabStop = false;
            // 
            // HinhGoc
            // 
            this.HinhGoc.AutoSize = true;
            this.HinhGoc.Location = new System.Drawing.Point(12, 9);
            this.HinhGoc.Name = "HinhGoc";
            this.HinhGoc.Size = new System.Drawing.Size(49, 13);
            this.HinhGoc.TabIndex = 2;
            this.HinhGoc.Text = "HinhGoc";
            this.HinhGoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hinh lam muot 3x3";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picBoxSmoothedImage5x5
            // 
            this.picBoxSmoothedImage5x5.Location = new System.Drawing.Point(647, 25);
            this.picBoxSmoothedImage5x5.Name = "picBoxSmoothedImage5x5";
            this.picBoxSmoothedImage5x5.Size = new System.Drawing.Size(300, 300);
            this.picBoxSmoothedImage5x5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSmoothedImage5x5.TabIndex = 4;
            this.picBoxSmoothedImage5x5.TabStop = false;
            // 
            // picBoxSmoothedImage7x7
            // 
            this.picBoxSmoothedImage7x7.Location = new System.Drawing.Point(171, 367);
            this.picBoxSmoothedImage7x7.Name = "picBoxSmoothedImage7x7";
            this.picBoxSmoothedImage7x7.Size = new System.Drawing.Size(300, 300);
            this.picBoxSmoothedImage7x7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSmoothedImage7x7.TabIndex = 5;
            this.picBoxSmoothedImage7x7.TabStop = false;
            // 
            // picBoxSmoothedImage9x9
            // 
            this.picBoxSmoothedImage9x9.Location = new System.Drawing.Point(491, 367);
            this.picBoxSmoothedImage9x9.Name = "picBoxSmoothedImage9x9";
            this.picBoxSmoothedImage9x9.Size = new System.Drawing.Size(300, 300);
            this.picBoxSmoothedImage9x9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSmoothedImage9x9.TabIndex = 6;
            this.picBoxSmoothedImage9x9.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hinh lam muot 5x5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hinh lam muot 7x7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hinh lam muot 9x9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 711);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxSmoothedImage9x9);
            this.Controls.Add(this.picBoxSmoothedImage7x7);
            this.Controls.Add(this.picBoxSmoothedImage5x5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HinhGoc);
            this.Controls.Add(this.picBoxSmoothedImage3x3);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage3x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage5x5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage7x7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmoothedImage9x9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.PictureBox picBoxSmoothedImage3x3;
        private System.Windows.Forms.Label HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxSmoothedImage5x5;
        private System.Windows.Forms.PictureBox picBoxSmoothedImage7x7;
        private System.Windows.Forms.PictureBox picBoxSmoothedImage9x9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

