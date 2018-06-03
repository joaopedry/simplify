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
        public TelaGerarRelatorio()
        {
            InitializeComponent();
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


    }
}
