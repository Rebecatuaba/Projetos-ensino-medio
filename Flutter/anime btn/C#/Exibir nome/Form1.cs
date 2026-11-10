namespace Exibir_nome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome;
            int idade, a = 1;
            nome = textBox1.Text;
            idade = Convert.ToInt32(textBox2.Text);
            while (a<=idade) {
                listBox1.Items.Add(nome + "   " + a);
                a++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}