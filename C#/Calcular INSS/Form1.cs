namespace Calcular_INSS
{
    public partial class Form1 : Form
    {
        decimal sal = 0, dpd = 0, impost = 0, inss = 0, salL = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

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
            textBox1.Focus();
            label3.Text = "Imposto de renda: ";
            label4.Text = "Salário Bruto: ";
            label5.Text = "INSS: ";
        }
    }
}