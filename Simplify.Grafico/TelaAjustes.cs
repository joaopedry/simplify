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
    public partial class TelaAjustes : Form
    {
        public TelaAjustes()
        {
            InitializeComponent();
            CarregaUsuario();
        }

        private void CarregaUsuario()
        {
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuario.MultiSelect = false;
            dgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuario.AutoGenerateColumns = true;
            List<Usuario> usuarios = Program.Gerenciador.TodosOsUsuarios();
            dgUsuario.DataSource = usuarios;
        }

        private void btAdicionarUsuario_Click(object sender, EventArgs e)
        {
            ManterUsuario adicionauser = new ManterUsuario();
            adicionauser.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TelaAjuda ajuda = new TelaAjuda();
            ajuda.Show();
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
