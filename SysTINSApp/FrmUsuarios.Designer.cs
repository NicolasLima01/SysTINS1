namespace SysTINSApp
{
    partial class FrmUsuarios
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
            btnInserir = new Button();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            dgvUsuarios = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkAtivo = new CheckBox();
            cmbNivel = new ComboBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(201, 213);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(329, 213);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(458, 213);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(121, 261);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 3;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 58);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 58);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 111);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 165);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 111);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 8;
            label5.Text = "Nível";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(479, 183);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 9;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(435, 129);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(139, 23);
            cmbNivel.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(201, 76);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 23);
            txtId.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(282, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(201, 183);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 14;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(304, 183);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 15;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 165);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 16;
            label6.Text = "Confirmar Senha";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 467);
            Controls.Add(label6);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(cmbNivel);
            Controls.Add(chkAtivo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAtualizar;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chkAtivo;
        private ComboBox cmbNivel;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Label label6;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}