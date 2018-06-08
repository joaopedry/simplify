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
    public partial class TelaSenhaUsuarios : Form
    {
        public TelaSenhaUsuarios()
        {
            InitializeComponent();
        }

        private void btAcessarAjustes_Click(object sender, EventArgs e)
        {
            TelaAjustes tela = new TelaAjustes();
            this.Close();
            tela.Show();
        }

        private void TelaSenhaUsuarios_Load(object sender, EventArgs e)
        {

            btAcessarAjustes.Text = "OK";
            btAcessarAjustes.DialogResult = DialogResult.OK;
            btCancelar.Text = "Cancelar";
            btCancelar.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btAcessarAjustes;
            this.CancelButton = btCancelar;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
