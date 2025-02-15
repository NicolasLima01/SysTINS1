﻿namespace SysTINSApp
{
    partial class FrmNovoCliente
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblTelefone = new Label();
            LblEmail = new Label();
            lblData_nasc = new Label();
            btnInserir = new Button();
            btnCancelar = new Button();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnData_cad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            dtpData_Nasc = new DateTimePicker();
            chkAtivo = new CheckBox();
            btnAddEndereco = new Button();
            grbEndereco = new GroupBox();
            lblAvisoContent = new Label();
            dgvEnderecos = new DataGridView();
            clnEnderecoId = new DataGridViewTextBoxColumn();
            clnClienteId = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            btnArquivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(77, 82);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(158, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(197, 193);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(114, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(77, 193);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(114, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(77, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 8;
            lblId.Text = "ΙD";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(158, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(197, 175);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 10;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(77, 175);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(77, 120);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 12;
            LblEmail.Text = "Email";
            // 
            // lblData_nasc
            // 
            lblData_nasc.AutoSize = true;
            lblData_nasc.Location = new Point(320, 175);
            lblData_nasc.Name = "lblData_nasc";
            lblData_nasc.Size = new Size(114, 15);
            lblData_nasc.TabIndex = 13;
            lblData_nasc.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(77, 254);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(359, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnData_Nasc, clnData_cad, clnAtivo });
            dgvClientes.Location = new Point(7, 354);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(965, 220);
            dgvClientes.TabIndex = 16;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 60;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 200;
            // 
            // clnData_Nasc
            // 
            clnData_Nasc.Frozen = true;
            clnData_Nasc.HeaderText = "Data de Nascimento";
            clnData_Nasc.Name = "clnData_Nasc";
            clnData_Nasc.ReadOnly = true;
            clnData_Nasc.Width = 120;
            // 
            // clnData_cad
            // 
            clnData_cad.Frozen = true;
            clnData_cad.HeaderText = "Data de Cadastro";
            clnData_cad.Name = "clnData_cad";
            clnData_cad.ReadOnly = true;
            clnData_cad.Width = 125;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 60;
            // 
            // dtpData_Nasc
            // 
            dtpData_Nasc.Format = DateTimePickerFormat.Short;
            dtpData_Nasc.Location = new Point(317, 193);
            dtpData_Nasc.MaxDate = new DateTime(2006, 11, 13, 0, 0, 0, 0);
            dtpData_Nasc.Name = "dtpData_Nasc";
            dtpData_Nasc.Size = new Size(114, 23);
            dtpData_Nasc.TabIndex = 4;
            dtpData_Nasc.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(380, 142);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnAddEndereco
            // 
            btnAddEndereco.Location = new Point(17, 185);
            btnAddEndereco.Name = "btnAddEndereco";
            btnAddEndereco.Size = new Size(409, 32);
            btnAddEndereco.TabIndex = 0;
            btnAddEndereco.Text = "Adicionar";
            btnAddEndereco.UseVisualStyleBackColor = true;
            btnAddEndereco.Click += btnAddEndereco_Click;
            // 
            // grbEndereco
            // 
            grbEndereco.BackColor = SystemColors.HighlightText;
            grbEndereco.Controls.Add(lblAvisoContent);
            grbEndereco.Controls.Add(dgvEnderecos);
            grbEndereco.Controls.Add(btnAddEndereco);
            grbEndereco.Enabled = false;
            grbEndereco.Location = new Point(529, 61);
            grbEndereco.Name = "grbEndereco";
            grbEndereco.Size = new Size(443, 223);
            grbEndereco.TabIndex = 20;
            grbEndereco.TabStop = false;
            grbEndereco.Text = "Endereço";
            // 
            // lblAvisoContent
            // 
            lblAvisoContent.AutoSize = true;
            lblAvisoContent.ForeColor = Color.Red;
            lblAvisoContent.Location = new Point(17, 168);
            lblAvisoContent.Name = "lblAvisoContent";
            lblAvisoContent.Size = new Size(210, 15);
            lblAvisoContent.TabIndex = 21;
            lblAvisoContent.Text = "*Clique no endereço para mais opções";
            lblAvisoContent.Visible = false;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.AllowUserToResizeColumns = false;
            dgvEnderecos.AllowUserToResizeRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnEnderecoId, clnClienteId, clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(17, 22);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnderecos.Size = new Size(409, 143);
            dgvEnderecos.TabIndex = 20;
            dgvEnderecos.CellContentClick += dgvEnderecosPorCliente_CellContentClick;
            // 
            // clnEnderecoId
            // 
            clnEnderecoId.Frozen = true;
            clnEnderecoId.HeaderText = "ID";
            clnEnderecoId.Name = "clnEnderecoId";
            clnEnderecoId.ReadOnly = true;
            clnEnderecoId.Width = 60;
            // 
            // clnClienteId
            // 
            clnClienteId.Frozen = true;
            clnClienteId.HeaderText = "Cliente ID";
            clnClienteId.Name = "clnClienteId";
            clnClienteId.ReadOnly = true;
            clnClienteId.Width = 85;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 80;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 150;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 80;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            clnComplemento.Width = 80;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 120;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 120;
            // 
            // clnUf
            // 
            clnUf.Frozen = true;
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 60;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.Frozen = true;
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(172, 254);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(264, 254);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(75, 23);
            btnArquivar.TabIndex = 7;
            btnArquivar.Text = "Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            btnArquivar.Click += btnArquivar_Click;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 586);
            Controls.Add(btnArquivar);
            Controls.Add(btnAtualizar);
            Controls.Add(grbEndereco);
            Controls.Add(chkAtivo);
            Controls.Add(dtpData_Nasc);
            Controls.Add(dgvClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnInserir);
            Controls.Add(lblData_nasc);
            Controls.Add(LblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmNovoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbEndereco.ResumeLayout(false);
            grbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtData_Nasc;
        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblTelefone;
        private Label LblEmail;
        private Label lblData_nasc;
        private Button btnInserir;
        private Button btnCancelar;
        private DataGridView dgvClientes;
        private DateTimePicker dtpData_Nasc;
        private Label label1;
        private CheckBox chkAtivo;
        private Button btnAddEndereco;
        private GroupBox grbEndereco;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnData_cad;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridView dgvEnderecos;
        private Button btnAtualizar;
        private Button btnArquivar;
        private DataGridViewTextBoxColumn clnEnderecoId;
        private DataGridViewTextBoxColumn clnClienteId;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private Label lblAvisoContent;
    }
}