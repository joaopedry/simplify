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
    public partial class TelaProcessosAprovados : Form
    {
        public string countAprovados;
        public TelaProcessosAprovados()
        {
            InitializeComponent();
        }

        private void dgProcessosAprovados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string CarregaProcessoAprovados(string countAprovados)
        {
            String Status = "Aprovado";
            dgProcessosAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcessosAprovados.MultiSelect = false;
            dgProcessosAprovados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcessosAprovados.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.BuscaProcessos(Status);
            dgProcessosAprovados.DataSource = clientes;
            return countAprovados = dgProcessosAprovados.Rows.Count.ToString();
        }

        private void TelaProcessosAprovados_Load(object sender, EventArgs e)
        {
            CarregaProcessoAprovados(null);
        }

        private void TelaProcessosAprovados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
