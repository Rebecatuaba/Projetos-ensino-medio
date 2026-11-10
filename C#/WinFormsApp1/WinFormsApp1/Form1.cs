namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int idade;
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
            label2.Text = "> ";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idade = Convert.ToInt32(textBox1.Text);
            if (idade < 5)
            {
                label2.Text = "> Categoria Infantil A";
            }
            else
            {
                if (idade < 8)
                {
                    label2.Text = "> Categoria Infantil B";
                }
                else
                {
                    if (idade < 11)
                    {
                        label2.Text = "> Categoria Juvenil A";
                    }
                    else
                    {
                        if (idade < 15)
                        {
                            label2.Text = "> Categoria Juvenil B";
                        }
                        else
                        {
                            if (idade < 18)
                            {
                                label2.Text = "> Categoria Juvenil C";
                            }
                            else
                            {
                                if (idade >= 18)
                                {
                                    label2.Text = "> Categoria Adulto";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}