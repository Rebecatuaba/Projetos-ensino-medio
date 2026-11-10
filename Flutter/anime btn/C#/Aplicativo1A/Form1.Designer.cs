namespace Aplicativo1A
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLn1 = new System.Windows.Forms.Label();
            this.LBLop = new System.Windows.Forms.Label();
            this.LBLn2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTpalpite = new System.Windows.Forms.TextBox();
            this.BUTTsorteio = new System.Windows.Forms.Button();
            this.BUTTconferir = new System.Windows.Forms.Button();
            this.BUTTlimpar = new System.Windows.Forms.Button();
            this.IMGsad = new System.Windows.Forms.PictureBox();
            this.IMGstart = new System.Windows.Forms.PictureBox();
            this.IMGhappy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMGsad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGhappy)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLn1
            // 
            this.LBLn1.AccessibleName = "";
            this.LBLn1.AutoSize = true;
            this.LBLn1.Cursor = System.Windows.Forms.Cursors.No;
            this.LBLn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LBLn1.Location = new System.Drawing.Point(124, 46);
            this.LBLn1.Name = "LBLn1";
            this.LBLn1.Size = new System.Drawing.Size(42, 46);
            this.LBLn1.TabIndex = 0;
            this.LBLn1.Text = "0";
            // 
            // LBLop
            // 
            this.LBLop.AutoSize = true;
            this.LBLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LBLop.Location = new System.Drawing.Point(191, 46);
            this.LBLop.Name = "LBLop";
            this.LBLop.Size = new System.Drawing.Size(42, 46);
            this.LBLop.TabIndex = 1;
            this.LBLop.Text = "?";
            // 
            // LBLn2
            // 
            this.LBLn2.AutoSize = true;
            this.LBLn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LBLn2.Location = new System.Drawing.Point(265, 46);
            this.LBLn2.Name = "LBLn2";
            this.LBLn2.Size = new System.Drawing.Size(42, 46);
            this.LBLn2.TabIndex = 2;
            this.LBLn2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(339, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // TXTpalpite
            // 
            this.TXTpalpite.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TXTpalpite.Location = new System.Drawing.Point(414, 43);
            this.TXTpalpite.Name = "TXTpalpite";
            this.TXTpalpite.Size = new System.Drawing.Size(78, 53);
            this.TXTpalpite.TabIndex = 4;
            this.TXTpalpite.Text = "?";
            // 
            // BUTTsorteio
            // 
            this.BUTTsorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BUTTsorteio.Location = new System.Drawing.Point(41, 336);
            this.BUTTsorteio.Name = "BUTTsorteio";
            this.BUTTsorteio.Size = new System.Drawing.Size(147, 47);
            this.BUTTsorteio.TabIndex = 8;
            this.BUTTsorteio.Text = "Sorteio";
            this.BUTTsorteio.UseVisualStyleBackColor = true;
            this.BUTTsorteio.Click += new System.EventHandler(this.BUTTsorteio_Click);
            // 
            // BUTTconferir
            // 
            this.BUTTconferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BUTTconferir.Location = new System.Drawing.Point(231, 336);
            this.BUTTconferir.Name = "BUTTconferir";
            this.BUTTconferir.Size = new System.Drawing.Size(147, 47);
            this.BUTTconferir.TabIndex = 9;
            this.BUTTconferir.Text = "Conferir";
            this.BUTTconferir.UseVisualStyleBackColor = true;
            this.BUTTconferir.Click += new System.EventHandler(this.BUTTconferir_Click);
            // 
            // BUTTlimpar
            // 
            this.BUTTlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BUTTlimpar.Location = new System.Drawing.Point(426, 336);
            this.BUTTlimpar.Name = "BUTTlimpar";
            this.BUTTlimpar.Size = new System.Drawing.Size(147, 47);
            this.BUTTlimpar.TabIndex = 10;
            this.BUTTlimpar.Text = "Limpar";
            this.BUTTlimpar.UseVisualStyleBackColor = true;
            this.BUTTlimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // IMGsad
            // 
            this.IMGsad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IMGsad.Image = global::Aplicativo1A.Properties.Resources.chopper_triste;
            this.IMGsad.Location = new System.Drawing.Point(414, 151);
            this.IMGsad.Name = "IMGsad";
            this.IMGsad.Size = new System.Drawing.Size(144, 125);
            this.IMGsad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGsad.TabIndex = 7;
            this.IMGsad.TabStop = false;
            // 
            // IMGstart
            // 
            this.IMGstart.Image = global::Aplicativo1A.Properties.Resources.chopper_sorteio;
            this.IMGstart.Location = new System.Drawing.Point(235, 151);
            this.IMGstart.Name = "IMGstart";
            this.IMGstart.Size = new System.Drawing.Size(144, 125);
            this.IMGstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGstart.TabIndex = 6;
            this.IMGstart.TabStop = false;
            // 
            // IMGhappy
            // 
            this.IMGhappy.Image = global::Aplicativo1A.Properties.Resources._988fd37373727cb6ed42578aa0dbe504;
            this.IMGhappy.Location = new System.Drawing.Point(44, 151);
            this.IMGhappy.Name = "IMGhappy";
            this.IMGhappy.Size = new System.Drawing.Size(144, 125);
            this.IMGhappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGhappy.TabIndex = 5;
            this.IMGhappy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.BUTTlimpar);
            this.Controls.Add(this.BUTTconferir);
            this.Controls.Add(this.BUTTsorteio);
            this.Controls.Add(this.IMGsad);
            this.Controls.Add(this.IMGstart);
            this.Controls.Add(this.IMGhappy);
            this.Controls.Add(this.TXTpalpite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLn2);
            this.Controls.Add(this.LBLop);
            this.Controls.Add(this.LBLn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMGsad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGhappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLn1;
        private System.Windows.Forms.Label LBLop;
        private System.Windows.Forms.Label LBLn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTpalpite;
        private System.Windows.Forms.PictureBox IMGhappy;
        private System.Windows.Forms.PictureBox IMGstart;
        private System.Windows.Forms.Button BUTTsorteio;
        private System.Windows.Forms.Button BUTTconferir;
        private System.Windows.Forms.Button BUTTlimpar;
        public System.Windows.Forms.PictureBox IMGsad;
    }
}

