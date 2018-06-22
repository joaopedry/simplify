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
        //Variaveis
        public string countNegados;

        public TelaProcessosNegados()
        {
            InitializeComponent();
        }

        private void dgProcessosNegados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string CarregaProcessoNegado(string countNegado)
        {
            String Status = "Negado";
            dgProcessosNegados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcessosNegados.MultiSelect = false;
            dgProcessosNegados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcessosNegados.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.BuscaProcessos(Status);
            dgProcessosNegados.DataSource = clientes;
            return countNegados = dgProcessosNegados.Rows.Count.ToString();
        }

        private void TelaProcessosNegados_Load(object sender, EventArgs e)
        {
            CarregaProcessoNegado(null);
        }
    }
}
