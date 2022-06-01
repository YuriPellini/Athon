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
    public partial class frmRegra3 : Form
    {
        public frmRegra3()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            //Variável
            int Num = Convert.ToInt32(txtNum.Text);
            //Retorno
            if (Num % 3 == 0)
                lblRes.Text = "Esse némro é divisível por 3";
            else
                lblRes.Text = "Esse número não é divisível por 3";
        }
    }
}
