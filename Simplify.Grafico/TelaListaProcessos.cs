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
    public partial class TelaListaProcessos : Form
    {
        Cliente cliente = new Cliente();
        public TelaListaProcessos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBuscarProcesso_Click(object sender, EventArgs e)
        {
            cliente.CPF_dados = tbBusca.Text;

            Validacao validacao;
            validacao = Program.Gerenciador.BuscaCliente(cliente);
            
            CarregaCliente();
            
            /*
            if (validacao.UsuarioValido)
            {
                MessageBox.Show("Login efetuado com sucesso!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AbreTelaPrincipal();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */
        }

        public void CarregaCliente()
        {
            lbCPF.Text = cliente.CPF_dados;
            lbNome.Text = cliente.Nome_dados;
            lbIndicacao.Text = cliente.Indicacao_dados;
            lbTelefone.Text = cliente.Celular1_contato.ToString();
            lbEmail.Text = cliente.Email_contato;
            lbEndereco.Text = cliente.Endereco_endereco1;
            lbBairro.Text = cliente.Bairro_endereco1;

        }

        private void TelaListaProcessos_Load(object sender, EventArgs e)
        {
        }

        private void TelaListaProcessos_Shown(object sender, EventArgs e)
        {
        }
    }
}
