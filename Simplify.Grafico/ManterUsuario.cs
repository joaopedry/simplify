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
            if (Int64.TryParse(tbIdUsuario.Text, out long value))
            {
                usuario.Id = value;
            }
            else
            {
                usuario.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }
            usuario.Funcao_usuario = gbFuncao.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
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

        private void tbMatriculaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManterUsuario_Shown(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                this.tbIdUsuario.Text = UsuarioSelecionado.Id.ToString();
                this.tbNomeUsuario.Text = UsuarioSelecionado.Nome_usuario;
                this.tbEmailUsuario.Text = UsuarioSelecionado.Email_usuario;
                this.tbLoginUsuario.Text = UsuarioSelecionado.Login_usuario;
                this.tbSenhaUsuario.Text = UsuarioSelecionado.Password_usuario;
                this.gbFuncao.Text = UsuarioSelecionado.Funcao_usuario;
            }
        }

        private void btCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbAdminUsuario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManterUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
