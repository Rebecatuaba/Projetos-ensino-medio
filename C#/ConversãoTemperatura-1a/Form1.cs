namespace ConversãoTemperatura_1a
{
    public partial class Form1 : Form
    {
        int c, f;
        public Form1()
        {
            InitializeComponent();
        }
  
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c = (int)Convert.ToDecimal(textBox1.Text);
            f = (9 * c + 160) / 5;
            label3.Text = f.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "00";
        }
    }
}