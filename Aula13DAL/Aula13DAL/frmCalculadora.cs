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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //variáveis internas
            decimal Num1, Num2, Resulatante;
            //Conversão de valor
            Num1 = Convert.ToDecimal(txtNum1.Text);
            Num2 = Convert.ToDecimal(txtNum2.Text);
            //Seleção e Cálculo
            if (rbtnSoma.Checked)
                Resulatante = Num1 + Num2;
            else if (rbtnSub.Checked)
                Resulatante = Num1 - Num2;
            else if (rbtnMult.Checked)
                Resulatante = Num1 * Num2;
            else if (rbtnDiv.Checked)
                Resulatante = Num1 / Num2;
            else if (rbtnResto.Checked)
                Resulatante = Num1 % Num2;
            else
            {
                MessageBox.Show("Parabéns, você bugou o código.\n Aproveite o bug");
                Resulatante = 0;
            }
            //Retorno do valor resultante
            MessageBox.Show($"O resultado do cálculo é:{Resulatante}");
        }
    }
}
