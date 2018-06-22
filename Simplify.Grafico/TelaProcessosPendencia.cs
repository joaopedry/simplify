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
    public partial class TelaProcessosPendencia : Form
    {
        //Variaveis
        public string countPendentes;

        public TelaProcessosPendencia()
        {
            InitializeComponent();
        }

        private void dgProcessosPendencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
        public string CarregaProcessoPendente(string countPendente)
        {
            String Status = "Pendente";
            dgProcessosPendencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcessosPendencia.MultiSelect = false;
            dgProcessosPendencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcessosPendencia.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.BuscaProcessos(Status);
            dgProcessosPendencia.DataSource = clientes;
            return countPendentes = dgProcessosPendencia.Rows.Count.ToString();
        }

        private void TelaProcessosPendencia_Load(object sender, EventArgs e)
        {
            CarregaProcessoPendente(null);
        }
    }
}
