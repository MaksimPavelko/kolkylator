using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kolkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double rost = Convert.ToDouble(textBox1.Text) / 100;
            double ves = Convert.ToDouble(textBox2.Text);
            double BMI = Convert.ToDouble(ves / (rost * rost));
            label20.Text = BMI.ToString();

            if (BMI < 10)
            { trackBar1.Value = 10; label21.Text = "недостаточный"; }

            if (BMI < 18.5 && BMI >= 10)
            { trackBar1.Value = Convert.ToInt32(BMI); label21.Text = "недостаточный"; }

            if (BMI >= 18.5 && BMI <= 24.9)
            { trackBar1.Value = Convert.ToInt32(BMI); label21.Text = "здоровый"; }

            if (BMI <= 30 && BMI > 24.9)
            { trackBar1.Value = Convert.ToInt32(BMI); label21.Text = "избыточный"; }

            if (BMI > 30 && BMI < 35)
            { trackBar1.Value = Convert.ToInt32(BMI); label21.Text = "ожирение"; }

            if (BMI > 35)
            { trackBar1.Value = 35; label21.Text = "ожиренне"; }






        }



        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    
    }
}
