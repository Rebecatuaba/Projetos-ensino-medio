namespace Doisnumeros_1A
{
    public partial class Form1 : Form
    {
        decimal multiplicacao, soma, subtracao, divisao, num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textBox1.Text);
            num2 = Convert.ToDecimal(textBox2.Text);

            multiplicacao = num1 * num2;
            soma = num1 + num2;
            divisao = num1 / num2;
            subtracao = num1 - num2;

            label9.Text = multiplicacao.ToString();
            label7.Text = soma.ToString();
            label11.Text = subtracao.ToString();
            label13.Text = divisao.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label7.Text = "00";
            label9.Text = "00";
            label11.Text = "00";
            label13.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}