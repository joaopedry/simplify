using Simplify.Negocio;
using Simplify.Negocio.Models;
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
            Usuario usuario = new Usuario();

            usuario.Login_usuario = tbUser_Admin.Text;
            usuario.Password_usuario = tbSenha_admin.Text;

            Validacao validacaoUser = new Validacao();
            validacaoUser = Program.Gerenciador.VerificaUsuario2(usuario);

            if (validacaoUser.Valido)
            {
                tela.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar esta área", "Acesso negado",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            
            
            
            
        }

        private void TelaSenhaUsuarios_Load(object sender, EventArgs e)
        {

            btAcessarAjustes.Text = "OK";
            btAcessarAjustes.DialogResult = DialogResult.OK;
            btSair.Text = "Cancelar";
            btSair.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btAcessarAjustes;
            this.CancelButton = btSair;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
