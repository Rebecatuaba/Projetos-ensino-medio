namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, v;
            num = Convert.ToInt32(textBox1.Text);
            for (int loop=0; loop <=10; loop++)
            {
                v = num * loop;
                listBox1.Items.Add(num+" x "+loop+" = "+v);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}