namespace jogodamemoria
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoDaMemóriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nívelInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nívelAvançadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoDaMemóriaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoDaMemóriaToolStripMenuItem
            // 
            this.jogoDaMemóriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nívelInicialToolStripMenuItem,
            this.nívelAvançadoToolStripMenuItem});
            this.jogoDaMemóriaToolStripMenuItem.Name = "jogoDaMemóriaToolStripMenuItem";
            this.jogoDaMemóriaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.jogoDaMemóriaToolStripMenuItem.Text = "Jogo da Memória";
            // 
            // nívelInicialToolStripMenuItem
            // 
            this.nívelInicialToolStripMenuItem.Name = "nívelInicialToolStripMenuItem";
            this.nívelInicialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nívelInicialToolStripMenuItem.Text = "Nível Inicial";
            this.nívelInicialToolStripMenuItem.Click += new System.EventHandler(this.nívelInicialToolStripMenuItem_Click);
            // 
            // nívelAvançadoToolStripMenuItem
            // 
            this.nívelAvançadoToolStripMenuItem.Name = "nívelAvançadoToolStripMenuItem";
            this.nívelAvançadoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nívelAvançadoToolStripMenuItem.Text = "Nível Avançado";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem jogoDaMemóriaToolStripMenuItem;
        private ToolStripMenuItem nívelInicialToolStripMenuItem;
        private ToolStripMenuItem nívelAvançadoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}