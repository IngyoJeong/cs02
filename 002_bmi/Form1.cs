using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, height;

            height = double.Parse(txtH.Text);
            weight = double.Parse(txtW.Text);

            double bmi = weight / (height / 100 * height / 100);
            //label3.Text = "BMI = " + bmi + "입니다.";
            lblBMI.Text = string.Format("BMI = {0:F2}입니다.", bmi);

            if (bmi < 20)
            {
                lblResult.Text = "저체중입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (20 <= bmi && bmi < 25)
            {
                lblResult.Text = "정상체중입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (25 <= bmi && bmi < 30)
            {
                lblResult.Text = "경도비만입니다.";
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (30 <= bmi && bmi < 40)
            {
                lblResult.Text = "비만입니다.";
                pictureBox1.BackColor = Color.Orange;
            }
            else
            {
                lblResult.Text = "고도비만입니다.";
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
