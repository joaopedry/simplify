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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
           // LoginRoot();
        }

       /* private void LoginRoot()
        {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Administrador_usuario = true;
            usuario.Nome_usuario = "root";
            usuario.Email_usuario = "root@simplify.com.br";
            usuario.Login_usuario = "root";
            usuario.Password_usuario = "root";

            Validacao validacao;
            validacao = Program.Gerenciador.AdicionarUsuario(usuario);

            
            usuarioBanco.Login_usuario = usuarioAlterado.Login_usuario;
            usuarioBanco.Password_usuario = usuarioAlterado.Password_usuario;
             
        }*/

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
