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
            this.frameY = new System.Windows.Forms.PictureBox();
            this.frameX = new System.Windows.Forms.PictureBox();
            this.xyzImage = new System.Windows.Forms.PictureBox();
            this.frameZ = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameZ)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImage
            // 
            this.orgImage.Location = new System.Drawing.Point(36, 45);
            this.orgImage.Name = "orgImage";
            this.orgImage.Size = new System.Drawing.Size(270, 270);
            this.orgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImage.TabIndex = 0;
            this.orgImage.TabStop = false;
            // 
            // frameY
            // 
            this.frameY.Location = new System.Drawing.Point(174, 393);
            this.frameY.Name = "frameY";
            this.frameY.Size = new System.Drawing.Size(270, 270);
            this.frameY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameY.TabIndex = 1;
            this.frameY.TabStop = false;
            // 
            // frameX
            // 
            this.frameX.Location = new System.Drawing.Point(667, 45);
            this.frameX.Name = "frameX";
            this.frameX.Size = new System.Drawing.Size(270, 270);
            this.frameX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameX.TabIndex = 2;
            this.frameX.TabStop = false;
            // 
            // xyzImage
            // 
            this.xyzImage.Location = new System.Drawing.Point(349, 45);
            this.xyzImage.Name = "xyzImage";
            this.xyzImage.Size = new System.Drawing.Size(270, 270);
            this.xyzImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xyzImage.TabIndex = 3;
            this.xyzImage.TabStop = false;
            // 
            // frameZ
            // 
            this.frameZ.Location = new System.Drawing.Point(532, 393);
            this.frameZ.Name = "frameZ";
            this.frameZ.Size = new System.Drawing.Size(270, 270);
            this.frameZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frameZ.TabIndex = 4;
            this.frameZ.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "org Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "XYZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frameZ);
            this.Controls.Add(this.xyzImage);
            this.Controls.Add(this.frameX);
            this.Controls.Add(this.frameY);
            this.Controls.Add(this.orgImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImage;
        private System.Windows.Forms.PictureBox frameY;
        private System.Windows.Forms.PictureBox frameX;
        private System.Windows.Forms.PictureBox xyzImage;
        private System.Windows.Forms.PictureBox frameZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

