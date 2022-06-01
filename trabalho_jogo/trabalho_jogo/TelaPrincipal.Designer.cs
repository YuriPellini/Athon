namespace trabalho_jogo
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adivinhaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batalhaMinadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMegaSenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adivinhaçãoToolStripMenuItem,
            this.batalhaMinadaToolStripMenuItem,
            this.miniMegaSenaToolStripMenuItem,
            this.forcaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adivinhaçãoToolStripMenuItem
            // 
            this.adivinhaçãoToolStripMenuItem.Name = "adivinhaçãoToolStripMenuItem";
            this.adivinhaçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.adivinhaçãoToolStripMenuItem.Text = "Adivinhação";
            this.adivinhaçãoToolStripMenuItem.Click += new System.EventHandler(this.adivinhaçãoToolStripMenuItem_Click);
            // 
            // batalhaMinadaToolStripMenuItem
            // 
            this.batalhaMinadaToolStripMenuItem.Name = "batalhaMinadaToolStripMenuItem";
            this.batalhaMinadaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.batalhaMinadaToolStripMenuItem.Text = "Batalha Minada";
            this.batalhaMinadaToolStripMenuItem.Click += new System.EventHandler(this.batalhaMinadaToolStripMenuItem_Click);
            // 
            // miniMegaSenaToolStripMenuItem
            // 
            this.miniMegaSenaToolStripMenuItem.Name = "miniMegaSenaToolStripMenuItem";
            this.miniMegaSenaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.miniMegaSenaToolStripMenuItem.Text = "Mini Mega Sena";
            this.miniMegaSenaToolStripMenuItem.Click += new System.EventHandler(this.miniMegaSenaToolStripMenuItem_Click);
            // 
            // forcaToolStripMenuItem
            // 
            this.forcaToolStripMenuItem.Name = "forcaToolStripMenuItem";
            this.forcaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.forcaToolStripMenuItem.Text = "Forca";
            this.forcaToolStripMenuItem.Click += new System.EventHandler(this.forcaToolStripMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Jogos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adivinhaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batalhaMinadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniMegaSenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forcaToolStripMenuItem;
    }
}

