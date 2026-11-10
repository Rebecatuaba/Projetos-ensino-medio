using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo1A
{
    public partial class Form1 : Form
    {
        int n1, n2, op;
        double result, palpit;

        private void BUTTconferir_Click(object sender, EventArgs e)
        {
            palpit = Convert.ToDouble(TXTpalpite.Text);

            if(palpit == result)
            {
                IMGhappy.Visible = true;
                IMGstart.Visible = false;
                IMGsad.Visible = false;
            }
            else
            {
                IMGsad.Visible = true;
                IMGstart.Visible = false;
                IMGhappy.Visible = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LBLn1.Text = "0";
            LBLop.Text = "?";
            LBLn2.Text = "0";
            TXTpalpite.Text = "?";
        }

        private void BUTTsorteio_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            op = 0;
            IMGhappy.Visible = false;
            IMGsad.Visible = false;
             IMGstart.Visible = true;
            Random rndn1 = new Random();
            n1 = rndn1.Next(10) + 1;
            LBLn1.Text = n1.ToString();
            n2 = rndn1.Next(10) + 1;
            LBLn2.Text = n2.ToString();
            Random rndop = new Random();
            op = rndop.Next(4);
            if ( op == 0)
            {
                LBLop.Text = "+";
                result = n1 + n2;
            }
            if (op == 1)
            {
                result = n1 - n2;
                LBLop.Text = "-";
            }
            if (op == 2)
            {
                result = n1 * n2;
                LBLop.Text = "*";
            }
            if (op == 3)
            {
                result = n1 / n2;
                LBLop.Text = "/";
            }
            TXTpalpite.Text = "";
            TXTpalpite.Focus();
        }
    }
}
