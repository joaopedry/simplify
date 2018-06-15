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
    public partial class TelaProcessosEnviados : Form
    {
        public TelaProcessosEnviados()
        {
            InitializeComponent();
        }

        private void dgProcessosEnviados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaProcessoEnviado()
        {
            String Status = "Enviado";
            dgProcessosEnviados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcessosEnviados.MultiSelect = false;
            dgProcessosEnviados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcessosEnviados.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.BuscaProcessos(Status);
            dgProcessosEnviados.DataSource = clientes;
        }

        private void TelaProcessosEnviados_Load(object sender, EventArgs e)
        {
            CarregaProcessoEnviado();
        }
    }
}
