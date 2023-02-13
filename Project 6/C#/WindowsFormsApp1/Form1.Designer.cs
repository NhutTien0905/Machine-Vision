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
            this.Black = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.Magenta = new System.Windows.Forms.PictureBox();
            this.Cyan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyan)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImage
            // 
            this.orgImage.Location = new System.Drawing.Point(43, 48);
            this.orgImage.Name = "orgImage";
            this.orgImage.Size = new System.Drawing.Size(270, 270);
            this.orgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImage.TabIndex = 0;
            this.orgImage.TabStop = false;
            // 
            // Black
            // 
            this.Black.Location = new System.Drawing.Point(556, 391);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(270, 270);
            this.Black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Black.TabIndex = 1;
            this.Black.TabStop = false;
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(169, 391);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(270, 270);
            this.Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Yellow.TabIndex = 2;
            this.Yellow.TabStop = false;
            // 
            // Magenta
            // 
            this.Magenta.Location = new System.Drawing.Point(673, 48);
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(270, 270);
            this.Magenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Magenta.TabIndex = 3;
            this.Magenta.TabStop = false;
            // 
            // Cyan
            // 
            this.Cyan.Location = new System.Drawing.Point(356, 48);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(270, 270);
            this.Cyan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cyan.TabIndex = 4;
            this.Cyan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Black";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yellow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Magenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cyan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cyan);
            this.Controls.Add(this.Magenta);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.orgImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImage;
        private System.Windows.Forms.PictureBox Black;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.PictureBox Magenta;
        private System.Windows.Forms.PictureBox Cyan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

