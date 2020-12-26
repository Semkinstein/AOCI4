using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCI1
{
    public partial class Form1 : Form
    {
        ImageEditor imgEditor = new ImageEditor();
        Image<Bgr, byte> image, defaultImage;
        PointF[] srcPoints = new PointF[4];
        List<PointF> points = new List<PointF>();
        int mouseX, mouseY;
        public Form1()
        {
            InitializeComponent();
            //button1.Click += new EventHandler(button1_Click);
            imageBox1.MouseClick += new MouseEventHandler(imageBox2_MouseClick);

        }

        private void imageBox2_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX = (int)(e.Location.X / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));
            mouseY = (int)(e.Location.Y / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));

            points.Add(new PointF(mouseX, mouseY));
            if(points.Count > 4)
            {
                points.RemoveAt(0);
            }
            if(points.Count == 4)
            {
                srcPoints = points.ToArray();
            }

            Point center = new Point(mouseX, mouseY);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;
            // функция, рисующая на изображении круг с заданными параметрами
            CvInvoke.Circle(defaultImage, center, radius, color, thickness);
            imgEditor.ShowImage(imageBox1, defaultImage);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            defaultImage = imgEditor.SetSourceImage(OpenImageFile());
            imgEditor.ShowImage(imageBox1, defaultImage);
        }

        private void buttonBinarized_MouseClick(object sender, MouseEventArgs e)
        {
            image = imgEditor.ReturnBinarized(defaultImage, trackBarThreshold.Value);
            FillImage2();
        }

        private void buttonShapes_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnContours(defaultImage, Int32.Parse(textBoxArea.Text), label);
            FillImage2();
        }

        private void buttonColorBinarization_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnByColor(defaultImage, trackBarColor.Value, trackBarDelta.Value);
            FillImage2();
        }

        private string OpenImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png *.PNG) | *.jpg; *.jpeg; *.jpe; *.jfif *.png *.PNG";
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                return fileName;
            }
            return null;
        }

        

        
      

       

       //filllllllllllll

        private void FillImage2(bool mode = true)
        {
            
            imgEditor.ShowImage(imageBox2, image, mode);
        }

        
    }
}
