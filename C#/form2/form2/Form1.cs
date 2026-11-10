using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        decimal qht, vh, pinss, pir;
        decimal sb, sl, descinss, descir;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = sb.ToString();
            label10.Text = descinss.ToString();
            label11.Text = descir.ToString();
            label12.Text = sl.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = sb.ToString();
            label10.Text = descinss.ToString();
            label11.Text = descir.ToString();
            label12.Text = sl.ToString();


            sb = qht * vh;
            descinss = sb * pinss / 100;
            descir = sb * pir / 100;
            sl = sb - descinss - descir;

            label9.Text = sb.ToString();
            label10.Text = descinss.ToString();
            label11.Text = descir.ToString();
            label12.Text = sl.ToString();
        }
    }
}
