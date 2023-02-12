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
            this.orgImage = new System.Windows.Forms.PictureBox();
            this.Avarage = new System.Windows.Forms.PictureBox();
            this.Lightness = new System.Windows.Forms.PictureBox();
            this.Luminance = new System.Windows.Forms.PictureBox();
            this.Image = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avarage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImage
            // 
            this.orgImage.Location = new System.Drawing.Point(25, 46);
            this.orgImage.Name = "orgImage";
            this.orgImage.Size = new System.Drawing.Size(270, 270);
            this.orgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImage.TabIndex = 0;
            this.orgImage.TabStop = false;
            // 
            // Avarage
            // 
            this.Avarage.Location = new System.Drawing.Point(379, 46);
            this.Avarage.Name = "Avarage";
            this.Avarage.Size = new System.Drawing.Size(270, 270);
            this.Avarage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avarage.TabIndex = 1;
            this.Avarage.TabStop = false;
            // 
            // Lightness
            // 
            this.Lightness.Location = new System.Drawing.Point(25, 373);
            this.Lightness.Name = "Lightness";
            this.Lightness.Size = new System.Drawing.Size(270, 270);
            this.Lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lightness.TabIndex = 2;
            this.Lightness.TabStop = false;
            // 
            // Luminance
            // 
            this.Luminance.Location = new System.Drawing.Point(379, 373);
            this.Luminance.Name = "Luminance";
            this.Luminance.Size = new System.Drawing.Size(270, 270);
            this.Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Luminance.TabIndex = 3;
            this.Luminance.TabStop = false;
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Location = new System.Drawing.Point(22, 18);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(45, 16);
            this.Image.TabIndex = 4;
            this.Image.Text = "Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Luminance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Luminance);
            this.Controls.Add(this.Lightness);
            this.Controls.Add(this.Avarage);
            this.Controls.Add(this.orgImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avarage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImage;
        private System.Windows.Forms.PictureBox Avarage;
        private System.Windows.Forms.PictureBox Lightness;
        private System.Windows.Forms.PictureBox Luminance;
        private System.Windows.Forms.Label Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

