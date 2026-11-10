namespace MaiorNumA
{
    public partial class Form1 : Form
    {
        int num1, num2, num3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "> ";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);

            if ((num1 > num2) && (num1 > num3))
            {
                label4.Text = "O maior númer é o " + num1;  
            }

            if ((num2 > num1) && (num2 > num3))
            { 
                label4.Text = "O maior número é o " + num2;
            }

            if ((num3 > num2) && (num3 > num1))
            { 
                label4.Text = "O maior número é o " + num3;
            }
}
    }
}