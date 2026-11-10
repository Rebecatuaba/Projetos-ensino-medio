namespace Calc.SalLiq
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDep = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSalL = new System.Windows.Forms.Label();
            this.lbIR = new System.Windows.Forms.Label();
            this.lbINSS = new System.Windows.Forms.Label();
            this.lbSalB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quant. Horas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Hora: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quant. Dep: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "IR: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "INSS: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salário Bruto: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salário Líquido: ";
            // 
            // tbHoras
            // 
            this.tbHoras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHoras.Location = new System.Drawing.Point(160, 33);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(227, 33);
            this.tbHoras.TabIndex = 8;
            // 
            // tbDep
            // 
            this.tbDep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDep.Location = new System.Drawing.Point(160, 128);
            this.tbDep.Name = "tbDep";
            this.tbDep.Size = new System.Drawing.Size(227, 33);
            this.tbDep.TabIndex = 16;
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbValor.Location = new System.Drawing.Point(160, 81);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(227, 33);
            this.tbValor.TabIndex = 17;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalcular.Location = new System.Drawing.Point(484, 33);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(123, 37);
            this.btCalcular.TabIndex = 18;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSair.Location = new System.Drawing.Point(484, 130);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(123, 37);
            this.btSair.TabIndex = 19;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.Location = new System.Drawing.Point(484, 80);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(123, 37);
            this.btLimpar.TabIndex = 20;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.lbDep);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbSalL);
            this.groupBox1.Controls.Add(this.lbIR);
            this.groupBox1.Controls.Add(this.lbINSS);
            this.groupBox1.Controls.Add(this.lbSalB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(36, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 272);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDep.Location = new System.Drawing.Point(212, 219);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(36, 25);
            this.lbDep.TabIndex = 27;
            this.lbDep.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Benefício Dep:";
            // 
            // lbSalL
            // 
            this.lbSalL.AutoSize = true;
            this.lbSalL.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSalL.Location = new System.Drawing.Point(212, 172);
            this.lbSalL.Name = "lbSalL";
            this.lbSalL.Size = new System.Drawing.Size(36, 25);
            this.lbSalL.TabIndex = 25;
            this.lbSalL.Text = "---";
            // 
            // lbIR
            // 
            this.lbIR.AutoSize = true;
            this.lbIR.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIR.Location = new System.Drawing.Point(212, 126);
            this.lbIR.Name = "lbIR";
            this.lbIR.Size = new System.Drawing.Size(36, 25);
            this.lbIR.TabIndex = 24;
            this.lbIR.Text = "---";
            this.lbIR.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbINSS
            // 
            this.lbINSS.AutoSize = true;
            this.lbINSS.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbINSS.Location = new System.Drawing.Point(212, 78);
            this.lbINSS.Name = "lbINSS";
            this.lbINSS.Size = new System.Drawing.Size(36, 25);
            this.lbINSS.TabIndex = 23;
            this.lbINSS.Text = "---";
            // 
            // lbSalB
            // 
            this.lbSalB.AutoSize = true;
            this.lbSalB.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSalB.Location = new System.Drawing.Point(212, 33);
            this.lbSalB.Name = "lbSalB";
            this.lbSalB.Size = new System.Drawing.Size(36, 25);
            this.lbSalB.TabIndex = 22;
            this.lbSalB.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(659, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbDep);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "INSS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbHoras;
        private TextBox tbDep;
        private TextBox tbValor;
        private Button btCalcular;
        private Button btSair;
        private Button btLimpar;
        private GroupBox groupBox1;
        private Label lbSalL;
        private Label lbIR;
        private Label lbINSS;
        private Label lbSalB;
        private Label lbDep;
        private Label label9;
    }
}