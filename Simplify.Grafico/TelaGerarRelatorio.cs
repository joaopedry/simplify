using Simplify.Negocio;
using Simplify.Negocio.Models;
using Simplify.Negocio.Persistencia;
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
    public partial class TelaGerarRelatorio : Form
    {
        Gerenciador gerenciador = new Gerenciador();
        private Banco banco = new Banco();
        public DateTime DataInicio;
        public DateTime DataFinal;
        public int EnviadoCountRelatorio;
        public int PendenteCountRelatorio;
        public int NegadoCountRelatorio;
        public int AprovadoCountRelatorio;

        public TelaGerarRelatorio()
        {
            InitializeComponent();
        }

        private void MontarRelatorio()
        {
            lbProcessosEnviados.Text    = EnviadoCountRelatorio.ToString();
            lbProcessosPendentes.Text   = PendenteCountRelatorio.ToString();
            lbProcessosNegados.Text     = NegadoCountRelatorio.ToString();
            lbProcessosAprovados.Text   = AprovadoCountRelatorio.ToString();
            lbProcessosConcluidos.Text  = (AprovadoCountRelatorio + NegadoCountRelatorio).ToString();
            lbProcessosEmAberto.Text    = (PendenteCountRelatorio + EnviadoCountRelatorio).ToString();
            lbDatainicio.Text = dtpDataInicioRelatorio.Value.Date.ToString("dd/MM/yyyy");
            lbDataFinal.Text = dtpDataFimRelatorio.Value.Date.ToString("dd/MM/yyyy");
            lbDataGeracao.Text = DateTime.Now.ToString();
        }

        public void DataInformadaInicio(int count)
        {
            //RelatorioEnviado();
            dtpDataInicioRelatorio.Value.Date.ToString("dd/MM/yyyy");
            DataInicio = DateTime.Parse(dtpDataInicioRelatorio.Text);
            dtpDataFimRelatorio.Value.Date.ToString("dd/MM/yyyy");
            DataFinal = DateTime.Parse(dtpDataFimRelatorio.Text);
            EnviadoCountRelatorio = RelatorioEnviado(count).Count;
            PendenteCountRelatorio = RelatorioPendente(count).Count;
            NegadoCountRelatorio = RelatorioNegado(count).Count;
            AprovadoCountRelatorio = RelatorioAprovado(count).Count;
            MontarRelatorio();
        }

        public List<Cliente> RelatorioEnviado(int countRelatorioEnviado)
        {
            return this.banco.Clientes.Where(c => c.Status == "Enviado")
                                      .Where(d => d.DTCriacao >= DataInicio)
                                      .Where(e => e.DTCriacao <= DataFinal)
                                      .ToList();
        }

        public List<Cliente> RelatorioPendente(int countRelatorioPendente)
        {
            return this.banco.Clientes.Where(c => c.Status == "Pendente")
                                      .Where(d => d.DTCriacao >= DataInicio)
                                      .Where(e => e.DTCriacao <= DataFinal)
                                      .ToList();
        }

        public List<Cliente> RelatorioNegado(int countRelatorioNegado)
        {
            return this.banco.Clientes.Where(c => c.Status == "Negado")
                                      .Where(d => d.DTCriacao >= DataInicio)
                                      .Where(e => e.DTCriacao <= DataFinal)
                                      .ToList();
        }

        public List<Cliente> RelatorioAprovado(int countRelatorioAprovado)
        {
            return this.banco.Clientes.Where(c => c.Status == "Aprovado")
                                      .Where(d => d.DTCriacao >= DataInicio)
                                      .Where(e => e.DTCriacao <= DataFinal)
                                      .ToList();
        }

        private void TelaGerarRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataInformadaInicio(EnviadoCountRelatorio);
        }

        private void TelaGerarRelatorio_Activated(object sender, EventArgs e)
        {
            //DataInformadaInicio(iEnviadoCountRelatorio);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbDatainicio_Click(object sender, EventArgs e)
        {

        }
    }
}
