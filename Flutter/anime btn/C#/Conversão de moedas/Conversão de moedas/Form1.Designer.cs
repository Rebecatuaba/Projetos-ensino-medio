namespace Conversão_de_moedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox4 = new GroupBox();
            img = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Valor em reais";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(53, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 43);
            textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(409, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coitação";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(53, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 43);
            textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(409, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Valor ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 40);
            label1.Name = "label1";
            label1.Size = new Size(28, 24);
            label1.TabIndex = 0;
            label1.Text = "---";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(48, 594);
            button1.Name = "button1";
            button1.Size = new Size(174, 38);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "----------------------------", "Reais/Dolar", "Reais/Euro", "Reais/Yens", "Reais/Peso Cubano", "Reais/Peso Argentino" });
            comboBox1.Location = new Point(53, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(23, 29);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(332, 100);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Escolha a muedinha";
            // 
            // img
            // 
            img.Image = (Image)resources.GetObject("img.Image");
            img.Location = new Point(184, 314);
            img.Name = "img";
            img.Size = new Size(383, 223);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.TabIndex = 7;
            img.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(304, 594);
            button2.Name = "button2";
            button2.Size = new Size(174, 38);
            button2.TabIndex = 8;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(567, 594);
            button3.Name = "button3";
            button3.Size = new Size(174, 38);
            button3.TabIndex = 9;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 644);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(img);
            Controls.Add(groupBox4);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Button button1;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private Label label1;
        private PictureBox img;
        private Button button2;
        private Button button3;
    }
}