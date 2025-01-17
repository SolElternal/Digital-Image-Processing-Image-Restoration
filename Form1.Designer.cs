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
            System.Windows.Forms.Button ImageShapening;
            System.Windows.Forms.Button MaxFilter;
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.OPENFOLDER = new System.Windows.Forms.Button();
            ImageShapening = new System.Windows.Forms.Button();
            MaxFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Image Smoothing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ImageShapening
            // 
            ImageShapening.Location = new System.Drawing.Point(420, 402);
            ImageShapening.Name = "ImageShapening";
            ImageShapening.Size = new System.Drawing.Size(118, 59);
            ImageShapening.TabIndex = 1;
            ImageShapening.Text = "Image Shapening";
            ImageShapening.UseVisualStyleBackColor = true;
            ImageShapening.Click += new System.EventHandler(this.ImageShapening_Click);
            // 
            // MaxFilter
            // 
            MaxFilter.Location = new System.Drawing.Point(575, 402);
            MaxFilter.Name = "MaxFilter";
            MaxFilter.Size = new System.Drawing.Size(118, 59);
            MaxFilter.TabIndex = 2;
            MaxFilter.Text = "MAX Filter";
            MaxFilter.UseVisualStyleBackColor = true;
            MaxFilter.Click += new System.EventHandler(this.MaxFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 269);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(512, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 269);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // OPENFOLDER
            // 
            this.OPENFOLDER.Location = new System.Drawing.Point(396, 503);
            this.OPENFOLDER.Name = "OPENFOLDER";
            this.OPENFOLDER.Size = new System.Drawing.Size(164, 47);
            this.OPENFOLDER.TabIndex = 5;
            this.OPENFOLDER.Text = "OPEN Folder";
            this.OPENFOLDER.UseVisualStyleBackColor = true;
            this.OPENFOLDER.Click += new System.EventHandler(this.OPENFOLDER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 590);
            this.Controls.Add(this.OPENFOLDER);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(MaxFilter);
            this.Controls.Add(ImageShapening);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button OPENFOLDER;
    }
}

