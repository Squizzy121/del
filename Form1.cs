using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegats_zd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                this.Opacity = 0.5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка\n" +
                "і цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.button4.Click += new System.EventHandler(this.button1_Click);
            else
                this.button4.Click -= new System.EventHandler(this.button1_Click);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.button4.Click += new System.EventHandler(this.button2_Click);
            else
                this.button4.Click -= new System.EventHandler(this.button2_Click);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.button4.Click += new System.EventHandler(this.button3_Click);
            else
                this.button4.Click -= new System.EventHandler(this.button3_Click);
        }
    }
}
