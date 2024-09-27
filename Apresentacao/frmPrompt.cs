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
    public partial class frmPrompt : Form
    {
        private string _texto;
        public frmPrompt()
        {
            InitializeComponent();
            Texto = "";
        }

        public string Texto { get => _texto; set => _texto = value; }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTexto.Text))
            {
                Texto = txtTexto.Text;
            }
            this.Close();
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {

        }
    }
}
