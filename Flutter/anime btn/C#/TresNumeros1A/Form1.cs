namespace TresNumeros1A
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Ordem crescente: ";
            label5.Text = "X";
            label7.Text = "X";
            label8.Text = "X";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);

            //numero 1
            if ((num1 >= num2) && (num1 >= num3))
            {
                label5.Text = ""+num1;
            }
            if ((num1 <= num2) && (num1 >= num3) || (num1 <= num3) && (num1 >= num2)) 
            {
                label7.Text = "" + num1;
            }
            if ((num1 <= num2) && (num1 <= num3))
            {
                label8.Text = "" + num1;
            }

            //numero 2
            if ((num2 >= num1) && (num2 >= num3))
            {
                label5.Text = "" + num2;
            }
            if ((num2 <= num1) && (num2 >= num3) || (num2 <= num3) && (num2 >= num1))
            {
                label7.Text = "" + num2;
            }
            if ((num2 <= num1) && (num2 <= num3))
            {
                label8.Text = "" + num2;
            }

            //numero 3
            if ((num3 >= num2) && (num3 >= num1))
            {
                label5.Text = "" + num3;
            }
            if ((num3 <= num2) && (num3 >= num1) || (num3 <= num1) && (num3 >= num2))
            {
                label7.Text = "" + num3;
            }
            if ((num3 <= num2) && (num3 <= num1))
            {
                label8.Text = "" + num3;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}