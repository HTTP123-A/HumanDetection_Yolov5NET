
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
            this.panel_Stop = new System.Windows.Forms.Panel();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.panel_Cam = new System.Windows.Forms.Panel();
            this.Combo_Camera_Device = new System.Windows.Forms.ComboBox();
            this.btn_Camera = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_COMstatus = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_PersonCount = new System.Windows.Forms.TextBox();
            this.btn_Detect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Directory = new System.Windows.Forms.TextBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Image2Detect = new System.Windows.Forms.PictureBox();
            this.cb_ON = new System.Windows.Forms.CheckBox();
            this.cb_OFF = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel_Stop.SuspendLayout();
            this.panel_Cam.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image2Detect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Stop);
            this.panel1.Controls.Add(this.panel_Cam);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 474);
            this.panel1.TabIndex = 0;
            // 
            // panel_Stop
            // 
            this.panel_Stop.Controls.Add(this.cb_OFF);
            this.panel_Stop.Controls.Add(this.cb_ON);
            this.panel_Stop.Controls.Add(this.btn_Stop);
            this.panel_Stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Stop.Location = new System.Drawing.Point(0, 90);
            this.panel_Stop.Name = "panel_Stop";
            this.panel_Stop.Size = new System.Drawing.Size(250, 30);
            this.panel_Stop.TabIndex = 5;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Stop.Location = new System.Drawing.Point(0, 0);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 30);
            this.btn_Stop.TabIndex = 0;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panel_Cam
            // 
            this.panel_Cam.Controls.Add(this.Combo_Camera_Device);
            this.panel_Cam.Controls.Add(this.btn_Camera);
            this.panel_Cam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Cam.Location = new System.Drawing.Point(0, 60);
            this.panel_Cam.Name = "panel_Cam";
            this.panel_Cam.Size = new System.Drawing.Size(250, 30);
            this.panel_Cam.TabIndex = 3;
            // 
            // Combo_Camera_Device
            // 
            this.Combo_Camera_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Combo_Camera_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Camera_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Camera_Device.FormattingEnabled = true;
            this.Combo_Camera_Device.Location = new System.Drawing.Point(75, 0);
            this.Combo_Camera_Device.Name = "Combo_Camera_Device";
            this.Combo_Camera_Device.Size = new System.Drawing.Size(175, 28);
            this.Combo_Camera_Device.TabIndex = 1;
            // 
            // btn_Camera
            // 
            this.btn_Camera.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Camera.Location = new System.Drawing.Point(0, 0);
            this.btn_Camera.Name = "btn_Camera";
            this.btn_Camera.Size = new System.Drawing.Size(75, 30);
            this.btn_Camera.TabIndex = 0;
            this.btn_Camera.Text = "Camera";
            this.btn_Camera.UseVisualStyleBackColor = true;
            this.btn_Camera.Click += new System.EventHandler(this.btn_Camera_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_Status);
            this.panel5.Controls.Add(this.textBox_COMstatus);
            this.panel5.Controls.Add(this.btn_Connect);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 414);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 60);
            this.panel5.TabIndex = 2;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Status.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Status.Location = new System.Drawing.Point(81, 29);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(169, 31);
            this.textBox_Status.TabIndex = 2;
            // 
            // textBox_COMstatus
            // 
            this.textBox_COMstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_COMstatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_COMstatus.Location = new System.Drawing.Point(81, 0);
            this.textBox_COMstatus.Name = "textBox_COMstatus";
            this.textBox_COMstatus.ReadOnly = true;
            this.textBox_COMstatus.Size = new System.Drawing.Size(169, 27);
            this.textBox_COMstatus.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Connect.Location = new System.Drawing.Point(0, 0);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 60);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect!";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_PersonCount);
            this.panel4.Controls.Add(this.btn_Detect);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 30);
            this.panel4.TabIndex = 1;
            // 
            // textBox_PersonCount
            // 
            this.textBox_PersonCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PersonCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PersonCount.Location = new System.Drawing.Point(75, 0);
            this.textBox_PersonCount.Name = "textBox_PersonCount";
            this.textBox_PersonCount.ReadOnly = true;
            this.textBox_PersonCount.Size = new System.Drawing.Size(175, 27);
            this.textBox_PersonCount.TabIndex = 1;
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
            this.textBox_Directory.ReadOnly = true;
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
            // cb_ON
            // 
            this.cb_ON.AutoSize = true;
            this.cb_ON.Location = new System.Drawing.Point(82, 7);
            this.cb_ON.Name = "cb_ON";
            this.cb_ON.Size = new System.Drawing.Size(76, 17);
            this.cb_ON.TabIndex = 1;
            this.cb_ON.Text = "TURN ON";
            this.cb_ON.UseVisualStyleBackColor = true;
            // 
            // cb_OFF
            // 
            this.cb_OFF.AutoSize = true;
            this.cb_OFF.Location = new System.Drawing.Point(169, 7);
            this.cb_OFF.Name = "cb_OFF";
            this.cb_OFF.Size = new System.Drawing.Size(80, 17);
            this.cb_OFF.TabIndex = 2;
            this.cb_OFF.Text = "TURN OFF";
            this.cb_OFF.UseVisualStyleBackColor = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Object_Detection_GUI_FormClosing);
            this.Load += new System.EventHandler(this.Object_Detection_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Stop.ResumeLayout(false);
            this.panel_Stop.PerformLayout();
            this.panel_Cam.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_PersonCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_COMstatus;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Panel panel_Cam;
        private System.Windows.Forms.Button btn_Camera;
        private System.Windows.Forms.ComboBox Combo_Camera_Device;
        private System.Windows.Forms.Panel panel_Stop;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.CheckBox cb_OFF;
        private System.Windows.Forms.CheckBox cb_ON;
    }
}