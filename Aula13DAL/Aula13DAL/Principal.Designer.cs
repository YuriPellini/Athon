namespace Aula13DAL
{
    partial class TelaP
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
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisivel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.comparaçãoToolStripMenuItem,
            this.divisivel3ToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.populaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // comparaçãoToolStripMenuItem
            // 
            this.comparaçãoToolStripMenuItem.Name = "comparaçãoToolStripMenuItem";
            this.comparaçãoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.comparaçãoToolStripMenuItem.Text = "Comparação";
            this.comparaçãoToolStripMenuItem.Click += new System.EventHandler(this.comparaçãoToolStripMenuItem_Click);
            // 
            // divisivel3ToolStripMenuItem
            // 
            this.divisivel3ToolStripMenuItem.Name = "divisivel3ToolStripMenuItem";
            this.divisivel3ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.divisivel3ToolStripMenuItem.Text = "Divisivel 3";
            this.divisivel3ToolStripMenuItem.Click += new System.EventHandler(this.divisivel3ToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.nomeToolStripMenuItem.Text = "Nome";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.nomeToolStripMenuItem_Click);
            // 
            // populaçãoToolStripMenuItem
            // 
            this.populaçãoToolStripMenuItem.Name = "populaçãoToolStripMenuItem";
            this.populaçãoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.populaçãoToolStripMenuItem.Text = "População";
            this.populaçãoToolStripMenuItem.Click += new System.EventHandler(this.populaçãoToolStripMenuItem_Click);
            // 
            // TelaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaP";
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisivel3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem populaçãoToolStripMenuItem;
    }
}

