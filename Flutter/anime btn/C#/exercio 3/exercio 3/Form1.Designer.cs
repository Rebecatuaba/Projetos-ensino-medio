namespace exercio_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.listLidos = new System.Windows.Forms.ListBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.listPares = new System.Windows.Forms.ListBox();
            this.listImpar = new System.Windows.Forms.ListBox();
            this.btArmaz = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSepar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotalP = new System.Windows.Forms.TextBox();
            this.tbPorcP = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbPorcI = new System.Windows.Forms.TextBox();
            this.tbTotalI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // listLidos
            // 
            this.listLidos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLidos.FormattingEnabled = true;
            this.listLidos.ItemHeight = 32;
            this.listLidos.Location = new System.Drawing.Point(21, 134);
            this.listLidos.Name = "listLidos";
            this.listLidos.Size = new System.Drawing.Size(200, 324);
            this.listLidos.TabIndex = 1;
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNum.Location = new System.Drawing.Point(144, 30);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(145, 39);
            this.tbNum.TabIndex = 2;
            // 
            // listPares
            // 
            this.listPares.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPares.FormattingEnabled = true;
            this.listPares.ItemHeight = 32;
            this.listPares.Location = new System.Drawing.Point(278, 134);
            this.listPares.Name = "listPares";
            this.listPares.Size = new System.Drawing.Size(200, 324);
            this.listPares.TabIndex = 3;
            // 
            // listImpar
            // 
            this.listImpar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listImpar.FormattingEnabled = true;
            this.listImpar.ItemHeight = 32;
            this.listImpar.Location = new System.Drawing.Point(536, 134);
            this.listImpar.Name = "listImpar";
            this.listImpar.Size = new System.Drawing.Size(200, 324);
            this.listImpar.TabIndex = 4;
            // 
            // btArmaz
            // 
            this.btArmaz.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btArmaz.Location = new System.Drawing.Point(307, 28);
            this.btArmaz.Name = "btArmaz";
            this.btArmaz.Size = new System.Drawing.Size(171, 42);
            this.btArmaz.TabIndex = 5;
            this.btArmaz.Text = "Armazenar";
            this.btArmaz.UseVisualStyleBackColor = true;
            this.btArmaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSair.Location = new System.Drawing.Point(840, 269);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(143, 52);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.Location = new System.Drawing.Point(840, 201);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(143, 52);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSepar
            // 
            this.btSepar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSepar.Location = new System.Drawing.Point(840, 134);
            this.btSepar.Name = "btSepar";
            this.btSepar.Size = new System.Drawing.Size(143, 52);
            this.btSepar.TabIndex = 8;
            this.btSepar.Text = "Separar";
            this.btSepar.UseVisualStyleBackColor = true;
            this.btSepar.Click += new System.EventHandler(this.btSepar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Percentual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(685, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total números:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(398, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Percentual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(398, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            // 
            // tbTotalP
            // 
            this.tbTotalP.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotalP.Location = new System.Drawing.Point(201, 512);
            this.tbTotalP.Name = "tbTotalP";
            this.tbTotalP.Size = new System.Drawing.Size(100, 39);
            this.tbTotalP.TabIndex = 15;
            // 
            // tbPorcP
            // 
            this.tbPorcP.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPorcP.Location = new System.Drawing.Point(201, 565);
            this.tbPorcP.Name = "tbPorcP";
            this.tbPorcP.Size = new System.Drawing.Size(100, 39);
            this.tbPorcP.TabIndex = 16;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotal.Location = new System.Drawing.Point(883, 558);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 39);
            this.tbTotal.TabIndex = 17;
            // 
            // tbPorcI
            // 
            this.tbPorcI.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPorcI.Location = new System.Drawing.Point(564, 562);
            this.tbPorcI.Name = "tbPorcI";
            this.tbPorcI.Size = new System.Drawing.Size(100, 39);
            this.tbPorcI.TabIndex = 18;
            // 
            // tbTotalI
            // 
            this.tbTotalI.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotalI.Location = new System.Drawing.Point(564, 512);
            this.tbTotalI.Name = "tbTotalI";
            this.tbTotalI.Size = new System.Drawing.Size(100, 39);
            this.tbTotalI.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 623);
            this.Controls.Add(this.tbTotalI);
            this.Controls.Add(this.tbPorcI);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbPorcP);
            this.Controls.Add(this.tbTotalP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSepar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btArmaz);
            this.Controls.Add(this.listImpar);
            this.Controls.Add(this.listPares);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.listLidos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listLidos;
        private TextBox tbNum;
        private ListBox listPares;
        private ListBox listImpar;
        private Button btArmaz;
        private Button btSair;
        private Button btLimpar;
        private Button btSepar;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbTotalP;
        private TextBox tbPorcP;
        private TextBox tbTotal;
        private TextBox tbPorcI;
        private TextBox tbTotalI;
    }
}