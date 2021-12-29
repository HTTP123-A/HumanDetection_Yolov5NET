
namespace GUI_Interface
{
    partial class Object_Detection_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Detect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Directory = new System.Windows.Forms.TextBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Image2Detect = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image2Detect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 474);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Detect);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 30);
            this.panel4.TabIndex = 1;
            // 
            // btn_Detect
            // 
            this.btn_Detect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Detect.Location = new System.Drawing.Point(0, 0);
            this.btn_Detect.Name = "btn_Detect";
            this.btn_Detect.Size = new System.Drawing.Size(75, 30);
            this.btn_Detect.TabIndex = 0;
            this.btn_Detect.Text = "Detect";
            this.btn_Detect.UseVisualStyleBackColor = true;
            this.btn_Detect.Click += new System.EventHandler(this.btn_Detect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_Directory);
            this.panel3.Controls.Add(this.btn_LoadImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 30);
            this.panel3.TabIndex = 0;
            // 
            // textBox_Directory
            // 
            this.textBox_Directory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Directory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Directory.Location = new System.Drawing.Point(75, 0);
            this.textBox_Directory.Name = "textBox_Directory";
            this.textBox_Directory.Size = new System.Drawing.Size(175, 27);
            this.textBox_Directory.TabIndex = 1;
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LoadImage.Location = new System.Drawing.Point(0, 0);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(75, 30);
            this.btn_LoadImage.TabIndex = 0;
            this.btn_LoadImage.Text = "Load";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_Image2Detect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 474);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox_Image2Detect
            // 
            this.pictureBox_Image2Detect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image2Detect.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Image2Detect.Name = "pictureBox_Image2Detect";
            this.pictureBox_Image2Detect.Size = new System.Drawing.Size(705, 474);
            this.pictureBox_Image2Detect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image2Detect.TabIndex = 0;
            this.pictureBox_Image2Detect.TabStop = false;
            // 
            // Object_Detection_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Object_Detection_GUI";
            this.Text = "Object_Detection_GUI";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image2Detect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_Image2Detect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_Directory;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Detect;
    }
}