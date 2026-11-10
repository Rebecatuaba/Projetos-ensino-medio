namespace exercio_3
{
    public partial class Form1 : Form
    {
        int numero = 0, i = 0, contt = 0, pares = 0, impares = 0, percentualpares, percentualimpares, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(tbNum.Text);
            listLidos.Items.Add(numero);
            tbNum.Text = "";
            tbNum.Focus();
            contt++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNum.Text = "";
            tbTotalP.Text = "";
            tbTotalI.Text = "";
            tbTotal.Text = "";
            tbPorcP.Text = "";
            tbPorcI.Text = "";
            listLidos.Items.Clear();
            listImpar.Items.Clear();
            listPares.Items.Clear();
            tbNum.Focus();
        }

        private void btSepar_Click(object sender, EventArgs e)
        {
            while (i<= contt - 1)
            {
                numero = Convert.ToInt32(listLidos.Items[i].ToString());
                i++;
                if (numero % 2 == 0)
                {
                    listPares.Items.Add(numero.ToString());
                    pares++;
                    total++;
                }
                else
                {
                    listImpar.Items.Add(numero.ToString());
                    impares++;
                    total++;
                }
                tbTotalP.Text = Convert.ToString(pares);
                tbTotalI.Text = Convert.ToString(impares);
                tbTotal.Text = Convert.ToString(total);
                percentualimpares = (impares * 100) / total;
                percentualpares = (pares * 100) / total;
                tbPorcP.Text = Convert.ToString(percentualpares);
                tbPorcI.Text = Convert.ToString(percentualimpares);
            }
        }
    }
}