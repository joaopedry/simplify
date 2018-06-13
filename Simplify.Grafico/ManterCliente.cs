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
    public partial class ManterCliente : Form
    {
        public Cliente ClienteSelecionado { get; set; }

        public ManterCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManterCliente_Load(object sender, EventArgs e)
        {

        }

        private void Sexo_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPF_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbindicacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDocVeiculopendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            /*Dados Pessoais*/
            cliente.Nome_dados = tbNome.Text;
            cliente.Indicacao_dados = tbindicacao.Text;
            cliente.Nascimento_dados = tbNascimento.Text;
            cliente.CPF_dados = tbCpf.Text;
            cliente.RG_dados = Double.Parse(tbRG.Text);
            cliente.Profissao_dados = tbProfissao.Text;
            cliente.Sexo_dados = tbSexo.Text;
            cliente.EstadoCivil_dados = tbEstadoCivil.Text;
            //Endereço1
            cliente.Endereco_endereco1 = tbEndereco1.Text;
            cliente.Rua_endereco1 = tbRua1.Text;
            cliente.Num_endereco1 = Int32.Parse(tbNumero1.Text);
            cliente.Complemento_endereco1 = tbComplemento1.Text;
            cliente.CEP_endereco1 = tbCep1.Text;
            cliente.Bairro_endereco1 = tbBairro1.Text;
            cliente.Cidade_endereco1 = tbCidade1.Text;
            //Endereço2
            cliente.Endereco_endereco2 = tbEndereco2.Text;
            cliente.Rua_endereco2 = tbRua2.Text;
            cliente.Num_endereco2 = Int32.Parse(tbNumero2.Text);
            cliente.Complemento_endereco2 = tbComplemento2.Text;
            cliente.CEP_endereco2 = tbCep2.Text;
            cliente.Bairro_endereco2 = tbBairro2.Text;
            cliente.Cidade_endereco2 = tbCidade2.Text;
            //Contato
            cliente.Residencial_contato = Double.Parse(tbTelResidencial.Text);
            cliente.Celular1_contato = Double.Parse(tbCel1.Text);
            cliente.Celular2_contato = Double.Parse(tbCel2.Text);
            cliente.TelTrabalho_contato = Double.Parse(tbTeltrabalho.Text);
            cliente.Email_contato = tbEmail.Text;
            cliente.Facebook_contato = tbFacebook.Text;
            cliente.NomeRecado_contato = tbNomerecados.Text;
            cliente.TelefoneRecado_contato = Double.Parse(tbTelrecados.Text);
            //Ocorrencia
            cliente.Data_ocorrencia = DateTime.Parse(tbDataocorrencia.Text);
            cliente.Local_ocorrencia = tbLocalocorrencia.Text;
            cliente.Veiculo_ocorrencia = tbVeiculosacidente.Text;
            cliente.Tipo_ocorrencia = gbTipoAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            cliente.INSS_ocorrencia = gbINSSAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            cliente.Horario_ocorrencia = DateTime.Parse(tbHorarioacidente.Text);
            cliente.Lesao_ocorrencia = tbLesoesacidente.Text;
            cliente.Socorrista_ocorrencia = tbSocorrista.Text;
            cliente.Hospital_ocorrencia = tbHospital.Text;
            cliente.Observacao_ocorrencia = rtbObservacoes.Text;
            //Observaçoes
            cliente.Observacao_observacao = rtbAbaObservacoes.Text;
            //status
            

            

            Validacao validacao;
            if (ClienteSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarCliente(cliente);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarCliente(cliente);
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
                MessageBox.Show("Cliente salvo com sucesso");
            }

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbCartaoentregue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbCartaobanco_Enter(object sender, EventArgs e)
        {

        }

        private void ManterCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Se você sair agora, todas as alterações não salvas serão perdidas.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void tbCpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; //ComboBox

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 1 || t.Text.Length == 5)
                    t.Text += ".";
                t.SelectionStart = t.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; //ComboBox

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 2 || t.Text.Length == 5)
                    t.Text += "/";
                t.SelectionStart = t.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)58)
            {
                e.Handled = true;
            }
        }

        private void tbNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbCep1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; //ComboBox

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 5)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //89227-064

        }
    }
}
