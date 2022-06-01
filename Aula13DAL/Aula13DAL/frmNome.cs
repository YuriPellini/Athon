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
    public partial class frmNome : Form
    {
        public frmNome()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string Letra = Convert.ToString(txtNome.Text);
            string res = Letra.Substring(0, 1);
            MessageBox.Show(res);
        }
    }
}
