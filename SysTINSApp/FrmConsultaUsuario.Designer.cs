namespace SysTINSApp
{
    partial class FrmConsultaUsuario
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
            dgvConsultaUsuario = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnSenha = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaUsuario
            // 
            dgvConsultaUsuario.AllowUserToAddRows = false;
            dgvConsultaUsuario.AllowUserToDeleteRows = false;
            dgvConsultaUsuario.AllowUserToResizeColumns = false;
            dgvConsultaUsuario.AllowUserToResizeRows = false;
            dgvConsultaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaUsuario.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnSenha, clnNivel, clnAtivo });
            dgvConsultaUsuario.Dock = DockStyle.Fill;
            dgvConsultaUsuario.Location = new Point(0, 0);
            dgvConsultaUsuario.Name = "dgvConsultaUsuario";
            dgvConsultaUsuario.ReadOnly = true;
            dgvConsultaUsuario.RowHeadersVisible = false;
            dgvConsultaUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaUsuario.Size = new Size(800, 450);
            dgvConsultaUsuario.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 75;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 175;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 175;
            // 
            // clnSenha
            // 
            clnSenha.Frozen = true;
            clnSenha.HeaderText = "Senha";
            clnSenha.Name = "clnSenha";
            clnSenha.ReadOnly = true;
            clnSenha.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 150;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 75;
            // 
            // FrmConsultaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultaUsuario);
            Name = "FrmConsultaUsuario";
            Text = "FrmConsultaCliente";
            Load += FrmConsultaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaUsuario;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnSenha;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}