namespace SysTINSApp
{
    partial class FrmNovoEndereco
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
            btnAdicionar = new Button();
            lblClienteId = new Label();
            txtClienteId = new TextBox();
            txtCep = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            lblCep = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblComplemento = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            lblTipoEndereco = new Label();
            cmbUf = new ComboBox();
            cmbTipoEndereco = new ComboBox();
            btnAtualizar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(456, 94);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 40);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(120, 25);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(57, 15);
            lblClienteId.TabIndex = 1;
            lblClienteId.Text = "Cliente Id";
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(120, 43);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.ReadOnly = true;
            txtClienteId.Size = new Size(70, 23);
            txtClienteId.TabIndex = 2;
            txtClienteId.Text = "25";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(211, 43);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(331, 43);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(200, 23);
            txtLogradouro.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(29, 116);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(70, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(120, 116);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(240, 116);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(150, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(30, 187);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(174, 23);
            txtCidade.TabIndex = 9;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(211, 26);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 11;
            lblCep.Text = "CEP";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(331, 26);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 12;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(29, 98);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 13;
            lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(120, 98);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 14;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(240, 98);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 15;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(30, 169);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(225, 170);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 17;
            lblUf.Text = "UF";
            // 
            // lblTipoEndereco
            // 
            lblTipoEndereco.AutoSize = true;
            lblTipoEndereco.Location = new Point(290, 169);
            lblTipoEndereco.Name = "lblTipoEndereco";
            lblTipoEndereco.Size = new Size(30, 15);
            lblTipoEndereco.TabIndex = 18;
            lblTipoEndereco.Text = "Tipo";
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "SP", "MG", "RJ", "ES", "SC", "RS", "PR", "DF", "GO", "MS", "MT", "BA", "AL", "SE", "PR", "PB", "RN", "CE", "PI", "MA", "PA", "AM", "RR", "RO", "AP", "AC", "TO" });
            cmbUf.Location = new Point(225, 188);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(45, 23);
            cmbUf.TabIndex = 19;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES", "COM" });
            cmbTipoEndereco.Location = new Point(290, 187);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(100, 23);
            cmbTipoEndereco.TabIndex = 20;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(456, 140);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 41);
            btnAtualizar.TabIndex = 21;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(70, 23);
            txtId.TabIndex = 22;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(29, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 23;
            lblId.Text = "Id";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(456, 187);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 41);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmNovoEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 247);
            Controls.Add(btnExcluir);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnAtualizar);
            Controls.Add(cmbTipoEndereco);
            Controls.Add(cmbUf);
            Controls.Add(lblTipoEndereco);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(lblCep);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCep);
            Controls.Add(txtClienteId);
            Controls.Add(lblClienteId);
            Controls.Add(btnAdicionar);
            Name = "FrmNovoEndereco";
            Text = "FrmNovoEndereco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Label lblClienteId;
        private TextBox txtClienteId;
        private TextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private Label lblCep;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUf;
        private Label lblTipoEndereco;
        private ComboBox cmbUf;
        private ComboBox cmbTipoEndereco;
        private Button btnAtualizar;
        private TextBox txtId;
        private Label lblId;
        private Button btnExcluir;
    }
}