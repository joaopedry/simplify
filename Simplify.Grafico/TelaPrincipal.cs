using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Simplify.Negocio;

namespace Simplify.Grafico
{
    public partial class TelaPrincipal : Form
    {
        Gerenciador gerenciador = new Gerenciador();
        TelaProcessosEnviados enviado = new TelaProcessosEnviados();
        TelaProcessosNegados negado = new TelaProcessosNegados();
        TelaProcessosPendencia pendente = new TelaProcessosPendencia();
        TelaProcessosAprovados aprovado = new TelaProcessosAprovados();
        Series series = new Series();

        //Variaveis

        public int GraficoEnviado;
        public int GraficoPendente;
        public int GraficoNegado;
        public int GraficoAprovado;
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
            //mantercliente.MdiParent = this;
            //panel5.Controls.Add(mantercliente);
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
            TelaProcessosEnviados TelaEnviado= new TelaProcessosEnviados();
            TelaEnviado.MdiParent = this;
            panel5.Controls.Add(TelaEnviado);
            if (Application.OpenForms.OfType<TelaProcessosEnviados>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosEnviados>().First().Focus();
            }
            else
            {
                TelaEnviado.Show();
            }
        }

        private void btProcessocompendencia_Click(object sender, EventArgs e)
        {
            TelaProcessosPendencia TelaPendente = new TelaProcessosPendencia();
            TelaPendente.MdiParent = this;
            panel5.Controls.Add(TelaPendente);
            if (Application.OpenForms.OfType<TelaProcessosPendencia>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosPendencia>().First().Focus();
            }
            else
            {
                TelaPendente.Show();
            }
           
        }

        private void btProcessosnegados_Click(object sender, EventArgs e)
        {
            TelaProcessosNegados TelaNegado = new TelaProcessosNegados();
            TelaNegado.MdiParent = this;
            panel5.Controls.Add(TelaNegado);
            if (Application.OpenForms.OfType<TelaProcessosNegados>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosNegados>().First().Focus();
            }
            else
            {
                TelaNegado.Show();
            }            
        }

        private void btProcessosaprovados_Click(object sender, EventArgs e)
        {
            TelaProcessosAprovados TelaAprovado = new TelaProcessosAprovados();
            TelaAprovado.MdiParent = this;
            panel5.Controls.Add(TelaAprovado);
            if (Application.OpenForms.OfType<TelaProcessosNegados>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está em execução.", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.OpenForms.OfType<TelaProcessosNegados>().First().Focus();
            }
            else
            {
                TelaAprovado.Show();
            }
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
            Grafico();
            PercentualGrafico();
        }
    

        //Buscando contadores dos tipos de processos
        public void Buscacount(String count)
        {
            lbProcessosEnviados.Text = enviado.CarregaProcessoEnviado(count);
            lbProcessoNegado.Text = negado.CarregaProcessoNegado(count);
            lbProcessoPendencia.Text = pendente.CarregaProcessoPendente(count);
            lbProcessoAprovado.Text = aprovado.CarregaProcessoAprovados(count);
        }
        
        public void CountGrafico(String countGrafico)
        {
            GraficoEnviado = gerenciador.CountEnviado(countGrafico).Count();
            GraficoPendente = gerenciador.CountPendente(countGrafico).Count();
            GraficoNegado = gerenciador.CountNegado(countGrafico).Count();
            GraficoAprovado = gerenciador.CountAprovado(countGrafico).Count();
        }

        //carregar contadores
        private void TelaPrincipal_Activated(object sender, EventArgs e)
        {
            Buscacount(null);
            PercentualGrafico();
            CountGrafico(null);
        }

        private void lbProcessosEnviados_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Grafico()
        {
            string[] Status = {
            "Enviado",
            "Pendente",
            "Negado",
            "Aprovado",
            "Total"
            };
            this.chart1.Palette = ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("Processos");
            for (int i = 0; i < Status.Length; i++)
            {
                series = this.chart1.Series.Add(Status[i]);              
            }
        }

        public void PercentualGrafico()
        {
            
            int Enviados = int.Parse(lbProcessosEnviados.Text);
            int Pendentes = int.Parse(lbProcessoPendencia.Text);
            int Negados = int.Parse(lbProcessoNegado.Text);
            int Aprovados = int.Parse(lbProcessoAprovado.Text);
            int Total = (Enviados + Pendentes + Negados + Aprovados);

            series.Points.Clear();
            series.Points.Add(Enviados);
            series.Points.Add(Pendentes);
            series.Points.Add(Negados);
            series.Points.Add(Aprovados);
            series.Points.Add(Total);
        }
    }
}

