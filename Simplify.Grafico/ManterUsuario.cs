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
    public partial class ManterUsuario : Form
    {
        public Usuario UsuarioSelecionado { get; set; }

        public ManterUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSalvarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            /*Cadatro usuario sistema*/
            usuario.Nome_usuario = tbNomeUsuario.Text;
            usuario.Email_usuario = tbEmailUsuario.Text;
            usuario.Login_usuario = tbLoginUsuario.Text;
            usuario.Password_usuario = tbSenhaUsuario.Text;

            Validacao validacao;
            if (UsuarioSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarUsuario(usuario);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarUsuario(usuario);
            }



            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Usuario cadastrado com sucesso");
            }
            this.Close();
        }
    }
}
