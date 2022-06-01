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
    public partial class frmComparacao : Form
    {
        public frmComparacao()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            //Variáveis internas
            int Num1, Num2;
            //Converção
            Num1 = Convert.ToInt32(nupNum1.Value);
            Num2 = Convert.ToInt32(nupNum2.Value);
            //Comparação e retorno de dados
            if (Num1 == Num2)
                MessageBox.Show("Os números são iguais");
            else if (Num1 > Num2)
                MessageBox.Show($"O maior número é o {Num1}");
            else
                MessageBox.Show($"O maior número é o {Num2}");
        }
    }
}
