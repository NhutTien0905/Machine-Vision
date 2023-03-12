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
            this.shapenedImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapenedImg)).BeginInit();
            this.SuspendLayout();
            // 
            // orgImg
            // 
            this.orgImg.Location = new System.Drawing.Point(24, 69);
            this.orgImg.Name = "orgImg";
            this.orgImg.Size = new System.Drawing.Size(512, 512);
            this.orgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImg.TabIndex = 0;
            this.orgImg.TabStop = false;
            // 
            // shapenedImg
            // 
            this.shapenedImg.Location = new System.Drawing.Point(593, 69);
            this.shapenedImg.Name = "shapenedImg";
            this.shapenedImg.Size = new System.Drawing.Size(512, 512);
            this.shapenedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shapenedImg.TabIndex = 1;
            this.shapenedImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shapened Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapenedImg);
            this.Controls.Add(this.orgImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapenedImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orgImg;
        private System.Windows.Forms.PictureBox shapenedImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

