namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tcredI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taposta = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbls3 = new System.Windows.Forms.Label();
            this.lbls2 = new System.Windows.Forms.Label();
            this.lbls1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.tcredI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.taposta);
            this.groupBox1.Controls.Add(this.lblsaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor da Aposta:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(786, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 77);
            this.button4.TabIndex = 7;
            this.button4.Text = "Creditar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tcredI
            // 
            this.tcredI.Location = new System.Drawing.Point(612, 110);
            this.tcredI.Name = "tcredI";
            this.tcredI.Size = new System.Drawing.Size(146, 43);
            this.tcredI.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(612, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cred. Inicial: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(391, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aposta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taposta
            // 
            this.taposta.Location = new System.Drawing.Point(198, 110);
            this.taposta.Name = "taposta";
            this.taposta.Size = new System.Drawing.Size(146, 43);
            this.taposta.TabIndex = 3;
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsaldo.Location = new System.Drawing.Point(95, 85);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(47, 37);
            this.lblsaldo.TabIndex = 2;
            this.lblsaldo.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da Aposta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbls3);
            this.groupBox2.Controls.Add(this.lbls2);
            this.groupBox2.Controls.Add(this.lbls1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(32, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorteio:";
            // 
            // lbls3
            // 
            this.lbls3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbls3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbls3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbls3.Location = new System.Drawing.Point(687, 67);
            this.lbls3.Name = "lbls3";
            this.lbls3.Size = new System.Drawing.Size(155, 125);
            this.lbls3.TabIndex = 2;
            this.lbls3.Text = "00";
            this.lbls3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbls2
            // 
            this.lbls2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbls2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbls2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbls2.Location = new System.Drawing.Point(427, 67);
            this.lbls2.Name = "lbls2";
            this.lbls2.Size = new System.Drawing.Size(155, 125);
            this.lbls2.TabIndex = 1;
            this.lbls2.Text = "00";
            this.lbls2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbls1
            // 
            this.lbls1.BackColor = System.Drawing.Color.DarkCyan;
            this.lbls1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbls1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbls1.Location = new System.Drawing.Point(162, 67);
            this.lbls1.Name = "lbls1";
            this.lbls1.Size = new System.Drawing.Size(155, 125);
            this.lbls1.TabIndex = 0;
            this.lbls1.Text = "00";
            this.lbls1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(606, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(266, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 77);
            this.button3.TabIndex = 6;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox taposta;
        private Label lblsaldo;
        private Label label2;
        private GroupBox groupBox2;
        private Label lbls3;
        private Label lbls2;
        private Label lbls1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox tcredI;
        private Label label7;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
    }
}