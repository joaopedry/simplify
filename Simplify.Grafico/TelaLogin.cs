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
            
        }

        private void TelaLhogin_Load(object sender, EventArgs e)
        {
            btLogin.Text = "OK";
            btLogin.DialogResult = DialogResult.OK;
            btSair.Text = "Cancelar";
            btSair.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btLogin;
            this.CancelButton = btSair;
        }
    }
}
