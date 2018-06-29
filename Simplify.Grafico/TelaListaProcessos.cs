using Simplify.Negocio;
using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    public partial class TelaListaProcessos : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        Cliente cliente = new Cliente();
        public string ClienteProcesso;
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
            BuscandoProcesso();
        }

        public void BuscandoProcesso()
        {
            if (tbBusca != null)
            {
                cliente.CPF_dados = tbBusca.Text;
                ClienteProcesso = tbBusca.Text;
                Validacao validacao;
                validacao = Program.Gerenciador.BuscaCliente(cliente);

                if (validacao.UsuarioValido)
                {
                    CarregaCliente();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe um CPF!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //return cliente.CPF_dados;
        }

        public void CarregaCliente()
        {
            
            lbCPF.Text = cliente.CPF_dados;
            lbNome.Text = cliente.Nome_dados;
            lbIndicacao.Text = cliente.Indicacao_dados;
            lbTelefone.Text = cliente.Celular1_contato;
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
        private void CarregaDatagrid()
        {
            if (tbBusca.Text == "")
            {
                dgTodosOsClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgTodosOsClientes.MultiSelect = false;
                dgTodosOsClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgTodosOsClientes.AutoGenerateColumns = false;
                List<Cliente> clientes = Program.Gerenciador.TodosOsClientes();
                dgTodosOsClientes.DataSource = clientes;
            }
            else
            {
                dgTodosOsClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgTodosOsClientes.MultiSelect = false;
                dgTodosOsClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgTodosOsClientes.AutoGenerateColumns = false;
                List<Cliente> clientes = Program.Gerenciador.FiltraGrid(tbBusca.Text);
                dgTodosOsClientes.DataSource = clientes;
            }

        }

        private void TelaListaProcessos_Load(object sender, EventArgs e)
        {
            CarregaDatagrid();
        }

        private void TelaListaProcessos_Shown(object sender, EventArgs e)
        {
        }

        private void AbreTelaInclusaoAlteracao(Cliente clienteSelecionado)
        {
            ManterCliente tela = new ManterCliente();
            tela.MdiParent = this.MdiParent;
            tela.ClienteSelecionado = clienteSelecionado;
            tela.FormClosed += TelaListaProcessos_FormClosed;
            tela.Show();
        }

        private bool VerificarSelecao()
        {
            if (dgTodosOsClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void TelaListaProcessos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btAlterarDados_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Cliente clienteSelecionado = (Cliente)dgTodosOsClientes.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(clienteSelecionado);
            }
        }

        private void btImprimirFolhaDeRosto_Click(object sender, EventArgs e)
        {
            


            //btImprimirFolhaDeRosto.Click += new EventHandler(btImprimirFolhaDeRosto_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            
            this.Controls.Add(btImprimirFolhaDeRosto);
            
            CaptureScreen();
            printDocument1.Print();
        }

        private void dgTodosOsClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaListaProcessos_Activated(object sender, EventArgs e)
        {
            CarregaDatagrid();
        }

        private void tbBusca_KeyUp(object sender, KeyEventArgs e)
        {
            CarregaDatagrid();
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, -330, -50, s);
            //Imprimir();
            
        }

        private void printDocument1_PrintPage(System.Object sender,
          System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Imprimir()
        {
            
        }

        private void btImprimirFolhaDeRosto_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tbBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; // ou ComboBox

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
