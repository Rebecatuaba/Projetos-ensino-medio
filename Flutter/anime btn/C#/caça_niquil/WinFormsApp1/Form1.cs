namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int Sorteio1, Sorteio2, Sorteio3;
        decimal aposta, saldo, credito;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random holocausto = new Random();
            Sorteio1 = holocausto.Next(10);
            lbls1.Text = Sorteio1.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random holocausto = new Random();
            Sorteio3 = holocausto.Next(10);
            lbls3.Text = Sorteio3.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random holocausto = new Random();
            Sorteio2 = holocausto.Next(10);
            lbls2.Text = Sorteio2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            credito = Convert.ToDecimal(tcredI.Text);
            saldo = saldo + credito;
            lblsaldo.Text = saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aposta = Convert.ToDecimal(taposta.Text);
            if (aposta > 0)
            {
                button3.Enabled = true;
            }
            else { 
                button3.Enabled = false;
            }
            if ((aposta < saldo) && (aposta > 0))
            {
                saldo = saldo - aposta;
                lblsaldo.Text = saldo.ToString();
            }
            else
            {
                MessageBox.Show("Saldo insuficiente para apostar, digite uma aposta menor");
                button3.Enabled=false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            button2.Enabled = false;
            if ((Sorteio1==Sorteio2) && (Sorteio1 == Sorteio3)){
                aposta = aposta * 2;
                saldo = saldo + aposta;
                lblsaldo.Text = saldo.ToString();
            }
            else if ((Sorteio1==Sorteio2)|| (Sorteio1==Sorteio3)||(Sorteio2==Sorteio3))

            {
                aposta = aposta;
                saldo = saldo + aposta;
                lblsaldo.Text = saldo.ToString();

            }
            else
            {
                MessageBox.Show("Você perdeu o valor da sua aposta!");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saldo > 30)
            {
              timer1.Enabled = true;
              timer2.Enabled = true;
              timer3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Saldo insuficienete, insira novos créditos");
                tcredI.Focus();
            }
        

      

        }
    }
}