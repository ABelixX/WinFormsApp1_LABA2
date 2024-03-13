using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1_LABA2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 1000 / FPS;
            timer.Tick += new EventHandler(TimerCallback);
        }
        Graphics g;
        Timer timer = new Timer();
        int FPS = 1000;

        void TimerCallback(object sender, EventArgs e)
        {
            draw_snow(y);
            update_y();
            this.Invalidate();
            return;
        }
        public int y = 35;
        public void update_y()
        {
            y += 1;
            if (y > Width)
                y = 35;
        }
        public void draw_snow(int y)
        {
            int x = 20;
            for (int i = 0; i < 5; ++i)
            {
                g.DrawLine(new Pen(Color.White, 3f), new Point(x, y - 10), new Point(x, y + 10));
                g.DrawLine(new Pen(Color.White, 3f), new Point(x + 10, y), new Point(x - 10, y));  //центр у точки = (20,35)
                g.DrawLine(new Pen(Color.White, 3f), new Point(x - 5, y - 5), new Point(x + 5, y + 5));
                g.DrawLine(new Pen(Color.White, 3f), new Point(x - 5, y + 5), new Point(x + 5, y - 5));

                x += 100;
            }

        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }
    }
}
