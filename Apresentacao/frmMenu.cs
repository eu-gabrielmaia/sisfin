using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente clienteForm = new frmCliente();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedorForm = new frmFornecedor();
            fornecedorForm.MdiParent = this;
            fornecedorForm.Show();
        }

        private void listagemDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFornecedor relatorioForm = new RelatorioFornecedor();
            relatorioForm.MdiParent = this;
            relatorioForm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RA: 203228 - Nome: Gabriel Augusto Pereira Maia \nRA: 203236 - Nome: Leonardo Pedroso Mendes", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
