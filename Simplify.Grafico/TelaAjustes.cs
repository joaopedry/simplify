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
    public partial class TelaAjustes : Form
    {
        public TelaAjustes()
        {
            InitializeComponent();
            CarregaUsuario();
        }

        private void CarregaUsuario()
        {
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuario.MultiSelect = false;
            dgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuario.AutoGenerateColumns = false;
            List<Usuario> usuarios = Program.Gerenciador.TodosOsUsuarios();
            dgUsuario.DataSource = usuarios;
        }

        private void btAdicionarUsuario_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracaoUsuario(null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TelaAjuda ajuda = new TelaAjuda();
            ajuda.Show();
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAlterarUsuario_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Usuario usuarioSelecionado = (Usuario)dgUsuario.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracaoUsuario(usuarioSelecionado);
            }
        }

        private void AbreTelaInclusaoAlteracaoUsuario(Usuario usuarioSelecionado)
        {
            ManterUsuario tela = new ManterUsuario();
            tela.MdiParent = this.MdiParent;
            tela.UsuarioSelecionado = usuarioSelecionado;
            tela.FormClosed += TelaAjustes_FormClosed;
            tela.Show();
        }

        private bool VerificarSelecao()
        {
            if (dgUsuario.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void TelaAjustes_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaUsuario();
        }

        private void TelaAjustes_Load(object sender, EventArgs e)
        {
            CarregaUsuario();
        }

        private void btRemoverUsuario_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Usuario usuarioSelecionado = (Usuario)dgUsuario.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverUsuario(usuarioSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Usuario removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o Usuario");
                    }
                    CarregaUsuario();
                }
            }
        }
    }
}
