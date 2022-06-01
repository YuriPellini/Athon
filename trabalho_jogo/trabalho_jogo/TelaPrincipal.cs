using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_jogo
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void adivinhaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batalhaMinadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMina Tela = new frmMina();
            Tela.MdiParent = this;
            Tela.Show();
        }

        private void miniMegaSenaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
