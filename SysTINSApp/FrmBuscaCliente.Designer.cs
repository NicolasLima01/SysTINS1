namespace SysTINSApp
{
    partial class FrmBuscaCliente
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
            dgvBuscaClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefon = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCadastro = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBuscaClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscaClientes
            // 
            dgvBuscaClientes.AllowUserToAddRows = false;
            dgvBuscaClientes.AllowUserToDeleteRows = false;
            dgvBuscaClientes.AllowUserToResizeColumns = false;
            dgvBuscaClientes.AllowUserToResizeRows = false;
            dgvBuscaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscaClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefon, clnEmail, clnDataNasc, clnDataCadastro, clnAtivo });
            dgvBuscaClientes.Dock = DockStyle.Fill;
            dgvBuscaClientes.Location = new Point(0, 0);
            dgvBuscaClientes.Name = "dgvBuscaClientes";
            dgvBuscaClientes.ReadOnly = true;
            dgvBuscaClientes.RowHeadersVisible = false;
            dgvBuscaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscaClientes.Size = new Size(834, 411);
            dgvBuscaClientes.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 70;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 125;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnTelefon
            // 
            clnTelefon.Frozen = true;
            clnTelefon.HeaderText = "Telefone";
            clnTelefon.Name = "clnTelefon";
            clnTelefon.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "E-mail";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 140;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 125;
            // 
            // clnDataCadastro
            // 
            clnDataCadastro.Frozen = true;
            clnDataCadastro.HeaderText = "Data Cadastro";
            clnDataCadastro.Name = "clnDataCadastro";
            clnDataCadastro.ReadOnly = true;
            clnDataCadastro.Width = 125;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // FrmBuscaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(dgvBuscaClientes);
            Name = "FrmBuscaCliente";
            Text = "FrmBuscaCliente";
            Load += FrmBuscaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuscaClientes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefon;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCadastro;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}