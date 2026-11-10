using Microsoft.VisualBasic;
using System.Drawing;

namespace Conversão_de_moedas
{
    public partial class Form1 : Form
    {
        double Real, Divisao, Cotacao;
        int i;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Real = Convert.ToDouble(textBox1.Text);
            Cotacao = Convert.ToDouble(textBox2.Text);
            Divisao = Real * Cotacao;
            label1.Text = "" + Math.Round(Divisao, 2);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            i = comboBox1.SelectedIndex;
            if (i == 0)
            {
                textBox2.Text = "";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\shutterstock_1546640954-810x540.jpg";
            }
            else if (i == 1)
            {
                textBox2.Text = "5,24";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\dolar.jpg";
            }
            else if (i == 2)
            {
                textBox2.Text = "5,63";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\euro.jpg";
            }
            else if (i == 3)
            {
                textBox2.Text = "0,040";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\yen.jpg";
            }
            else if (i == 4)
            {
                textBox2.Text = "0,22";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\peso_cuba.jpg";
            }
            else if (i == 5)
            {
                textBox2.Text = "0,026";
                img.ImageLocation = @"D:\Fafa\Visual Studio\2ºAno\Conversão de moedas\imagem\peso_argentino.jpeg";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "---";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
