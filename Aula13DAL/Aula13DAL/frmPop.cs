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
    public partial class frmPop : Form
    {
        public frmPop()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int i;
            double P1, P2;
            i = 0;
            P1 = 5000000;
            P2 = 7000000;
            while(P1 <= P2)
            {
                P1 = P1 * 1.03;
                P2 = P2 * 1.02;
                i++;
            }
            MessageBox.Show($"O némero de anos que vai demorarar\npara uma população passar a outra é de {i} anos");
        }
    }
}
