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
    public partial class TelaProcessosNegados : Form
    {
        public TelaProcessosNegados()
        {
            InitializeComponent();
        }

        private void dgProcessosNegados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaProcessoNegado()
        {
            String Status = "Negado";
            dgProcessosNegados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcessosNegados.MultiSelect = false;
            dgProcessosNegados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcessosNegados.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.BuscaProcessos(Status);
            dgProcessosNegados.DataSource = clientes;
        }

        private void TelaProcessosNegados_Load(object sender, EventArgs e)
        {
            CarregaProcessoNegado();
        }
    }
}
