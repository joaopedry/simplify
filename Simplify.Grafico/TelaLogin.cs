using Simplify.Negocio;
using Simplify.Negocio.Models;
using Simplify.Negocio.Persistencia;
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
        public Usuario LoginInformado { get; set; }

        private Banco banco = new Banco();

        public TelaLogin()
        {
            InitializeComponent();
            LoginRoot();
        }

        private void LoginRoot()
        {
            /*Criando usuario root*/

            if (this.banco.Usuarios.Where(c => c.Id == 1).Any())
            {
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Id = 1;
                usuario.Funcao_usuario = "Administrador";
                usuario.Nome_usuario = "root";
                usuario.Email_usuario = "root@simplify.com.br";
                usuario.Login_usuario = "root";
                usuario.Password_usuario = "root";

                Validacao validacao;
                validacao = Program.Gerenciador.AdicionarUsuario(usuario);
            }
        }

        

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Login_usuario = tbUsuario.Text;
            usuario.Password_usuario = tbSenha.Text;

            Validacao validacao;
            validacao = Program.Gerenciador.VerificaUsuario(usuario);
            
            if (validacao.UsuarioValido)
            {
                AbreTelaPrincipal();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void AbreTelaPrincipal()
        {
            TelaPrincipal tela = new TelaPrincipal();
            this.Hide();
            tela.ShowDialog();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }
    }
}
