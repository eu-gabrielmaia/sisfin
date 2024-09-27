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
    public partial class RelatorioFornecedor : Form
    {
        public RelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void RelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Database1DataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedorTableAdapter.Fill(this.Database1DataSet.Fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
