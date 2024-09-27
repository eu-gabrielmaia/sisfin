using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Windows.Forms;
using Dados;
using FluentValidation.Results;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {
        private readonly FornecedorService _fornecedorService;
        private DataTable tblFornecedores = new DataTable();

        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento
        public frmFornecedor()
        {
            InitializeComponent();
            _fornecedorService = new FornecedorService();

            dgFornecedor.Columns.Add("Id", "ID");
            dgFornecedor.Columns.Add("Nome", "NOME");
            dgFornecedor.Columns.Add("tipoPessoa", "TIPO PESSOA");
            dgFornecedor.Columns.Add("email", "EMAIL");
            dgFornecedor.Columns.Add("cpf_cnpj", "CPF/CNPJ");
            dgFornecedor.Columns.Add("razao_social", "RAZÃO SOCIAL");
            dgFornecedor.Columns.Add("rua", "RUA");
            dgFornecedor.Columns.Add("bairro", "BAIRRO");
            dgFornecedor.Columns.Add("cidade", "CIDADE");
            dgFornecedor.Columns.Add("complemento", "COMPLEMENTO");
            dgFornecedor.Columns.Add("cep", "CEP");
            dgFornecedor.Columns.Add("telefone", "TELEFONE");
            dgFornecedor.Columns.Add("celular", "CELULAR");

            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.AllowUserToOrderColumns = true;
            dgFornecedor.ReadOnly = true;

            tblFornecedores = _fornecedorService.getAll();
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
                    dgFornecedor.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    dgFornecedor.Enabled = true;
                    break;
                case 2:
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    dgFornecedor.Enabled = false;
                    break;
            }

        }

        public void LimpaForm()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtCpf_cnpj.Clear();
            txtRazao_social.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();

            radioPessoaFisica.Checked = false;
            radioPessoaJuridica.Checked = false;

            txtNome.Focus();
        }

        private void frmFornecedor_Load(object sender, System.EventArgs e)
        {
            Habilita();
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            // NOVO ====================
            dgFornecedor.ColumnCount = 14;
            dgFornecedor.AutoGenerateColumns = false;
            dgFornecedor.Columns[0].Width = 20;
            dgFornecedor.Columns[0].HeaderText = "ID";
            dgFornecedor.Columns[0].DataPropertyName = "Id";
            //dgCliente.Columns[0].Visible = false;
            dgFornecedor.Columns[1].Width = 275;
            dgFornecedor.Columns[1].HeaderText = "NOME";
            dgFornecedor.Columns[1].DataPropertyName = "Nome";

            dgFornecedor.Columns[2].Width = 300;
            dgFornecedor.Columns[2].HeaderText = "EMAIL";
            dgFornecedor.Columns[2].DataPropertyName = "email";

            dgFornecedor.Columns[3].Width = 100;
            dgFornecedor.Columns[3].HeaderText = "TIPO";
            dgFornecedor.Columns[3].DataPropertyName = "tipoPessoa";

            dgFornecedor.Columns[4].Width = 100;
            dgFornecedor.Columns[4].HeaderText = "CPF/CNPJ";
            dgFornecedor.Columns[4].DataPropertyName = "cpf_cnpj";

            dgFornecedor.Columns[5].Width = 100;
            dgFornecedor.Columns[5].HeaderText = "RAZÃO SOCIAL";
            dgFornecedor.Columns[5].DataPropertyName = "razao_social";

            dgFornecedor.Columns[6].Width = 100;
            dgFornecedor.Columns[6].HeaderText = "RUA";
            dgFornecedor.Columns[6].DataPropertyName = "rua";

            dgFornecedor.Columns[7].Width = 80;
            dgFornecedor.Columns[7].HeaderText = "NUMERO";
            dgFornecedor.Columns[7].DataPropertyName = "numero";

            dgFornecedor.Columns[8].Width = 100;
            dgFornecedor.Columns[8].HeaderText = "BAIRRO";
            dgFornecedor.Columns[8].DataPropertyName = "bairro";

            dgFornecedor.Columns[9].Width = 100;
            dgFornecedor.Columns[9].HeaderText = "CIDADE";
            dgFornecedor.Columns[9].DataPropertyName = "cidade";

            dgFornecedor.Columns[10].Width = 100;
            dgFornecedor.Columns[10].HeaderText = "COMPLEMENTO";
            dgFornecedor.Columns[10].DataPropertyName = "complemento";

            dgFornecedor.Columns[11].Width = 100;
            dgFornecedor.Columns[11].HeaderText = "CEP";
            dgFornecedor.Columns[11].DataPropertyName = "cep";

            dgFornecedor.Columns[12].Width = 100;
            dgFornecedor.Columns[12].HeaderText = "TELEFONE";
            dgFornecedor.Columns[12].DataPropertyName = "telefone";

            dgFornecedor.Columns[13].Width = 100;
            dgFornecedor.Columns[13].HeaderText = "CELULAR";
            dgFornecedor.Columns[13].DataPropertyName = "celular";

            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.MultiSelect = false;
            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridView();
        }

        private void carregaGridView()
        {
            dgFornecedor.DataSource = _fornecedorService.getAll();
            dgFornecedor.Refresh();
        }

        private void dgFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView row = (DataGridView)sender;
            if (row.CurrentRow == null)
                return;

            //limpa os TextBoxes
            txtId.Text = dgFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgFornecedor.CurrentRow.Cells[2].Value.ToString();

            if (dgFornecedor.CurrentRow.Cells[3].Value.ToString() == ((int)TipoPessoa.PESSOA_FISICA).ToString())
                radioPessoaFisica.Checked = true;
            else
                radioPessoaJuridica.Checked = true;

            txtCpf_cnpj.Text = dgFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtRazao_social.Text = dgFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtRua.Text = dgFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtNumero.Text = dgFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtBairro.Text = dgFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtCidade.Text = dgFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCep.Text = dgFornecedor.CurrentRow.Cells[11].Value.ToString();
            txtTelefone.Text = dgFornecedor.CurrentRow.Cells[12].Value.ToString();
            txtCelular.Text = dgFornecedor.CurrentRow.Cells[13].Value.ToString();
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
            int id = 0;
            string nome;
            string email;
            string cpf_cnpj;
            string razao_social;
            string rua;
            string numero;
            string bairro;
            string cidade;
            string complemento;
            string cep;
            string telefone;
            string celular;
            string resultado;
            string msg;

            Fornecedor fornecedor = new Fornecedor();

            if (String.IsNullOrEmpty(txtId.Text))
                id = 0; // = null
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            email = txtEmail.Text;

            TipoPessoa tp = 0;
            if (radioPessoaFisica.Checked)
                tp = TipoPessoa.PESSOA_FISICA;
            else if (radioPessoaJuridica.Checked)
                tp = TipoPessoa.PESSOA_JURIDICA;

            cpf_cnpj = txtCpf_cnpj.Text;
            razao_social = txtRazao_social.Text;
            rua = txtRua.Text;
            numero = txtNumero.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            complemento = txtComplemento.Text;
            cep = txtCep.Text;
            telefone = txtTelefone.Text;
            celular = txtCelular.Text;




            fornecedor.Nome = nome;
            fornecedor.Email = email;
            fornecedor.tipoPessoa = tp;
            fornecedor.Cpf_cnpj = cpf_cnpj;
            fornecedor.Razao_social = razao_social;
            fornecedor.Rua = rua;
            fornecedor.Numero = numero;
            fornecedor.Bairro = bairro;
            fornecedor.Cidade = cidade;
            fornecedor.Complemento = complemento;
            fornecedor.Cep = cep;
            fornecedor.Telefone = telefone;
            fornecedor.Celular = celular;


            if (fornecedor != null)
            {
                FornecedorValidator validator = new FornecedorValidator();
                ValidationResult results = validator.Validate(fornecedor);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (modo == 1)
            {
                resultado = _fornecedorService.Update(null, tp, nome, email, cpf_cnpj, razao_social, rua, numero, bairro, cidade, complemento, cep, telefone, celular);//id, tp, nome, email, cpf_cnpj, razao_social, rua, numero, bairro,cidade, complemento, cep, telefone, celular);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR cadastrado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao cadastrar FORNECEDOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2)
            {

                resultado = _fornecedorService.Update(id, tp, nome, email, cpf_cnpj, razao_social, rua, numero, bairro, cidade, complemento, cep, telefone, celular); //id, tp, nome, email, cpf_cnpj, razao_social, rua, numero, bairro, cidade, complemento, cep, telefone, celular);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR atualizado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao atualizar FORNECEDOR!";
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
                int idFornecedor = int.Parse(txtId.Text);

                resultado = _fornecedorService.Remove(idFornecedor);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir FORNECEDOR!";
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
            DataTable tblFornecedores = _fornecedorService.filterByName(txtBusca);
            if (tblFornecedores != null)
            {
                dgFornecedor.DataSource = tblFornecedores;
                dgFornecedor.Refresh();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMensegemErro_Click(object sender, EventArgs e)
        {

        }

        private void cmdRelatorio(object sender, EventArgs e)
        {
            RelatorioFornecedor relatorioFornecedor = new RelatorioFornecedor();
            relatorioFornecedor.ShowDialog();
        }
    }
}
