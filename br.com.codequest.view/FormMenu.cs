using Jogo_I_AEP.br.com.codequest.view;
using System;
using System.Windows.Forms;

namespace Jogo_I_AEP
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormQuest1 form = new FormQuest1();
            form.Show();
            this.Hide();
        }
    }
}
