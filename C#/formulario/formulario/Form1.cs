using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        int idadeA, idadeM, idadeD, idadeH;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "00";
            label7.Text = "00";
            label8.Text = "00";
            label9.Text = "XXXXXXX";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idadeA =Convert.ToInt32 (textBox2.Text);
            idadeM = idadeA * 12;
            idadeD = idadeM * 30;
            idadeH = idadeD * 24;
            label6.Text = idadeM.ToString();
            label7.Text = idadeD.ToString();
            label8.Text = idadeH.ToString();
            label9.Text = textBox1.Text;

        }
        
    }
}
