namespace VolLata_1A
{
    public partial class Form1 : Form
    {
        decimal altura, raio, volume, pi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            altura = Convert.ToDecimal(textBox2.Text);
            raio = Convert.ToDecimal(textBox1.Text);
            pi = Convert.ToDecimal(textBox3.Text);

            volume = pi * (raio * raio) * altura;

            label4.Text = volume.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "3,14159";
            label4.Text = "00";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}