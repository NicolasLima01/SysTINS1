namespace SysTINSApp
{
    partial class FrmProdutos
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
            lblId = new Label();
            txtId = new TextBox();
            btnAtualizar = new Button();
            txtCod_Barras = new TextBox();
            txtEstoque = new TextBox();
            txtData_Cad = new TextBox();
            txtUnid_Venda = new TextBox();
            txtVl_Unid = new TextBox();
            btnInserir = new Button();
            lblCod_Bar = new Label();
            lblVl_Unid = new Label();
            lblUnid_Venda = new Label();
            lblEstoque_Min = new Label();
            lblCategoria = new Label();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            dgvProdutos = new DataGridView();
            txtClasse_Desconto = new TextBox();
            lblClasse_Desconto = new Label();
            txtDescricao = new TextBox();
            clnId = new DataGridViewTextBoxColumn();
            clnCod_Bar = new DataGridViewTextBoxColumn();
            clnVl_Unid = new DataGridViewTextBoxColumn();
            clnUnid_Vd = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clnClasse_Desconto = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnData_Cad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(50, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(50, 46);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(324, 214);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtCod_Barras
            // 
            txtCod_Barras.Location = new Point(137, 46);
            txtCod_Barras.Name = "txtCod_Barras";
            txtCod_Barras.Size = new Size(160, 23);
            txtCod_Barras.TabIndex = 3;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(388, 101);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(61, 23);
            txtEstoque.TabIndex = 4;
            // 
            // txtData_Cad
            // 
            txtData_Cad.Location = new Point(399, 94);
            txtData_Cad.Name = "txtData_Cad";
            txtData_Cad.Size = new Size(107, 23);
            txtData_Cad.TabIndex = 5;
            // 
            // txtUnid_Venda
            // 
            txtUnid_Venda.Location = new Point(211, 101);
            txtUnid_Venda.Name = "txtUnid_Venda";
            txtUnid_Venda.Size = new Size(138, 23);
            txtUnid_Venda.TabIndex = 6;
            // 
            // txtVl_Unid
            // 
            txtVl_Unid.Location = new Point(50, 101);
            txtVl_Unid.Name = "txtVl_Unid";
            txtVl_Unid.Size = new Size(131, 23);
            txtVl_Unid.TabIndex = 8;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(211, 214);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblCod_Bar
            // 
            lblCod_Bar.AutoSize = true;
            lblCod_Bar.Location = new Point(137, 28);
            lblCod_Bar.Name = "lblCod_Bar";
            lblCod_Bar.Size = new Size(97, 15);
            lblCod_Bar.TabIndex = 12;
            lblCod_Bar.Text = "Código de Barras";
            // 
            // lblVl_Unid
            // 
            lblVl_Unid.AutoSize = true;
            lblVl_Unid.Location = new Point(50, 83);
            lblVl_Unid.Name = "lblVl_Unid";
            lblVl_Unid.Size = new Size(96, 15);
            lblVl_Unid.TabIndex = 13;
            lblVl_Unid.Text = "Valor da Unidade";
            // 
            // lblUnid_Venda
            // 
            lblUnid_Venda.AutoSize = true;
            lblUnid_Venda.Location = new Point(211, 83);
            lblUnid_Venda.Name = "lblUnid_Venda";
            lblUnid_Venda.Size = new Size(86, 15);
            lblUnid_Venda.TabIndex = 14;
            lblUnid_Venda.Text = "Unidade Venda";
            // 
            // lblEstoque_Min
            // 
            lblEstoque_Min.AutoSize = true;
            lblEstoque_Min.Location = new Point(388, 83);
            lblEstoque_Min.Name = "lblEstoque_Min";
            lblEstoque_Min.Size = new Size(94, 15);
            lblEstoque_Min.TabIndex = 15;
            lblEstoque_Min.Text = "Estoque mínimo";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(50, 138);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 19;
            label1.Text = "Descrição";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(50, 156);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(206, 23);
            cmbCategoria.TabIndex = 20;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCod_Bar, clnVl_Unid, clnUnid_Vd, clnEstoque, clnClasse_Desconto, clnCategoria, clnData_Cad });
            dgvProdutos.Location = new Point(12, 302);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(965, 130);
            dgvProdutos.TabIndex = 21;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // txtClasse_Desconto
            // 
            txtClasse_Desconto.Location = new Point(50, 214);
            txtClasse_Desconto.Name = "txtClasse_Desconto";
            txtClasse_Desconto.Size = new Size(121, 23);
            txtClasse_Desconto.TabIndex = 22;
            // 
            // lblClasse_Desconto
            // 
            lblClasse_Desconto.AutoSize = true;
            lblClasse_Desconto.Location = new Point(50, 196);
            lblClasse_Desconto.Name = "lblClasse_Desconto";
            lblClasse_Desconto.Size = new Size(93, 15);
            lblClasse_Desconto.TabIndex = 23;
            lblClasse_Desconto.Text = "Classe Desconto";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(324, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(222, 23);
            txtDescricao.TabIndex = 24;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.Width = 80;
            // 
            // clnCod_Bar
            // 
            clnCod_Bar.Frozen = true;
            clnCod_Bar.HeaderText = "Código";
            clnCod_Bar.Name = "clnCod_Bar";
            clnCod_Bar.Width = 220;
            // 
            // clnVl_Unid
            // 
            clnVl_Unid.Frozen = true;
            clnVl_Unid.HeaderText = "Valor Unidade";
            clnVl_Unid.Name = "clnVl_Unid";
            clnVl_Unid.Width = 120;
            // 
            // clnUnid_Vd
            // 
            clnUnid_Vd.Frozen = true;
            clnUnid_Vd.HeaderText = "Unidade de Venda";
            clnUnid_Vd.Name = "clnUnid_Vd";
            clnUnid_Vd.Width = 120;
            // 
            // clnEstoque
            // 
            clnEstoque.Frozen = true;
            clnEstoque.HeaderText = "Estoque";
            clnEstoque.Name = "clnEstoque";
            // 
            // clnClasse_Desconto
            // 
            clnClasse_Desconto.Frozen = true;
            clnClasse_Desconto.HeaderText = "Desconto";
            clnClasse_Desconto.Name = "clnClasse_Desconto";
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.Width = 125;
            // 
            // clnData_Cad
            // 
            clnData_Cad.Frozen = true;
            clnData_Cad.HeaderText = "Data de Cadastro";
            clnData_Cad.Name = "clnData_Cad";
            clnData_Cad.Width = 120;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 468);
            Controls.Add(txtDescricao);
            Controls.Add(lblClasse_Desconto);
            Controls.Add(txtClasse_Desconto);
            Controls.Add(dgvProdutos);
            Controls.Add(cmbCategoria);
            Controls.Add(label1);
            Controls.Add(lblCategoria);
            Controls.Add(lblEstoque_Min);
            Controls.Add(lblUnid_Venda);
            Controls.Add(lblVl_Unid);
            Controls.Add(lblCod_Bar);
            Controls.Add(btnInserir);
            Controls.Add(txtVl_Unid);
            Controls.Add(txtUnid_Venda);
            Controls.Add(txtEstoque);
            Controls.Add(txtCod_Barras);
            Controls.Add(btnAtualizar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Button btnAtualizar;
        private TextBox txtCod_Barras;
        private TextBox txtEstoque;
        private TextBox txtData_Cad;
        private TextBox txtUnid_Venda;
        private TextBox txtVl_Unid;
        private Button btnInserir;
        private Label lblCod_Bar;
        private Label lblVl_Unid;
        private Label lblUnid_Venda;
        private Label lblEstoque_Min;
        private Label lblCategoria;
        private Label label1;
        private ComboBox cmbCategoria;
        private DataGridView dgvProdutos;
        private TextBox txtClasse_Desconto;
        private Label lblClasse_Desconto;
        private TextBox txtDescricao;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCod_Bar;
        private DataGridViewTextBoxColumn clnVl_Unid;
        private DataGridViewTextBoxColumn clnUnid_Vd;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clnClasse_Desconto;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnData_Cad;
    }
}