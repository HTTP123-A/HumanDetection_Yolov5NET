using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Timers;
using System.Management;


namespace GUI_Interface
{
    public partial class Object_Detection_GUI : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice device_Cam;
        Image Raw_Image;
        Image Image_From_Cam;
        private static System.Timers.Timer Timer_A;

        string Directory;
        string device_ID_toConnect;
        int person_count = 0;
        int empty_count = 0;
        bool cam_sel = false;
        bool light = false;
        

        public Object_Detection_GUI()
        {
            InitializeComponent();
            this.cb_OFF.Checked = true;
            this.cb_ON.Checked = false;
        }

        private void Object_Detection_GUI_Load(object sender, EventArgs e)
        {
            device_ID_toConnect = AutoDetect_Arduino();
            if (device_ID_toConnect != null)
            {
                this.textBox_COMstatus.Text = device_ID_toConnect;
                this.textBox_Status.Text = "Disconnect!";
                this.textBox_Status.ForeColor = Color.Red;
            }

            this.btn_LoadImage.Enabled = false;
            this.btn_Detect.Enabled = false;
            this.btn_Camera.Enabled = false;
            this.btn_Stop.Enabled = false;

            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device_Cam in filter)
                this.Combo_Camera_Device.Items.Add(device_Cam.Name);
            this.Combo_Camera_Device.SelectedIndex = 0;
            this.device_Cam = new VideoCaptureDevice();
            Timer_A = new System.Timers.Timer();
            Timer_A.Interval = 1000;

        }

        #region Button Controls

        #region Load static image to test the detector program
        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            cam_sel = false;
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
            OpenFileDialog Image_Loading = new OpenFileDialog();
            Image_Loading.Filter = "Image Filter(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (Image_Loading.ShowDialog() == DialogResult.OK)
            {
                Directory = Image_Loading.FileName;
                textBox_Directory.Text = Directory;
                pictureBox_Image2Detect.Image = new Bitmap(Directory);
            }
        }
        #endregion

        #region Method of detecting through webcam <== main working place
        
        private void btn_Camera_Click(object sender, EventArgs e)
        {
            this.btn_Stop.Enabled = true;
            this.btn_Camera.Enabled = false;

            Timer_A.Elapsed += One_Second;
            Timer_A.AutoReset = true;
            Timer_A.Enabled = true;

            cam_sel = true;
            this.device_Cam = new VideoCaptureDevice(filter[this.Combo_Camera_Device.SelectedIndex].MonikerString);
            device_Cam.NewFrame += Device_NewFrame;
            device_Cam.Start();            
                       
        }

        private void One_Second(Object source, System.Timers.ElapsedEventArgs e) //Trigger human detection event every 1 second
        {
            Console.WriteLine("Hihi");
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
            if (Raw_Image != null)
            {
                Image_From_Cam = (Image)Raw_Image.Clone();
                Detect();
                Console.WriteLine(person_count + " person");

                if (person_count == 0)
                {
                    if (empty_count == 5) empty_count = 5;
                    else empty_count++;
                }
                else empty_count = 0;

                if (light == true) serialPort1.Write("1");
                else serialPort1.Write("0");

                Console.WriteLine("LIGHT STATUS: " + light);
            }
            

            device_Cam.Start();
            Console.WriteLine("Haha");
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (Raw_Image != null) Raw_Image.Dispose();
            Raw_Image = (Image)eventArgs.Frame.Clone();
            this.pictureBox_Image2Detect.Image = Raw_Image;

            if ((empty_count == 5) && (person_count == 0)) { light = false; this.cb_OFF.Checked = true; this.cb_ON.Checked = false; }
            else { light = true; this.cb_OFF.Checked = false; this.cb_ON.Checked = true; }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (this.device_Cam.IsRunning)                           
                this.device_Cam.Stop();                           
            this.pictureBox_Image2Detect.Image = null;
            if (Image_From_Cam != null) Image_From_Cam.Dispose();
            cam_sel = false;
            Timer_A.Enabled = false;

            if (serialPort1.IsOpen)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }
    

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = device_ID_toConnect;
                    serialPort1.Open();
                    this.btn_LoadImage.Enabled = true;
                    this.btn_Detect.Enabled = true;
                    this.btn_Camera.Enabled = true;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btn_Detect_Click(object sender, EventArgs e)
        {            
            Detect();
            if (person_count != 0)
            {
                light = true;
                serialPort1.Write("1");
                this.cb_ON.Checked = true;
                this.cb_OFF.Checked = false;
            }
            else
            {
                light = false;
                serialPort1.Write("0");
                this.cb_ON.Checked = false;
                this.cb_OFF.Checked = true;
            }
        }
        #endregion


        #region Detecting Method
        private void Detect() //Hàm detect object
        {
            person_count = 0;
            Image image;
            if (cam_sel)
                image = this.Image_From_Cam;
            else image = Image.FromFile(Directory);
            
            var scorer = new YoloScorer<YoloCocoP5Model>("Assets/Weights/yolov5n.onnx");

            List<YoloPrediction> predictions = scorer.Predict(image);
            var graphics = Graphics.FromImage(image);

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 3);                

                if (prediction.Label.Name.ToString() == "person")
                {
                    graphics.DrawRectangles(new Pen(Color.Red, 1),
                    new[] { prediction.Rectangle });

                    var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                    person_count++;

                    graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(Color.Red),
                    new PointF(x, y));
                }
                //Console.WriteLine(person_count + "persons");

                /*graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));*/
                
            }
            //this.textBox_PersonCount.Text = person_count.ToString();
            pictureBox_Image2Detect.Image = image;
            //image.Save("Assets/result1.jpg");
        }
        #endregion

        private string AutoDetect_Arduino()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach(ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                        return deviceId;
                }
            }
            catch(ManagementException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                this.textBox_Status.Text = "Disconnect!";
                this.textBox_Status.ForeColor = Color.Red;
            }
            else
            {
                this.textBox_Status.Text = "Connect!";
                this.textBox_Status.ForeColor = Color.Green;
            }
        }

        private void Object_Detection_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }

        
    }
}
