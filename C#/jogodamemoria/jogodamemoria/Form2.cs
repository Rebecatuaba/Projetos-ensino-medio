using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodamemoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void nívelInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Nivl1 = new Form1();
            Nivl1.Show();
        }
    }
}
