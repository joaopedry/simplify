using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //TelaPrincipal telaPrincipal = new TelaPrincipal();
            //telaPrincipal.Show();
        }

        private void TelaLhogin_Load(object sender, EventArgs e)
        {
            btLogin.Text = "OK";
            // ... você tem que indicar isso na propriedade
            // DialogResult dele
            btLogin.DialogResult = DialogResult.OK;

            // O botão 2 vai ser o Cancelar...
            btSair.Text = "Cancelar";
            btSair.DialogResult = DialogResult.Cancel;

            // Aí você seta no Form que o OK é o AcceptButton...
            this.AcceptButton = btLogin;

            // .... e que o Cancel é o CancelButton
            this.CancelButton = btSair;
        }
    }
}
