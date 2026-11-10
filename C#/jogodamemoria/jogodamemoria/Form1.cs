using System;

namespace jogodamemoria
{
    public partial class Form1 : Form
    {
        int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20;
        int acertos = 0, erros = 0, vira = 0;
        Button bt = null;

        private void zera()
        {
            b1 = 0;
            b2 = 0;
            b3 = 0;
            b4 = 0;
            b5 = 0;
            b6 = 0;
            b7 = 0;
            b8 = 0;
            b9 = 0;
            b10 = 0;
            b11 = 0;
            b12 = 0;
            b13 = 0;
            b14 = 0;
            b15 = 0;
            b16 = 0;
            b17 = 0;
            b18 = 0;
            b19 = 0;
            b20 = 0;
            vira = 0;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            b7 = 1;
            button7.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b7 == b14)
                {
                    button7.Visible = false;
                    button14.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button7.Visible = true;
                    button14.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button7;
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            b8 = 1;
            button8.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b8 == b15)
                {
                    button8.Visible = false;
                    button15.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button8.Visible = true;
                    button15.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button8;
            }
            }

        private void button9_Click(object sender, EventArgs e)
        {
            b9 = 1;
            button9.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b9 == b11)
                {
                    button9.Visible = false;
                    button11.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button9.Visible = true;
                    button11.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button9;
            }
            }

        private void button10_Click(object sender, EventArgs e)
        {
            b10 = 1;
            button10.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b10 == b3)
                {
                    button10.Visible = false;
                    button3.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button10.Visible = true;
                    button3.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button10;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b11 = 1;
            button11.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b11 == b9)
                {
                    button11.Visible = false;
                    button9.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button9.Visible = true;
                    button11.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button11;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            b12 = 1;
            button12.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b17 == b12)
                {
                    button17.Visible = false;
                    button12.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button17.Visible = true;
                    button12.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button12;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b13 = 1;
            button13.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b13 == b2)
                {
                    button13.Visible = false;
                    button2.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button13.Visible = true;
                    button2.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button13;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b14 = 1;
            button14.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b14 == b7)
                {
                    button7.Visible = false;
                    button14.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button7.Visible = true;
                    button14.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button14;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b15 = 1;
            button15.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b15 == b8)
                {
                    button15.Visible = false;
                    button8.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button15.Visible = true;
                    button8.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button15;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            b16 = 1;
            button16.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b16 == b6)
                {
                    button16.Visible = false;
                    button6.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button16.Visible = true;
                    button6.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button16;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b17 = 1;
            button17.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b17 == b12)
                {
                    button17.Visible = false;
                    button12.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button17.Visible = true;
                    button12.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button17;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b18 = 1;
            button18.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b18 == b20)
                {
                    button18.Visible = false;
                    button20.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button18.Visible = true;
                    button20.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button18;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b19 = 1;
            button19.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b19 == b1)
                {
                    button19.Visible = false;
                    button1.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button19.Visible = true;
                    button1.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button19;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            b20 = 1;
            button20.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b20 == b18)
                {
                    button20.Visible = false;
                    button18.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button20.Visible = true;
                    button18.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button20;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b6 = 1;
            button6.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b6 == b16)
                {
                    button6.Visible = false;
                    button16.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button6.Visible = true;
                    button16.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button6;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b5 = 1;
            button5.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b5 == b4)
                {
                    button5.Visible = false;
                    button4.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button4.Visible = true;
                    button5.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button5;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            b1 = 1;
            button1.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b1 == b19)
                {
                    button1.Visible = false;
                    button19.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button1.Visible = true;
                    button19.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button1;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            b4 = 1;
            button4.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b4 == b5)
                {
                    button4.Visible = false;
                    button5.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button4.Visible = true;
                    button5.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3 = 1;
            button3.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b3 == b10)
                {
                    button3.Visible = false;
                    button10.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button3.Visible = true;
                    button10.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2 = 1;
            button2.Visible = false;
            vira = vira + 1;
            if (vira == 2)
            {
                if (b2 == b13)
                {
                    button2.Visible = false;
                    button13.Visible = false;
                    vira = 0;
                    acertos++;
                    label1.Text = "Acertos: " + acertos;
                }
                else
                {
                    button2.Visible = true;
                    button13.Visible = true;
                    bt.Visible = true;
                    zera();
                    erros++;
                    label2.Text = "Erros: " + erros;
                }
            }
            else
            {
                bt = button2;
            }
        }
    }
    }