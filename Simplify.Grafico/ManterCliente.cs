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
            cliente.RG_dados = tbRG.Text;
            cliente.Profissao_dados = tbProfissao.Text;
            cliente.Sexo_dados = tbSexo.Text;
            cliente.EstadoCivil_dados = tbEstadoCivil.Text;
            //Endereço1
            cliente.Endereco_endereco1 = tbEndereco1.Text;
            cliente.Rua_endereco1 = tbRua1.Text;
            cliente.Num_endereco1 = tbNumero1.Text;
            cliente.Complemento_endereco1 = tbComplemento1.Text;
            cliente.CEP_endereco1 = tbCep1.Text;
            cliente.Bairro_endereco1 = tbBairro1.Text;
            cliente.Cidade_endereco1 = tbCidade1.Text;
            //Endereço2
            cliente.Endereco_endereco2 = tbEndereco2.Text;
            cliente.Rua_endereco2 = tbRua2.Text;
            cliente.Num_endereco2 = tbNumero2.Text;
            cliente.Complemento_endereco2 = tbComplemento2.Text;
            cliente.CEP_endereco2 = tbCep2.Text;
            cliente.Bairro_endereco2 = tbBairro2.Text;
            cliente.Cidade_endereco2 = tbCidade2.Text;
            //Contato
            cliente.Residencial_contato = tbTelResidencial.Text;
            cliente.Celular1_contato = tbCel1.Text;
            cliente.Celular2_contato = tbCel2.Text;
            cliente.TelTrabalho_contato = tbTeltrabalho.Text;
            cliente.Email_contato = tbEmail.Text;
            cliente.Facebook_contato = tbFacebook.Text;
            cliente.NomeRecado_contato = tbNomerecados.Text;
            cliente.TelefoneRecado_contato = tbTelrecados.Text;
            //Ocorrencia
            cliente.Data_ocorrencia = tbDataocorrencia.Text;
            cliente.Local_ocorrencia = tbLocalocorrencia.Text;
            cliente.Veiculo_ocorrencia = tbVeiculosacidente.Text;
            cliente.Tipo_ocorrencia = gbTipoAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            cliente.INSS_ocorrencia = gbINSSAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            cliente.Horario_ocorrencia = tbHorarioacidente.Text;
            cliente.Lesao_ocorrencia = tbLesoesacidente.Text;
            cliente.Socorrista_ocorrencia = tbSocorrista.Text;
            cliente.Hospital_ocorrencia = tbHospital.Text;
            cliente.Observacao_ocorrencia = rtbObservacoes.Text;
            //Observaçoes
            cliente.Observacao_observacao = rtbAbaObservacoes.Text;
            //status
            cliente.Status = gbStatus.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;



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
            if (validacao.Valido)
            {
                this.Close();
            }
            
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

        private void ManterCliente_Shown(object sender, EventArgs e)
        {
            if (ClienteSelecionado != null)
            {
                /*Dados Pessoais*/
                this.tbNome.Text = ClienteSelecionado.Nome_dados;
                this.tbindicacao.Text = ClienteSelecionado.Indicacao_dados;
                this.tbNascimento.Text = ClienteSelecionado.Nascimento_dados;
                this.tbCpf.Text = ClienteSelecionado.CPF_dados;
                this.tbRG.Text = ClienteSelecionado.RG_dados;
                this.tbProfissao.Text = ClienteSelecionado.Profissao_dados;
                this.tbSexo.Text = ClienteSelecionado.Sexo_dados;
                this.tbEstadoCivil.Text = ClienteSelecionado.EstadoCivil_dados;
                //Endereço1
                this.tbEndereco1.Text = ClienteSelecionado.Endereco_endereco1;
                this.tbRua1.Text = ClienteSelecionado.Rua_endereco1;
                this.tbNumero1.Text = ClienteSelecionado.Num_endereco1;
                this.tbComplemento1.Text = ClienteSelecionado.Complemento_endereco1;
                this.tbCep1.Text = ClienteSelecionado.CEP_endereco1;
                this.tbBairro1.Text = ClienteSelecionado.Bairro_endereco1;
                this.tbCidade1.Text = ClienteSelecionado.Cidade_endereco1;
                //Endereço2
                this.tbEndereco2.Text = ClienteSelecionado.Endereco_endereco2;
                this.tbRua2.Text = ClienteSelecionado.Rua_endereco2;
                this.tbNumero2.Text = ClienteSelecionado.Num_endereco2;
                this.tbComplemento2.Text = ClienteSelecionado.Complemento_endereco2;
                this.tbCep2.Text = ClienteSelecionado.CEP_endereco2;
                this.tbBairro2.Text = ClienteSelecionado.Bairro_endereco2;
                this.tbCidade2.Text = ClienteSelecionado.Cidade_endereco2;
                //Contato
                this.tbTelResidencial.Text = ClienteSelecionado.Residencial_contato;
                this.tbCel1.Text = ClienteSelecionado.Celular1_contato;
                this.tbCel2.Text = ClienteSelecionado.Celular2_contato;
                this.tbTeltrabalho.Text = ClienteSelecionado.TelTrabalho_contato;
                this.tbEmail.Text = ClienteSelecionado.Email_contato;
                this.tbFacebook.Text = ClienteSelecionado.Facebook_contato;
                this.tbNomerecados.Text = ClienteSelecionado.NomeRecado_contato;
                this.tbTelrecados.Text = ClienteSelecionado.TelefoneRecado_contato;
                //Ocorrencia
                this.tbDataocorrencia.Text = ClienteSelecionado.Data_ocorrencia;
                this.tbLocalocorrencia.Text = ClienteSelecionado.Local_ocorrencia;
                this.tbVeiculosacidente.Text = ClienteSelecionado.Veiculo_ocorrencia;
                this.gbTipoAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text = ClienteSelecionado.Tipo_ocorrencia;
                this.gbINSSAcidente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text = ClienteSelecionado.INSS_ocorrencia;
                this.tbHorarioacidente.Text = ClienteSelecionado.Horario_ocorrencia;
                this.tbLesoesacidente.Text = ClienteSelecionado.Lesao_ocorrencia;
                this.tbSocorrista.Text = ClienteSelecionado.Socorrista_ocorrencia;
                this.tbHospital.Text = ClienteSelecionado.Hospital_ocorrencia;
                this.rtbObservacoes.Text = ClienteSelecionado.Observacao_ocorrencia;
                //Observaçoes
                this.rtbAbaObservacoes.Text = ClienteSelecionado.Observacao_observacao;
                //status
                this.gbStatus.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text = ClienteSelecionado.Status;
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
