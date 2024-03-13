using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_LABA2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 preob= new Form1();
            preob.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 snow= new Form3();
            snow.ShowDialog();
        }
    }
}
