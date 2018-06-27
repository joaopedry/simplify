using Simplify.Negocio;
using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    public partial class ManterCliente : Form
    {
        Cliente cliente = new Cliente();

        //var
        public Cliente ClienteSelecionado { get; set; }
        public String ArquivoShow;
        public PictureBox arq;
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
            //caminho
            cliente.caminhoBoletim_anexos = tbBoletimOcorrencia.Text;
            cliente.caminhoProntuario_anexos = tbProntuario.Text;
            cliente.caminhoComprovanteResidencia_anexos = tbComprovanteResidencia.Text;
            cliente.caminhoCartaoBanco_anexos = tbCartaoBanco.Text;
            cliente.caminhoRG_anexos = tbDOCRG.Text;
            cliente.caminhoCPF_anexos = tbDOCCPF.Text;
            cliente.caminhoCNH_anexos = tbDOCCNH.Text;
            cliente.caminhoDOCVeiculo_anexos = tbDOCVeiculo.Text;
            if (tbBoletimOcorrencia.Text == "")
            {
                cliente.BoletimOcorrencia_anexos = "Pendente";
            }
            else
            {
                cliente.BoletimOcorrencia_anexos = "Enviado";
            }
            //prontuario
            if (tbProntuario.Text == "")
            {
                cliente.Prontuario_anexos = "Pendente";
            }
            else
            {
                cliente.Prontuario_anexos = "Enviado";
            }
            //comprovante
            if (tbComprovanteResidencia.Text == "")
            {
                cliente.ComprovanteResidencia_anexos = "Pendente";
            }
            else
            {
                cliente.ComprovanteResidencia_anexos = "Enviado";
            }
            //cartão banco
            if (tbCartaoBanco.Text == "")
            {
                cliente.CartaoBanco_anexos = "Pendente";
            }
            else
            {
                cliente.CartaoBanco_anexos = "Enviado";
            }
            //rg
            if (tbDOCRG.Text == "")
            {
                cliente.RG_anexos = "Pendente";
            }
            else
            {
                cliente.RG_anexos = "Enviado";
            }
            //cpf
            if (tbDOCCPF.Text == "")
            {
                cliente.CPF_anexos = "Pendente";
            }
            else
            {
                cliente.CPF_anexos = "Enviado";
            }
            //cnh
            if (tbDOCCNH.Text == "")
            {
                cliente.CNH_anexos = "Pendente";
            }
            else
            {
                cliente.CNH_anexos = "Enviado";
            }
            //doc veiculo
            if (tbDOCVeiculo.Text == "")
            {
                cliente.DOCVeiculo_anexos = "Pendente";
            }
            else
            {
                cliente.DOCVeiculo_anexos = "Enviado";
            }

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
                //Caminho arquivo
                this.tbBoletimOcorrencia.Text       = ClienteSelecionado.caminhoBoletim_anexos;
                this.tbProntuario.Text              = ClienteSelecionado.caminhoProntuario_anexos;
                this.tbComprovanteResidencia.Text   = ClienteSelecionado.caminhoComprovanteResidencia_anexos;
                this.tbCartaoBanco.Text             = ClienteSelecionado.caminhoCartaoBanco_anexos;
                this.tbDOCRG.Text                   = ClienteSelecionado.caminhoRG_anexos;
                this.tbDOCCPF.Text                  = ClienteSelecionado.caminhoCPF_anexos;
                this.tbDOCCNH.Text                  = ClienteSelecionado.caminhoCNH_anexos;
                this.tbDOCVeiculo.Text              = ClienteSelecionado.caminhoDOCVeiculo_anexos;
                BoletimMostrar();
                ProntuarioMostrar();
                ComprovanteMostrar();
                CartaoMostrar();
                RGMostrar();
                CPFMostrar();
                CNHMostrar();
                DOCVeiculoMostrar();
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        public void btAnexarBO_Click(object sender, EventArgs e)
        {
            if (tbBoletimOcorrencia.Text == "")
            {
                this.ofdBoletimOcorrencia.Title = "Selecionar Fotos";
                ofdBoletimOcorrencia.InitialDirectory = @"C:\Users";
                //filtra para exibir somente arquivos de imagens
                ofdBoletimOcorrencia.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdBoletimOcorrencia.CheckFileExists = true;
                ofdBoletimOcorrencia.CheckPathExists = true;
                ofdBoletimOcorrencia.FilterIndex = 2;
                ofdBoletimOcorrencia.RestoreDirectory = true;
                ofdBoletimOcorrencia.ReadOnlyChecked = true;
                ofdBoletimOcorrencia.ShowReadOnly = true;

                DialogResult dr = this.ofdBoletimOcorrencia.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdBoletimOcorrencia.FileNames)
                    {
                        // cria um PictureBox
                        try
                        {
                            PictureBox pb = new PictureBox();
                            // Le os arquivos selecionados 
                            tbBoletimOcorrencia.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpBoletim.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbBoletimOcorrencia.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbBoletimOcorrencia.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarprontuario_Click(object sender, EventArgs e)
        {
            if (tbProntuario.Text == "")
            {
                this.ofdProntuario.Title = "Selecionar Fotos";
                ofdProntuario.InitialDirectory = @"C:\Users";
                //filtra para exibir somente arquivos de imagens
                ofdProntuario.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdProntuario.CheckFileExists = true;
                ofdProntuario.CheckPathExists = true;
                ofdProntuario.FilterIndex = 2;
                ofdProntuario.RestoreDirectory = true;
                ofdProntuario.ReadOnlyChecked = true;
                ofdProntuario.ShowReadOnly = true;

                DialogResult dr = this.ofdProntuario.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdProntuario.FileNames)
                    {
                        // cria um PictureBox
                        try
                        {
                            PictureBox pb = new PictureBox();
                            tbProntuario.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpProntuario.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbProntuario.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbProntuario.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarcomprovante_Click(object sender, EventArgs e)
        {
            if (tbComprovanteResidencia.Text == "")
            {
                this.ofdComprovanteResidencia.Title = "Selecionar Fotos";
                ofdComprovanteResidencia.InitialDirectory = @"C:\Users";
                ofdComprovanteResidencia.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdComprovanteResidencia.CheckFileExists = true;
                ofdComprovanteResidencia.CheckPathExists = true;
                ofdComprovanteResidencia.FilterIndex = 2;
                ofdComprovanteResidencia.RestoreDirectory = true;
                ofdComprovanteResidencia.ReadOnlyChecked = true;
                ofdComprovanteResidencia.ShowReadOnly = true;

                DialogResult dr = this.ofdComprovanteResidencia.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdComprovanteResidencia.FileNames)
                    {
                        // cria um PictureBox
                        try
                        {
                            PictureBox pb = new PictureBox();
                            // Le os arquivos selecionados 
                            tbComprovanteResidencia.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpComprovanteResidencia.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbComprovanteResidencia.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbComprovanteResidencia.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarcartao_Click(object sender, EventArgs e)
        {
            if (tbCartaoBanco.Text == "")
            {
                this.ofdCartaoBanco.Title = "Selecionar Fotos";
                ofdCartaoBanco.InitialDirectory = @"C:\Users";
                //filtra para exibir somente arquivos de imagens
                ofdCartaoBanco.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdCartaoBanco.CheckFileExists = true;
                ofdCartaoBanco.CheckPathExists = true;
                ofdCartaoBanco.FilterIndex = 2;
                ofdCartaoBanco.RestoreDirectory = true;
                ofdCartaoBanco.ReadOnlyChecked = true;
                ofdCartaoBanco.ShowReadOnly = true;

                DialogResult dr = this.ofdCartaoBanco.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdCartaoBanco.FileNames)
                    {
                        try
                        {
                            PictureBox pb = new PictureBox();
                            // Le os arquivos selecionados 
                            tbCartaoBanco.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpCartaoBanco.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbCartaoBanco.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbCartaoBanco.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarRG_Click(object sender, EventArgs e)
        {
            if (tbDOCRG.Text == "")
            {
                this.ofdRG.Title = "Selecionar Fotos";
                ofdRG.InitialDirectory = @"C:\Users";
                //filtra para exibir somente arquivos de imagens
                ofdRG.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdRG.CheckFileExists = true;
                ofdRG.CheckPathExists = true;
                ofdRG.FilterIndex = 2;
                ofdRG.RestoreDirectory = true;
                ofdRG.ReadOnlyChecked = true;
                ofdRG.ShowReadOnly = true;

                DialogResult dr = this.ofdRG.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdRG.FileNames)
                    {
                        try
                        {
                            PictureBox pb = new PictureBox();
                            // Le os arquivos selecionados 
                            tbDOCRG.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpRG.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbDOCRG.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbDOCRG.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarCPF_Click(object sender, EventArgs e)
        {
            if (tbDOCCPF.Text == "")
            {
                this.ofdCPF.Title = "Selecionar Fotos";
                ofdCPF.InitialDirectory = @"C:\Users";
                //filtra para exibir somente arquivos de imagens
                ofdCPF.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdCPF.CheckFileExists = true;
                ofdCPF.CheckPathExists = true;
                ofdCPF.FilterIndex = 2;
                ofdCPF.RestoreDirectory = true;
                ofdCPF.ReadOnlyChecked = true;
                ofdCPF.ShowReadOnly = true;

                DialogResult dr = this.ofdCPF.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdCPF.FileNames)
                    {
                        try
                        {
                            PictureBox pb = new PictureBox();
                            // Le os arquivos selecionados 
                            tbDOCCPF.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpCPF.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbDOCCPF.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbDOCCPF.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
           
        }

        private void btAnexarCNH_Click(object sender, EventArgs e)
        {
            if (tbDOCCNH.Text == "")
            {
                this.ofdCNH.Title = "Selecionar Fotos";
                ofdCNH.InitialDirectory = @"C:\Users";
                ofdCNH.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdCNH.CheckFileExists = true;
                ofdCNH.CheckPathExists = true;
                ofdCNH.FilterIndex = 2;
                ofdCNH.RestoreDirectory = true;
                ofdCNH.ReadOnlyChecked = true;
                ofdCNH.ShowReadOnly = true;

                DialogResult dr = this.ofdCNH.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdCNH.FileNames)
                    {
                        try
                        {
                            PictureBox pb = new PictureBox();
                            tbDOCCNH.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpCNH.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbDOCCNH.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbDOCCNH.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        private void btAnexarDocVeiculo_Click(object sender, EventArgs e)
        {
            if (tbDOCVeiculo.Text == "")
            {
                this.ofdDOCVeiculo.Title = "Selecionar Fotos";
                ofdDOCVeiculo.InitialDirectory = @"C:\Users";
                ofdDOCVeiculo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                ofdDOCVeiculo.CheckFileExists = true;
                ofdDOCVeiculo.CheckPathExists = true;
                ofdDOCVeiculo.FilterIndex = 2;
                ofdDOCVeiculo.RestoreDirectory = true;
                ofdDOCVeiculo.ReadOnlyChecked = true;
                ofdDOCVeiculo.ShowReadOnly = true;

                DialogResult dr = this.ofdDOCVeiculo.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String arquivo in ofdDOCVeiculo.FileNames)
                    {
                        try
                        {
                            PictureBox pb = new PictureBox();
                            tbDOCVeiculo.Text = arquivo;
                            Image Imagem = Image.FromFile(arquivo);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Height = 100;
                            pb.Width = 100;
                            pb.Image = Imagem;
                            flpDOCVeiculo.Controls.Add(pb);
                        }
                        catch (SecurityException ex)
                        {
                            // O usuário  não possui permissão para ler arquivos
                            MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                        "Mensagem : " + ex.Message + "\n\n" +
                                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                            tbDOCVeiculo.Text = "";
                        }
                        catch (Exception ex)
                        {
                            // Não pode carregar a imagem (problemas de permissão)
                            MessageBox.Show("Não é possível exibir a imagem : "
                                                       + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                       " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                            tbDOCVeiculo.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Já existe uma imagem anexada!\n"
                    + "Por favor remova antes de anexar.");
            }
        }

        public void BoletimMostrar()
        {
            if (ClienteSelecionado.caminhoBoletim_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbBoletimOcorrencia.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpBoletim.Controls.Add(pb);
            }
        }

        public void ProntuarioMostrar()
        {
            if (ClienteSelecionado.caminhoProntuario_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbProntuario.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpProntuario.Controls.Add(pb);
            }
        }

        public void ComprovanteMostrar()
        {
            if (ClienteSelecionado.caminhoComprovanteResidencia_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbComprovanteResidencia.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpComprovanteResidencia.Controls.Add(pb);
            }
        }

        public void CartaoMostrar()
        {
            if (ClienteSelecionado.caminhoCartaoBanco_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbCartaoBanco.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpCartaoBanco.Controls.Add(pb);
            }
        }

        public void RGMostrar()
        {
            if (ClienteSelecionado.caminhoRG_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbDOCRG.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpRG.Controls.Add(pb);
            }
        }

        public void CPFMostrar()
        {
            if (ClienteSelecionado.caminhoCPF_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbDOCCPF.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpCPF.Controls.Add(pb);
            }
        }

        public void CNHMostrar()
        {
            if (ClienteSelecionado.caminhoCNH_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbDOCCNH.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpCNH.Controls.Add(pb);
            }
        }

        public void DOCVeiculoMostrar()
        {
            if (ClienteSelecionado.caminhoDOCVeiculo_anexos != "")
            {
                PictureBox pb = new PictureBox();
                // Le os arquivos selecionados 
                Image Imagem = Image.FromFile(tbDOCVeiculo.Text);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.Image = Imagem;
                flpDOCVeiculo.Controls.Add(pb);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btRemoverBO_Click(object sender, EventArgs e)
        {
            flpBoletim.Controls.Clear();
            tbBoletimOcorrencia.Text = "";
        }

        private void btRemoverProntuario_Click(object sender, EventArgs e)
        {
            flpProntuario.Controls.Clear();
            tbProntuario.Text = "";
        }

        private void btRemoverComprovante_Click(object sender, EventArgs e)
        {
            flpComprovanteResidencia.Controls.Clear();
            tbComprovanteResidencia.Text = "";
        }

        private void btRemoverCartao_Click(object sender, EventArgs e)
        {
            flpCartaoBanco.Controls.Clear();
            tbCartaoBanco.Text = "";
        }

        private void btRemoverRG_Click(object sender, EventArgs e)
        {
            flpRG.Controls.Clear();
            tbDOCRG.Text = "";
        }

        private void btRemoverCPF_Click(object sender, EventArgs e)
        {
            flpCPF.Controls.Clear();
            tbDOCCPF.Text = "";
        }

        private void btRemoverCNH_Click(object sender, EventArgs e)
        {
            flpCNH.Controls.Clear();
            tbDOCCNH.Text = "";
        }

        private void btRemoverDocVeiculo_Click(object sender, EventArgs e)
        {
            flpDOCVeiculo.Controls.Clear();
            tbDOCVeiculo.Text = "";
        }

        private void ofdBoletimOcorrencia_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
