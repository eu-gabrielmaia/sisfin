using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmCliente : Form
    {
        private readonly ClienteService _clienteService;
        private DataTable tblCliente = new DataTable();

        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento
        public frmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();

            dgCliente.Columns.Add("Id", "ID");
            dgCliente.Columns.Add("Nome", "NOME");
            dgCliente.Columns.Add("tipoPesso", "TIPO PESSOA");
            dgCliente.Columns.Add("email", "EMAIL");

            dgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.AllowUserToOrderColumns = true;
            dgCliente.ReadOnly = true;

            tblCliente = _clienteService.getAll();
        }

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    btnInclui.Enabled = true;
                    btnAltera.Enabled = true;
                    btnExclui.Enabled = true;
                    btnSalva.Enabled = false;
                    btnCancela.Enabled = false;
                    grpDados.Enabled = false;
                    dgCliente.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    dgCliente.Enabled = false;
                    break;
                case 2:
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    dgCliente.Enabled = false;
                    break;
             }

        }

        public void LimpaForm()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtId.Clear();
            radioPessoaFisica.Checked = false;
            radioPessoaJuridica.Checked = false;

            txtNome.Focus();
        }


        private void frmCliente_Load(object sender, System.EventArgs e)
        {
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            // NOVO ====================
            dgCliente.ColumnCount = 4;
            dgCliente.AutoGenerateColumns = false;
            dgCliente.Columns[0].Width = 20;
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[0].DataPropertyName = "Id";
            //dgCliente.Columns[0].Visible = false;
            dgCliente.Columns[1].Width = 275;
            dgCliente.Columns[1].HeaderText = "NOME";
            dgCliente.Columns[1].DataPropertyName = "Nome";
            dgCliente.Columns[2].Width = 300;
            dgCliente.Columns[2].HeaderText = "EMAIL";
            dgCliente.Columns[2].DataPropertyName = "email";
            dgCliente.Columns[3].Width = 100;
            dgCliente.Columns[3].HeaderText = "TIPO";
            dgCliente.Columns[3].DataPropertyName = "tipoPessoa";

            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.MultiSelect = false;
            dgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridView();

        }

        private void carregaGridView()
        {
            dgCliente.DataSource = _clienteService.getAll();
            dgCliente.Refresh();
        }

        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView row = (DataGridView)sender;
            if (row.CurrentRow == null)
                return;

            //limpa os TextBoxes
            txtId.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            if (dgCliente.CurrentRow.Cells[3].Value.ToString() == ((int)TipoPessoa.PESSOA_FISICA).ToString())
                radioPessoaFisica.Checked = true;
            else
                radioPessoaJuridica.Checked = true;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            modo = 2;
            Habilita();
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
            LimpaForm();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            int id=0;
            string nome;
            string email;
            string resultado;
            string msg;
            int regAtual = 0;

            if (String.IsNullOrEmpty(txtId.Text))
                id = -1;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            email = txtEmail.Text;

            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;

            if (modo == 1)
            {
                resultado = _clienteService.Update(null, tp, nome, email);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE cadastrado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao cadastrar CLIENTE!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2)
            {
                resultado = _clienteService.Update(id, tp, nome, email);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE atualizado com sucesso!";
                    carregaGridView();
                 }
                else
                {
                    msg = "Falha ao atualizar CLIENTE!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            modo = 0;
            Habilita();

        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            string resultado;
            String msg;
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                int idCliente = Convert.ToInt32(txtId.Text);
                resultado = _clienteService.Remove(idCliente);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir CLIENTE!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            modo = 0;
            Habilita();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            frmPrompt f = new frmPrompt();
            string txtBusca = "";
            f.ShowDialog();
            txtBusca = f.Texto;
            DataTable tbClientes = _clienteService.filterByName(txtBusca);
            if(tbClientes!=null)
            {
                dgCliente.DataSource = tbClientes;
                dgCliente.Refresh();
            }
        }
    }
}
