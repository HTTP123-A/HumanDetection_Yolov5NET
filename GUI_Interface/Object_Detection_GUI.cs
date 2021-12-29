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

namespace GUI_Interface
{
    public partial class Object_Detection_GUI : Form
    {
        string Directory;
        int person_count = 0;

        public Object_Detection_GUI()
        {
            InitializeComponent();
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

        private void btn_Detect_Click(object sender, EventArgs e)
        {
            Detect();
        }
        #endregion

        private void Detect() //Hàm detect object
        {
            var image = Image.FromFile(Directory);
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
                //Console.WriteLine(count + "persons");
                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }
            textBox_PersonCount.Text = person_count.ToString();
            pictureBox_Image2Detect.Image = image;
            image.Save("Assets/result1.jpg");
        }
    }
}
