namespace Exercicio_5
{
    public partial class Form1 : Form
    {
        string a, b, c;
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
            label5.Text = "00";
            label6.Text = "00";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;

            c = b;
            b = a;
            a = c;

            label5.Text = a;
            label6.Text = b;
        }
    }
}