using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13DAL
{
    public partial class TelaP : Form
    {
        public TelaP()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora tela = new frmCalculadora();
            tela.MdiParent = this;
            tela.Show();
        }

        private void comparaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComparacao tela = new frmComparacao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void divisivel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegra3 tela = new frmRegra3();
            tela.MdiParent = this;
            tela.Show();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNome tela = new frmNome();
            tela.MdiParent = this;
            tela.Show();
        }

        private void populaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPop tela = new frmPop();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
