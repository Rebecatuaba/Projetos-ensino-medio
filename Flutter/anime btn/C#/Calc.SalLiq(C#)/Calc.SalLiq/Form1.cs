using System.Drawing;

namespace Calc.SalLiq
{
    public partial class Form1 : Form
    {
        double SalB = 0, SalS = 0, SalL = 0, IR = 0, INSS = 0, QH = 0, VH = 0;
        double QD = 0, Dep = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbDep.Text = "";
            tbHoras.Text = "";

            lbINSS.Text = "---";
            lbIR.Text = "---";
            lbSalB.Text = "---";
            tbValor.Text = "";
            lbSalL.Text = "---";
            lbDep.Text = "---";
            tbHoras.Focus();
        }
        private void inss()
        {
            if (INSS <= 828.39) {
                lbINSS.Text = "" + Math.Round(INSS, 2);
            }
        }
        private void ir()
        {
                lbIR.Text = "" + Math.Round(IR, 2);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            QD = Convert.ToDouble(tbDep.Text);
            QH = Convert.ToDouble(tbHoras.Text);
            VH = Convert.ToDouble(tbValor.Text);

            SalB = QH * VH;
            lbSalB.Text = "" + SalB;

            if (SalB <= 1212.00)
            {
               INSS =  SalB * 0.075;
                inss();
            }
            else if ((SalB >= 1212.01) && (SalB <= 2427.35)){
                INSS = SalB * 0.09;
                INSS = INSS - 18.18;
                inss();
            }
            else if ((SalB >= 2427.36 ) && (SalB <= 3641.03)){
                INSS = SalB * 0.12;
                INSS = INSS - 91.00;
                inss();
            }
            else if ((SalB >= 3641.04 ) && (SalB <=  7087.22))
            {
                INSS = SalB * 0.14;
                INSS = INSS - 163.82;
                inss();
            }
            else if (SalB > 7087.22)
            {
                INSS = 828.39;
                inss();
            }

            Dep = QD * 189.59;
            lbDep.Text = "" + Math.Round(Dep, 2);

            SalS = SalB - 189.59 * QD - INSS;
            if (SalS <= 1903.98){
              
            }
            else if ((SalS >= 1903.99) && ( SalS <= 2826.65)) { 
                IR = SalS * 0.075;
                IR = IR - 142.8;
                ir();
            }
            else if ((SalS >= 2826.66 ) && (SalS <= 3751.05)) { 
                IR = SalS * 0.15 ;
                IR = IR - 354.80;
                ir();
            }
            else if ((SalS >= 3751.06 ) && (SalS <= 4664.68))
            {
                IR = SalS * 0.225;
                IR = IR - 636.13;
                ir();
            }
            else if (SalS >= 4664.68)
            {
                IR = SalS * 0.275;
                IR = IR - 869.36;
                ir();
            }

            SalL = SalB - INSS - IR;
            lbSalL.Text = "" + Math.Round(SalL, 2);
        }
    }
}