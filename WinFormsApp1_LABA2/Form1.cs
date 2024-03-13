using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1_LABA2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            

        }
        public interface ICloneable
        {
            object Clone();
        }
        public class Point1
        {
            public float X;
            public float Y;
            public float Z = 1;
            public Point1(float x, float y)
            {
                X = x;
                Y = y;
            }
            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        static public List<Point1> listOfInner_Default = new List<Point1>()
        {
            new Point1(0,3),
            new Point1(5,1),
            new Point1(-5,1),
            new Point1(5,-5),
            new Point1(-5,-5),
            new Point1(0,-7)
        };

        static public List<Point1> listOfOuter_Default = new List<Point1>()
        {
            new Point1(0,9),
            new Point1(3,2),
            new Point1(-3,2),
            new Point1(12,1),
            new Point1(-12,1),
            new Point1(5,-4),
            new Point1(-5,-4),
            new Point1(8,-12),
            new Point1(-8,-12),
            new Point1(0,-7)
        };

        static public List<Point1> listOfInner = new List<Point1>();
       
        
        static public List<Point1> listOfOuter = new List<Point1>();
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = string.Format("{0}",e.Location.X-pictureBox1.Width/2);
            label4.Text = string.Format("{0}", -e.Location.Y+pictureBox1.Height/2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        public void drawdude()
        {
            Graphics g = pictureBox1.CreateGraphics();
            int height = pictureBox1.Height;
            int width = pictureBox1.Width;
            Pen pen = new Pen(Color.Black);
            g.Clear(pictureBox1.BackColor);
            //отрисовка осей
            g.DrawLine(pen, new Point(width / 2, 0), new Point(width / 2, height));
            g.DrawLine(pen, new Point(0, height / 2), new Point(width, height / 2));
            int k = 10;
            //отрисовка фигуры, сначала шестиугольник
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfInner[0].X * k + pictureBox1.Width / 2, -(listOfInner[0].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfInner[1].X * k) + pictureBox1.Width / 2, -(listOfInner[1].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfInner[0].X * k + pictureBox1.Width / 2, -(listOfInner[0].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfInner[2].X * k) + pictureBox1.Width / 2, -(listOfInner[2].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfInner[1].X * k + pictureBox1.Width / 2, -(listOfInner[1].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfInner[3].X * k) + pictureBox1.Width / 2, -(listOfInner[3].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfInner[2].X * k + pictureBox1.Width / 2, -(listOfInner[2].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfInner[4].X * k) + pictureBox1.Width / 2, -(listOfInner[4].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfInner[5].X * k + pictureBox1.Width / 2, -(listOfInner[5].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfInner[4].X * k) + pictureBox1.Width / 2, -(listOfInner[4].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfInner[5].X * k + pictureBox1.Width / 2, -(listOfInner[5].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfInner[3].X * k) + pictureBox1.Width / 2, -(listOfInner[3].Y * k) + pictureBox1.Height / 2));

            //отрисовка звезды
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfOuter[0].X * k + pictureBox1.Width / 2, -(listOfOuter[0].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfOuter[1].X * k) + pictureBox1.Width / 2, -(listOfOuter[1].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfOuter[0].X * k + pictureBox1.Width / 2, -(listOfOuter[0].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfOuter[2].X * k) + pictureBox1.Width / 2, -(listOfOuter[2].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
                new PointF(listOfOuter[4].X * k + pictureBox1.Width / 2, -(listOfOuter[4].Y * k) + pictureBox1.Height / 2),
                new PointF((listOfOuter[2].X * k) + pictureBox1.Width / 2, -(listOfOuter[2].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfOuter[3].X * k + pictureBox1.Width / 2, -(listOfOuter[3].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfOuter[1].X * k) + pictureBox1.Width / 2, -(listOfOuter[1].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfOuter[4].X * k + pictureBox1.Width / 2, -(listOfOuter[4].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfOuter[6].X * k) + pictureBox1.Width / 2, -(listOfOuter[6].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
               new PointF(listOfOuter[3].X * k + pictureBox1.Width / 2, -(listOfOuter[3].Y * k) + pictureBox1.Height / 2),
               new PointF((listOfOuter[5].X * k) + pictureBox1.Width / 2, -(listOfOuter[5].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
              new PointF(listOfOuter[7].X * k + pictureBox1.Width / 2, -(listOfOuter[7].Y * k) + pictureBox1.Height / 2),
              new PointF((listOfOuter[5].X * k) + pictureBox1.Width / 2, -(listOfOuter[5].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
              new PointF(listOfOuter[8].X * k + pictureBox1.Width / 2, -(listOfOuter[8].Y * k) + pictureBox1.Height / 2),
              new PointF((listOfOuter[6].X * k) + pictureBox1.Width / 2, -(listOfOuter[6].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
              new PointF(listOfOuter[8].X * k + pictureBox1.Width / 2, -(listOfOuter[8].Y * k) + pictureBox1.Height / 2),
              new PointF((listOfOuter[9].X * k) + pictureBox1.Width / 2, -(listOfOuter[9].Y * k) + pictureBox1.Height / 2));
            g.DrawLine(new Pen(Color.Red, 2f),
              new PointF(listOfOuter[7].X * k + pictureBox1.Width / 2, -(listOfOuter[7].Y * k) + pictureBox1.Height / 2),
              new PointF((listOfOuter[9].X * k) + pictureBox1.Width / 2, -(listOfOuter[9].Y * k) + pictureBox1.Height / 2));
            
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfInner.Clear();
            listOfOuter.Clear();
            foreach(Point1 i in listOfInner_Default)
            {
                listOfInner.Add((Point1)i.Clone());
            }
            foreach (Point1 i in listOfOuter_Default)
            {
                listOfOuter.Add((Point1)i.Clone());
            }
            drawdude();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)  //(x+a)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //(y+b)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);   
            for(int i = 0; i < listOfInner.Count; ++i) 
            {
                listOfInner[i].X += a;
                listOfInner[i].Y += b;
            }
            for(int i = 0;i< listOfOuter.Count; ++i)
            {
                listOfOuter[i].X += a;
                listOfOuter[i].Y += b;
            }
            
            drawdude();

        }

        private void button3_Click(object sender, EventArgs e) //отображение относительно Ox
        {
            for (int i = 0; i < listOfInner.Count; ++i)
                listOfInner[i].Y *= -1;
            for (int i = 0; i < listOfOuter.Count; ++i)
                listOfOuter[i].Y *= -1;
            drawdude();
        }

        private void button4_Click(object sender, EventArgs e) //отображение относ Oy
        {
            for (int i = 0; i < listOfInner.Count; ++i)
                listOfInner[i].X *= -1;
            for (int i = 0; i < listOfOuter.Count; ++i)
                listOfOuter[i].X *= -1;
            drawdude();
        }

        private void button5_Click(object sender, EventArgs e) //отображение относ y=x
        {
            for (int i = 0; i < listOfInner.Count; ++i)
            {
                float tmp = 0;
                tmp = listOfInner[i].X;
                listOfInner[i].X = listOfInner[i].Y;
                listOfInner[i].Y = tmp;
            }
            for (int i = 0; i < listOfOuter.Count; ++i)
            {
                float tmp = 0;
                tmp = listOfOuter[i].X;
                listOfOuter[i].X = listOfOuter[i].Y;
                listOfOuter[i].Y = tmp;
            }
            drawdude();
        }

        private void button6_Click(object sender, EventArgs e) //масштабирование
        {
            float k = float.Parse(textBox3.Text);
            float b = float.Parse(textBox4.Text);
            if (k == 0) k = 1;
            if(b==0) b = 1;
            for (int i = 0; i < listOfInner.Count; ++i)
            {
                listOfInner[i].X *= k;
                listOfInner[i].Y *= b;
            }
            for (int i = 0; i < listOfOuter.Count; ++i)
            {
                listOfOuter[i].X *= k;
                listOfOuter[i].Y *= b;
            }
            drawdude();
        }
        
        public void matrixmultiply(float angle, float x, float y) //умножение матриц
        {
            float rad = (float)(angle * (Math.PI/180));
            List<List<float>> matrix = new List<List<float>>
            {
                new List<float> { (float)Math.Cos(rad),(float)Math.Sin(rad), x },
                new List<float> { -(float)Math.Sin(rad), (float)Math.Cos(rad), y },
                new List<float> {0.0F, 0.0F, 1.0F}
            };
            List<float> resultMatrix = new List<float>() { 0, 0, 0 };


            for (int k = 0; k < listOfInner.Count; ++k)
            {
                List<float> Point = new List<float>() { listOfInner[k].X, listOfInner[k].Y, listOfInner[k].Z };
                for (int i = 0; i < matrix.Count; ++i)
                {
                    resultMatrix[i] = 0;
                    for (int j = 0; j < matrix[i].Count; ++j)
                    {
                        resultMatrix[i] += matrix[i][j] * Point[j];
                        
                    }
                }
                listOfInner[k].X = resultMatrix[0];
                listOfInner[k].Y = resultMatrix[1];
            }
            for (int k = 0; k < listOfOuter.Count; ++k)
            {
                List<float> Point = new List<float>() { listOfOuter[k].X, listOfOuter[k].Y, listOfOuter[k].Z };
                for (int i = 0; i < matrix.Count; ++i)
                {
                    resultMatrix[i] = 0;
                    for (int j = 0; j < matrix[i].Count; ++j)
                    {
                        resultMatrix[i] += matrix[i][j] * Point[j];

                    }
                }
                listOfOuter[k].X = resultMatrix[0];
                listOfOuter[k].Y = resultMatrix[1];
            }
        }

        private void button7_Click(object sender, EventArgs e) //поворот
        {
            float angle = float.Parse(textBox5.Text);
            float x = float.Parse(textBox6.Text);
            float y = float.Parse(textBox7.Text);
            matrixmultiply(angle, x, y);
            drawdude();
        }
    }
}