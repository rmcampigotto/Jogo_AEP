using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_I_AEP.br.com.codequest.view
{
    public partial class FormQuest4 : Form
    {
        public FormQuest4()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Incorreta!");
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Correta!");
            MessageBox.Show("PARABÉNS, você conclui noso jogu e gnahou um certificado de Master no Code Masters!!!!! ;)");

            this.Close();
        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Incorreta!");
        }

        private void btnOpcao4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Incorreta!");
        }
    }
}
