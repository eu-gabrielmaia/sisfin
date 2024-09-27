using System;

namespace Apresentacao
{
    partial class frmFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRazao_social = new System.Windows.Forms.TextBox();
            this.lblRazao_social = new System.Windows.Forms.Label();
            this.txtCpf_cnpj = new System.Windows.Forms.TextBox();
            this.lblCpf_cpnj = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.radioPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.radioPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.btnInclui = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtCelular);
            this.grpDados.Controls.Add(this.lblCelular);
            this.grpDados.Controls.Add(this.txtTelefone);
            this.grpDados.Controls.Add(this.lblTelefone);
            this.grpDados.Controls.Add(this.txtCep);
            this.grpDados.Controls.Add(this.lblCep);
            this.grpDados.Controls.Add(this.txtComplemento);
            this.grpDados.Controls.Add(this.lblComplemento);
            this.grpDados.Controls.Add(this.txtCidade);
            this.grpDados.Controls.Add(this.lblCidade);
            this.grpDados.Controls.Add(this.txtBairro);
            this.grpDados.Controls.Add(this.lblBairro);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.lblNumero);
            this.grpDados.Controls.Add(this.txtRua);
            this.grpDados.Controls.Add(this.lblRua);
            this.grpDados.Controls.Add(this.txtRazao_social);
            this.grpDados.Controls.Add(this.lblRazao_social);
            this.grpDados.Controls.Add(this.txtCpf_cnpj);
            this.grpDados.Controls.Add(this.lblCpf_cpnj);
            this.grpDados.Controls.Add(this.btnBusca);
            this.grpDados.Controls.Add(this.radioPessoaJuridica);
            this.grpDados.Controls.Add(this.radioPessoaFisica);
            this.grpDados.Controls.Add(this.txtEmail);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Controls.Add(this.txtId);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(1321, 262);
            this.grpDados.TabIndex = 13;
            this.grpDados.TabStop = false;
            this.grpDados.Enter += new System.EventHandler(this.grpDados_Enter);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(903, 224);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(262, 26);
            this.txtCelular.TabIndex = 32;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(899, 200);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 20);
            this.lblCelular.TabIndex = 31;
            this.lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(903, 162);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(262, 26);
            this.txtTelefone.TabIndex = 30;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(899, 138);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 29;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(903, 100);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(262, 26);
            this.txtCep.TabIndex = 28;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(899, 76);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 20);
            this.lblCep.TabIndex = 27;
            this.lblCep.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(903, 37);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(262, 26);
            this.txtComplemento.TabIndex = 26;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(899, 13);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 25;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(608, 224);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(262, 26);
            this.txtCidade.TabIndex = 24;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(604, 200);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 23;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(608, 162);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(262, 26);
            this.txtBairro.TabIndex = 22;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(604, 138);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 21;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(608, 99);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(262, 26);
            this.txtNumero.TabIndex = 20;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(604, 75);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Numero:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(608, 37);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(262, 26);
            this.txtRua.TabIndex = 18;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(604, 13);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(43, 20);
            this.lblRua.TabIndex = 17;
            this.lblRua.Text = "Rua:";
            // 
            // txtRazao_social
            // 
            this.txtRazao_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao_social.Location = new System.Drawing.Point(313, 162);
            this.txtRazao_social.Name = "txtRazao_social";
            this.txtRazao_social.Size = new System.Drawing.Size(262, 26);
            this.txtRazao_social.TabIndex = 16;
            // 
            // lblRazao_social
            // 
            this.lblRazao_social.AutoSize = true;
            this.lblRazao_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao_social.Location = new System.Drawing.Point(309, 138);
            this.lblRazao_social.Name = "lblRazao_social";
            this.lblRazao_social.Size = new System.Drawing.Size(107, 20);
            this.lblRazao_social.TabIndex = 15;
            this.lblRazao_social.Text = "Razão Social:";
            // 
            // txtCpf_cnpj
            // 
            this.txtCpf_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf_cnpj.Location = new System.Drawing.Point(313, 99);
            this.txtCpf_cnpj.Name = "txtCpf_cnpj";
            this.txtCpf_cnpj.Size = new System.Drawing.Size(262, 26);
            this.txtCpf_cnpj.TabIndex = 14;
            this.txtCpf_cnpj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCpf_cpnj
            // 
            this.lblCpf_cpnj.AutoSize = true;
            this.lblCpf_cpnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf_cpnj.Location = new System.Drawing.Point(309, 75);
            this.lblCpf_cpnj.Name = "lblCpf_cpnj";
            this.lblCpf_cpnj.Size = new System.Drawing.Size(88, 20);
            this.lblCpf_cpnj.TabIndex = 13;
            this.lblCpf_cpnj.Text = "CPF/CNPJ:";
            this.lblCpf_cpnj.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::Apresentacao.Properties.Resources.lupa;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(1265, 208);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(50, 48);
            this.btnBusca.TabIndex = 12;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // radioPessoaJuridica
            // 
            this.radioPessoaJuridica.AutoSize = true;
            this.radioPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPessoaJuridica.Location = new System.Drawing.Point(142, 56);
            this.radioPessoaJuridica.Name = "radioPessoaJuridica";
            this.radioPessoaJuridica.Size = new System.Drawing.Size(138, 24);
            this.radioPessoaJuridica.TabIndex = 5;
            this.radioPessoaJuridica.TabStop = true;
            this.radioPessoaJuridica.Text = "Pessoa Jurídica";
            this.radioPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // radioPessoaFisica
            // 
            this.radioPessoaFisica.AutoSize = true;
            this.radioPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPessoaFisica.Location = new System.Drawing.Point(142, 26);
            this.radioPessoaFisica.Name = "radioPessoaFisica";
            this.radioPessoaFisica.Size = new System.Drawing.Size(125, 24);
            this.radioPessoaFisica.TabIndex = 4;
            this.radioPessoaFisica.TabStop = true;
            this.radioPessoaFisica.Text = "Pessoa Física";
            this.radioPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(18, 37);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(72, 26);
            this.txtId.TabIndex = 9;
            this.txtId.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 26);
            this.txtNome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.Location = new System.Drawing.Point(12, 280);
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgFornecedor.RowHeadersWidth = 51;
            this.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedor.Size = new System.Drawing.Size(1321, 308);
            this.dgFornecedor.TabIndex = 12;
            this.dgFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFornecedor_CellContentClick);
            this.dgFornecedor.SelectionChanged += new System.EventHandler(this.dgFornecedor_SelectionChanged);
            // 
            // btnInclui
            // 
            this.btnInclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInclui.Location = new System.Drawing.Point(212, 604);
            this.btnInclui.Name = "btnInclui";
            this.btnInclui.Size = new System.Drawing.Size(130, 37);
            this.btnInclui.TabIndex = 7;
            this.btnInclui.Text = "Novo";
            this.btnInclui.UseVisualStyleBackColor = true;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Enabled = false;
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Location = new System.Drawing.Point(816, 599);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(157, 47);
            this.btnCancela.TabIndex = 8;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Enabled = false;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(620, 604);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(130, 37);
            this.btnSalva.TabIndex = 9;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclui.Location = new System.Drawing.Point(484, 604);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(130, 37);
            this.btnExclui.TabIndex = 10;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltera.Location = new System.Drawing.Point(348, 604);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(130, 37);
            this.btnAltera.TabIndex = 11;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(1140, 599);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(175, 47);
            this.btnRelatorio.TabIndex = 33;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.cmdRelatorio);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 668);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.dgFornecedor);
            this.Controls.Add(this.btnInclui);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnAltera);
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        private void grpDados_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.RadioButton radioPessoaJuridica;
        private System.Windows.Forms.RadioButton radioPessoaFisica;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.Button btnInclui;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.TextBox txtCpf_cnpj;
        private System.Windows.Forms.Label lblCpf_cpnj;
        private System.Windows.Forms.TextBox txtRazao_social;
        private System.Windows.Forms.Label lblRazao_social;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnRelatorio;
    }
}