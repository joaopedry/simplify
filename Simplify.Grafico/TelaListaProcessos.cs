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
            lbRua.Text = cliente.Rua_endereco1;
            lbBairro.Text = cliente.Bairro_endereco1;
            lbReferencia.Text = cliente.Complemento_endereco1;
            lbLesoes.Text = cliente.Lesao_ocorrencia;
            lbData.Text = cliente.Data_ocorrencia.ToString();
            lbSocorrista.Text = cliente.Socorrista_ocorrencia;
            lbProfissao.Text = cliente.Profissao_dados;
            lbVeiculos.Text = cliente.Veiculo_ocorrencia;
            lbNumerocasa.Text = cliente.Num_endereco1.ToString();
            lbCidade.Text = cliente.Cidade_endereco1;
            //lbRegistro.Text = cliente
            lbHorario.Text = cliente.Horario_ocorrencia.ToString();
            lbHospital.Text = cliente.Hospital_ocorrencia;
            lbTipo.Text = cliente.Tipo_ocorrencia;
            lbLocal.Text = cliente.Local_ocorrencia;
            lbObservacoes.Text = cliente.Observacao_observacao;

        }

        private void TelaListaProcessos_Load(object sender, EventArgs e)
        {
        }

        private void TelaListaProcessos_Shown(object sender, EventArgs e)
        {
        }

        
    }
}
