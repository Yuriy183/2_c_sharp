Причина редактировани, залил .cs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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
            circle.R = Convert.ToDouble(textBox2.Text == "" || Convert.ToDouble(textBox2.Text )< 0 ? "0" : textBox2.Text);
            txtResult1.Text = circle.ToString();

            cylinder.R = Convert.ToDouble(textBox3.Text == "" || Convert.ToDouble(textBox3.Text) < 0 ? "0" : textBox3.Text);
            cylinder.H = Convert.ToDouble(textBox4.Text == "" || Convert.ToDouble(textBox4.Text) < 0 ? "0" : textBox4.Text);
            txtResult2.Text = cylinder.ToString();
        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            Random rnd =  new Random();

            textBox2.Text = Convert.ToString(rnd.Next(0, 50));
            textBox3.Text = Convert.ToString(rnd.Next(0, 50));
            textBox4.Text = Convert.ToString(rnd.Next(0, 50));

        }

       
    }
}
