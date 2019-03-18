using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_c_sharp
{
    public partial class Form1 : Form
    {
        Circle circle;
        Cylinder cylinder;

        public Form1()
        {
            InitializeComponent();
            circle = new Circle();
            cylinder = new Cylinder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle.R = Convert.ToDouble(textBox2.Text == "" ? "0" : textBox2.Text);
            textBox5.Text = circle.ToString();

            cylinder.R = Convert.ToDouble(textBox3.Text == "" ? "0" : textBox3.Text);
            cylinder.H = Convert.ToDouble(textBox4.Text == "" ? "0" : textBox4.Text);
            textBox1.Text = cylinder.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
