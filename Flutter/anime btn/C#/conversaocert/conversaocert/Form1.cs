namespace conversaocert
{
    public partial class Form1 : Form
    {
        Decimal Dolar, Euro, Real, Libra, Divisao;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            label8.Text = "";
            label7.Text = "";
            label6.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Real = Convert.ToDecimal(textBox1.Text);
            Dolar = Convert.ToDecimal(textBox2.Text);
            Euro = Convert.ToDecimal(textBox5.Text);
            Libra = Convert.ToDecimal(textBox4.Text);
            Divisao = Real / Dolar;
            label8.Text = Divisao + "";
            Divisao = Real / Euro;
            label7.Text = Divisao + "";
            Divisao = Real / Libra;
            label6.Text = Divisao + "";    
        }
    }
}