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


namespace GUI_Interface
{
    public partial class Object_Detection_GUI : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice device_Cam;
        Image Image_From_Cam;

        string Directory;
        int person_count = 0;
        bool cam_sel = false;

        public Object_Detection_GUI()
        {
            InitializeComponent();
        }

        private void Object_Detection_GUI_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device_Cam in filter)
                this.Combo_Camera_Device.Items.Add(device_Cam.Name);
            this.Combo_Camera_Device.SelectedIndex = 0;
            this.device_Cam = new VideoCaptureDevice();
        }

        #region Button Controls
        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image_Loading = new OpenFileDialog();
            Image_Loading.Filter = "Image Filter(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (Image_Loading.ShowDialog() == DialogResult.OK)
            {
                Directory = Image_Loading.FileName;
                textBox_Directory.Text = Directory;
                pictureBox_Image2Detect.Image = new Bitmap(Directory);
            }
        }
        private void btn_Camera_Click(object sender, EventArgs e)
        {
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
            cam_sel = true;
            this.device_Cam = new VideoCaptureDevice(filter[this.Combo_Camera_Device.SelectedIndex].MonikerString);
            device_Cam.NewFrame += Device_NewFrame;
            device_Cam.Start();
            

        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (Image_From_Cam != null) Image_From_Cam.Dispose();
            Image_From_Cam = (Image)eventArgs.Frame.Clone();
            this.pictureBox_Image2Detect.Image = Image_From_Cam;
            if (Image_From_Cam != null)
            {
                
                Detect();
            }
            //Bitmap new_bmp = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_Detect_Click(object sender, EventArgs e)
        {
            cam_sel = false;
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
            Detect();
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

            //var image = Image.FromFile(Directory);
            var scorer = new YoloScorer<YoloCocoP5Model>("Assets/Weights/yolov5n.onnx");

            List<YoloPrediction> predictions = scorer.Predict(image);
            var graphics = Graphics.FromImage(image);

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 3);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                if (prediction.Label.Name.ToString() == "person")
                {
                    person_count++;
                }
                Console.WriteLine(person_count + "persons");
                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }
            //this.textBox_PersonCount.Text = person_count.ToString();
            pictureBox_Image2Detect.Image = image;
            //image.Save("Assets/result1.jpg");
        }


        #endregion

        private void Object_Detection_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.device_Cam.IsRunning)
                this.device_Cam.Stop();
        }
    }
}
