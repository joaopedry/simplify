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
    public partial class TelaPrincipal : Form
    {
        TelaProcessosEnviados enviado = new TelaProcessosEnviados();
        TelaProcessosNegados negado = new TelaProcessosNegados();
        TelaProcessosPendencia pendente = new TelaProcessosPendencia();

        private int childFormNumber = 0;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSeguradora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.seguradoralider.com.br");
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gmail.com");
        }

        private void btNovoCadastro_Click(object sender, EventArgs e)
        {
            ManterCliente mantercliente = new ManterCliente();
            mantercliente.MdiParent = this;
            panel5.Controls.Add(mantercliente);
            if (Application.OpenForms.OfType<ManterCliente>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<ManterCliente>().First().Focus();
            }
            else
            {

                mantercliente.Show();
            }
            
        }

        private void btProcessAndamento_Click(object sender, EventArgs e)
        {
            TelaProcessosAndamento telaandamento = new TelaProcessosAndamento();
            telaandamento.MdiParent = this;
            panel5.Controls.Add(telaandamento);

            if (Application.OpenForms.OfType<TelaProcessosAndamento>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosAndamento>().First().Focus();
            }
            else
            {

                telaandamento.Show();
            }
            
        }

        private void btProcessEnviados_Click(object sender, EventArgs e)
        {
            TelaProcessosEnviados telaenviados = new TelaProcessosEnviados();
            telaenviados.MdiParent = this;
            panel5.Controls.Add(telaenviados);
            if (Application.OpenForms.OfType<TelaProcessosEnviados>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosEnviados>().First().Focus();
            }
            else
            {

                telaenviados.Show();
            }
            

        }

        private void btProcessocompendencia_Click(object sender, EventArgs e)
        {
            TelaProcessosPendencia telapendencia = new TelaProcessosPendencia();
            telapendencia.MdiParent = this;
            panel5.Controls.Add(telapendencia);
            if (Application.OpenForms.OfType<TelaProcessosPendencia>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosPendencia>().First().Focus();
            }
            else
            {

                telapendencia.Show();
            }
           
        }

        private void btProcessosnegados_Click(object sender, EventArgs e)
        {
            TelaProcessosNegados telanegados = new TelaProcessosNegados();
            telanegados.MdiParent = this;
            panel5.Controls.Add(telanegados);
            if (Application.OpenForms.OfType<TelaProcessosNegados>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosNegados>().First().Focus();
            }
            else
            {

                telanegados.Show();
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgAniversariantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* TelaAjustes ajustes = new TelaAjustes();

             if (Application.OpenForms.OfType<TelaAjustes>().Count() > 0)
             {
                 MessageBox.Show("Esta janela já está em execução.", "!",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 Application.OpenForms.OfType<TelaAjustes>().First().Focus();
             }
             else
             {

                 ajustes.Show();
             }*/
            TelaSenhaUsuarios tela = new TelaSenhaUsuarios();

            if (Application.OpenForms.OfType<TelaSenhaUsuarios>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaSenhaUsuarios>().First().Focus();
            }
            else
            {

                tela.Show();
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TelaAjuda ajuda = new TelaAjuda();
            if (Application.OpenForms.OfType<TelaAjuda>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaAjuda>().First().Focus();
            }
            else
            {

                ajuda.Show();
            }
        }
            

        private void btRelatorios_Click(object sender, EventArgs e)
        {
            TelaGerarRelatorio telarelatorio = new TelaGerarRelatorio();
            if (Application.OpenForms.OfType<TelaGerarRelatorio>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaGerarRelatorio>().First().Focus();
            }
            else
            {

                telarelatorio.Show();
            }
            
        }

        private void btConsultarProcesso_Click(object sender, EventArgs e)
        {
            TelaListaProcessos tela = new TelaListaProcessos();
            //tela.MdiParent = this;
           // panel5.Controls.Add(tela);

            if (Application.OpenForms.OfType<TelaListaProcessos>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaListaProcessos>().First().Focus();
            }
            else
            {
                
                tela.Show();
            }
            
        }

        public void AbreTelaLogin_load(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Buscando contadores dos tipos de processos
        public void Buscacount(String count)
        {
            lbProcessosEnviados.Text = enviado.CarregaProcessoEnviado(count);
            lbProcessoNegado.Text = negado.CarregaProcessoNegado(count);
            lbProcessoPendencia.Text = pendente.CarregaProcessoPendente(count);
        }
    }
}

