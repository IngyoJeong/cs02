using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Form.DefaultBackColor)
            {
                label1.ForeColor = Color.White;
                this.BackColor = Color.Blue;
            }
            else
            {
                label1.ForeColor = Label.DefaultBackColor;
                this.BackColor = Form.DefaultBackColor;
            }
        }
    }
}
