namespace SysTINSApp
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(223, 72);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(304, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(343, 183);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(114, 23);
            txtCpf.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(223, 183);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(114, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(223, 54);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 8;
            lblId.Text = "ΙD";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(304, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(343, 165);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 10;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(223, 165);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(223, 110);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 12;
            LblEmail.Text = "Email";
            // 
            // lblData_nasc
            // 
            lblData_nasc.AutoSize = true;
            lblData_nasc.Location = new Point(466, 165);
            lblData_nasc.Name = "lblData_nasc";
            lblData_nasc.Size = new Size(114, 15);
            lblData_nasc.TabIndex = 13;
            lblData_nasc.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(304, 244);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 244);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnData_Nasc, clnData_cad, clnAtivo });
            dgvClientes.Location = new Point(12, 288);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(776, 150);
            dgvClientes.TabIndex = 16;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.Width = 60;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.Width = 135;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.Width = 140;
            // 
            // clnData_Nasc
            // 
            clnData_Nasc.Frozen = true;
            clnData_Nasc.HeaderText = "Data de Nascimento";
            clnData_Nasc.Name = "clnData_Nasc";
            clnData_Nasc.Width = 120;
            // 
            // clnData_cad
            // 
            clnData_cad.Frozen = true;
            clnData_cad.HeaderText = "Data de Cadastro";
            clnData_cad.Name = "clnData_cad";
            clnData_cad.Width = 120;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.Width = 60;
            // 
            // dtpData_Nasc
            // 
            dtpData_Nasc.Format = DateTimePickerFormat.Short;
            dtpData_Nasc.Location = new Point(466, 183);
            dtpData_Nasc.MaxDate = new DateTime(2006, 11, 13, 0, 0, 0, 0);
            dtpData_Nasc.Name = "dtpData_Nasc";
            dtpData_Nasc.Size = new Size(114, 23);
            dtpData_Nasc.TabIndex = 17;
            dtpData_Nasc.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(526, 128);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 18;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            chkAtivo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnAddEndereco
            // 
            btnAddEndereco.Location = new Point(638, 113);
            btnAddEndereco.Name = "btnAddEndereco";
            btnAddEndereco.Size = new Size(75, 51);
            btnAddEndereco.TabIndex = 19;
            btnAddEndereco.Text = "Adicionar Endereco";
            btnAddEndereco.UseVisualStyleBackColor = true;
            btnAddEndereco.Click += btnAddEndereco_Click;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddEndereco);
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
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnData_cad;
        private DataGridViewTextBoxColumn clnAtivo;
        private DateTimePicker dtpData_Nasc;
        private Label label1;
        private CheckBox chkAtivo;
        private Button btnAddEndereco;
    }
}