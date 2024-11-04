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
            txtCod_Bar = new TextBox();
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
            lblData_Cad = new Label();
            rtxtDescricao = new RichTextBox();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnVl_Unid = new DataGridViewTextBoxColumn();
            clnUnid_Vd = new DataGridViewTextBoxColumn();
            clnData_Cad = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clnClasse_Desconto = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnCod_Bar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(185, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(185, 44);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(452, 252);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtCod_Bar
            // 
            txtCod_Bar.Location = new Point(257, 44);
            txtCod_Bar.Name = "txtCod_Bar";
            txtCod_Bar.Size = new Size(337, 23);
            txtCod_Bar.TabIndex = 3;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(185, 147);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(119, 23);
            txtEstoque.TabIndex = 4;
            // 
            // txtData_Cad
            // 
            txtData_Cad.Location = new Point(478, 94);
            txtData_Cad.Name = "txtData_Cad";
            txtData_Cad.Size = new Size(116, 23);
            txtData_Cad.TabIndex = 5;
            // 
            // txtUnid_Venda
            // 
            txtUnid_Venda.Location = new Point(329, 94);
            txtUnid_Venda.Name = "txtUnid_Venda";
            txtUnid_Venda.Size = new Size(116, 23);
            txtUnid_Venda.TabIndex = 6;
            // 
            // txtVl_Unid
            // 
            txtVl_Unid.Location = new Point(185, 94);
            txtVl_Unid.Name = "txtVl_Unid";
            txtVl_Unid.Size = new Size(119, 23);
            txtVl_Unid.TabIndex = 8;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(257, 252);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblCod_Bar
            // 
            lblCod_Bar.AutoSize = true;
            lblCod_Bar.Location = new Point(257, 26);
            lblCod_Bar.Name = "lblCod_Bar";
            lblCod_Bar.Size = new Size(97, 15);
            lblCod_Bar.TabIndex = 12;
            lblCod_Bar.Text = "Código de Barras";
            // 
            // lblVl_Unid
            // 
            lblVl_Unid.AutoSize = true;
            lblVl_Unid.Location = new Point(185, 76);
            lblVl_Unid.Name = "lblVl_Unid";
            lblVl_Unid.Size = new Size(96, 15);
            lblVl_Unid.TabIndex = 13;
            lblVl_Unid.Text = "Valor da Unidade";
            // 
            // lblUnid_Venda
            // 
            lblUnid_Venda.AutoSize = true;
            lblUnid_Venda.Location = new Point(329, 76);
            lblUnid_Venda.Name = "lblUnid_Venda";
            lblUnid_Venda.Size = new Size(86, 15);
            lblUnid_Venda.TabIndex = 14;
            lblUnid_Venda.Text = "Unidade Venda";
            lblUnid_Venda.Click += label1_Click_1;
            // 
            // lblEstoque_Min
            // 
            lblEstoque_Min.AutoSize = true;
            lblEstoque_Min.Location = new Point(185, 129);
            lblEstoque_Min.Name = "lblEstoque_Min";
            lblEstoque_Min.Size = new Size(52, 15);
            lblEstoque_Min.TabIndex = 15;
            lblEstoque_Min.Text = "Estoque ";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(185, 186);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label1_Click_2;
            // 
            // lblData_Cad
            // 
            lblData_Cad.AutoSize = true;
            lblData_Cad.Location = new Point(478, 76);
            lblData_Cad.Name = "lblData_Cad";
            lblData_Cad.Size = new Size(97, 15);
            lblData_Cad.TabIndex = 17;
            lblData_Cad.Text = "Data de Cadastro";
            // 
            // rtxtDescricao
            // 
            rtxtDescricao.Location = new Point(329, 147);
            rtxtDescricao.Name = "rtxtDescricao";
            rtxtDescricao.Size = new Size(265, 80);
            rtxtDescricao.TabIndex = 18;
            rtxtDescricao.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 129);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 19;
            label1.Text = "Descrição";
            label1.Click += label1_Click_3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(185, 204);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 20;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnVl_Unid, clnUnid_Vd, clnData_Cad, clnEstoque, clnClasse_Desconto, clnCategoria, clnCod_Bar });
            dgvProdutos.Location = new Point(40, 290);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(722, 130);
            dgvProdutos.TabIndex = 21;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.Width = 40;
            // 
            // clnVl_Unid
            // 
            clnVl_Unid.Frozen = true;
            clnVl_Unid.HeaderText = "Valor Unidade";
            clnVl_Unid.Name = "clnVl_Unid";
            clnVl_Unid.Width = 70;
            // 
            // clnUnid_Vd
            // 
            clnUnid_Vd.Frozen = true;
            clnUnid_Vd.HeaderText = "Unidade Venda";
            clnUnid_Vd.Name = "clnUnid_Vd";
            clnUnid_Vd.Width = 70;
            // 
            // clnData_Cad
            // 
            clnData_Cad.Frozen = true;
            clnData_Cad.HeaderText = "Data de Cadastro";
            clnData_Cad.Name = "clnData_Cad";
            clnData_Cad.Width = 60;
            // 
            // clnEstoque
            // 
            clnEstoque.Frozen = true;
            clnEstoque.HeaderText = "Estoque";
            clnEstoque.Name = "clnEstoque";
            clnEstoque.Width = 55;
            // 
            // clnClasse_Desconto
            // 
            clnClasse_Desconto.Frozen = true;
            clnClasse_Desconto.HeaderText = "Desconto";
            clnClasse_Desconto.Name = "clnClasse_Desconto";
            clnClasse_Desconto.Width = 65;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            // 
            // clnCod_Bar
            // 
            clnCod_Bar.Frozen = true;
            clnCod_Bar.HeaderText = "Código";
            clnCod_Bar.Name = "clnCod_Bar";
            clnCod_Bar.Width = 220;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(cmbCategoria);
            Controls.Add(label1);
            Controls.Add(rtxtDescricao);
            Controls.Add(lblData_Cad);
            Controls.Add(lblCategoria);
            Controls.Add(lblEstoque_Min);
            Controls.Add(lblUnid_Venda);
            Controls.Add(lblVl_Unid);
            Controls.Add(lblCod_Bar);
            Controls.Add(btnInserir);
            Controls.Add(txtVl_Unid);
            Controls.Add(txtUnid_Venda);
            Controls.Add(txtData_Cad);
            Controls.Add(txtEstoque);
            Controls.Add(txtCod_Bar);
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
        private TextBox txtCod_Bar;
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
        private Label lblData_Cad;
        private RichTextBox rtxtDescricao;
        private Label label1;
        private ComboBox cmbCategoria;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnVl_Unid;
        private DataGridViewTextBoxColumn clnUnid_Vd;
        private DataGridViewTextBoxColumn clnData_Cad;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clnClasse_Desconto;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnCod_Bar;
    }
}