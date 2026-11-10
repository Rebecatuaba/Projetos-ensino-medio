namespace triangulo1A
{
    public partial class Form1 : Form
    {
        int lado1, lado2, lado3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "> ";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lado1 = Convert.ToInt32(textBox1.Text);
            lado2 = Convert.ToInt32(textBox2.Text);
            lado3 = Convert.ToInt32(textBox3.Text);

            if ((lado1< lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2)){
                if ((lado1 != lado2) && (lado1 != lado3) && (lado2 != lado3)) {
                    label4.Text = "> Seu triângulo é do tipo escaleno";
                }

                if (((lado1 == lado2) && (lado1 != lado3)) || ((lado1 == lado3) && (lado1 != lado2)) || ((lado2 == lado3) && (lado2 != lado1)))
                {
                    label4.Text = "> Seu triângulo é do tipo isóceles";
                }

                if ((lado1 == lado2) && (lado1 == lado3))
                {
                    label4.Text = "> Seu triângulo é do tipo equilátero";
                }
            }
            else
            {
                label4.Text = "> Os valores inseridos não formam um triângulo";
            }

        }
    }
}