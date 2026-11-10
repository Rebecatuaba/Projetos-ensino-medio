namespace mega_cena

{

    public partial class Form1 : Form
    {
        int p1, p2, p3, p4, p5, p6;
        int d1, d2, d3, d4, d5, d6, acerto;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Focus();
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            label5.Text = "00";
            label6.Text = "00";
            label7.Text = "00";
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acerto = 0;
            p1 = Convert.ToInt32(textBox1.Text);
            p2 = Convert.ToInt32(textBox2.Text);
            p3 = Convert.ToInt32(textBox3.Text);
            p4 = Convert.ToInt32(textBox4.Text);
            p5 = Convert.ToInt32(textBox5.Text);
            p6 = Convert.ToInt32(textBox6.Text);
            if ((p1 == d1) || (p1 == d2) || (p1 == d3) || (p1 == d4) || (p1 == d5) || (p1 == d6))
            {
                acerto++;
                label2.BackColor = Color.Yellow;
            }
            else
            {
                label2.BackColor = Color.RebeccaPurple;
            }
            if ((p2 == d1) || (p2 == d2) || (p2 == d3) || (p2 == d4) || (p2 == d5) || (p2 == d6))
            {
                acerto++;
                label3.BackColor = Color.Yellow;
            }
            else
            {
                label3.BackColor = Color.RebeccaPurple;
            }
            if ((p3 == d1) || (p3 == d2) || (p3 == d3) || (p3 == d4) || (p3 == d5) || (p3 == d6))
            {
                acerto++;
                label4.BackColor = Color.Yellow;
            }
            else
            {
                label4.BackColor = Color.RebeccaPurple;
            }
            if ((p4 == d1) || (p4 == d2) || (p4 == d3) || (p4 == d4) || (p4 == d5) || (p4 == d6))
            {
                acerto++;
                label5.BackColor = Color.Yellow;
            }
            else
            {
                label5.BackColor = Color.RebeccaPurple;
            }
            if ((p5 == d1) || (p5 == d2) || (p5 == d3) || (p5 == d4) || (p5 == d5) || (p5 == d6))
            {
                acerto++;
                label6.BackColor = Color.Yellow;
            }
            else
            {
                label6.BackColor = Color.RebeccaPurple;
            }
            if ((p6 == d1) || (p6 == d2) || (p6 == d3) || (p6 == d4) || (p6 == d5) || (p6 == d6))
            {
                acerto++;
                label7.BackColor = Color.Yellow;
            }
            else
            {
                label7.BackColor = Color.RebeccaPurple;
            }
            if (acerto == 6)
            {
                MessageBox.Show("Você acertou a Mega Cena, PARABÉNS MEU CHAPA!!!");

            }
            else if (acerto == 5)
            {
                MessageBox.Show("Você acertou a quina!!");
            }
            else if (acerto == 4)
            {
                MessageBox.Show("Você acertou a quadra!");
            }
            else
            {
                MessageBox.Show("NÃO HOUVE PREMIAÇÃO :-( ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            d1 = rd.Next(60) + 1;
            d2 = rd.Next(60) + 1;
            while (d1 == d2)
            {
                d2 = rd.Next(60) + 1;
            }
            d3 = rd.Next(60) + 1;
            while ((d3 == d1) || (d3 == d2))
            {
                d3 = rd.Next(60) + 1;
            }
            d4 = rd.Next(60);
            while ((d4 == d1) || (d4 == d2) || (d4 == d3))
            {
                d4 = rd.Next(60) + 1;
            }
            d5 = rd.Next(60);
            while ((d5 == d1) || (d5 == d2) || (d5 == d3) || (d5 == d4))
            {
                d5 = rd.Next(60) + 1;
            }
            d6 = rd.Next(60);
            while ((d6 == d1) || (d6 == d2) || (d6 == d3) || (d6 == d4) || (d6 == d5))
            {
                d6 = rd.Next(60) + 1;

            }
            label2.Text = ""+d1;
            label3.Text = ""+d2;
            label4.Text = ""+d3;
            label5.Text = ""+d4;
            label6.Text = ""+d5;
            label7.Text = ""+d6;
        }
    }
}
