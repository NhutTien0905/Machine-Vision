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
            this.hsv = new System.Windows.Forms.PictureBox();
            this.val = new System.Windows.Forms.PictureBox();
            this.satu = new System.Windows.Forms.PictureBox();
            this.hue = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImg
            // 
            this.orgImg.Location = new System.Drawing.Point(12, 45);
            this.orgImg.Name = "orgImg";
            this.orgImg.Size = new System.Drawing.Size(270, 270);
            this.orgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImg.TabIndex = 0;
            this.orgImg.TabStop = false;
            // 
            // hsv
            // 
            this.hsv.Location = new System.Drawing.Point(497, 395);
            this.hsv.Name = "hsv";
            this.hsv.Size = new System.Drawing.Size(270, 270);
            this.hsv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hsv.TabIndex = 1;
            this.hsv.TabStop = false;
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(172, 395);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(270, 270);
            this.val.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.val.TabIndex = 2;
            this.val.TabStop = false;
            // 
            // satu
            // 
            this.satu.Location = new System.Drawing.Point(662, 45);
            this.satu.Name = "satu";
            this.satu.Size = new System.Drawing.Size(270, 270);
            this.satu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.satu.TabIndex = 3;
            this.satu.TabStop = false;
            // 
            // hue
            // 
            this.hue.Location = new System.Drawing.Point(337, 45);
            this.hue.Name = "hue";
            this.hue.Size = new System.Drawing.Size(270, 270);
            this.hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hue.TabIndex = 4;
            this.hue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "HSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "SATURATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "HUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 677);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hue);
            this.Controls.Add(this.satu);
            this.Controls.Add(this.val);
            this.Controls.Add(this.hsv);
            this.Controls.Add(this.orgImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImg;
        private System.Windows.Forms.PictureBox hsv;
        private System.Windows.Forms.PictureBox val;
        private System.Windows.Forms.PictureBox satu;
        private System.Windows.Forms.PictureBox hue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

