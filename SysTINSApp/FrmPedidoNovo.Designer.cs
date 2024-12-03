namespace SysTINSApp
{
    partial class FrmPedidoNovo
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
            grbIndentificacao = new GroupBox();
            dgvConsultaCliente = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            txtNomeCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            dgvConsultaProduto = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clnValorProduto = new DataGridViewTextBoxColumn();
            label4 = new Label();
            rbReal = new RadioButton();
            rbPercentual = new RadioButton();
            txtTotalItens = new TextBox();
            label10 = new Label();
            lblDesconto = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtDescontoPedido = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grbIndentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).BeginInit();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIndentificacao
            // 
            grbIndentificacao.Controls.Add(dgvConsultaCliente);
            grbIndentificacao.Controls.Add(button1);
            grbIndentificacao.Controls.Add(btnInserePedido);
            grbIndentificacao.Controls.Add(txtIdCliente);
            grbIndentificacao.Controls.Add(txtNomeCliente);
            grbIndentificacao.Controls.Add(txtUsuario);
            grbIndentificacao.Controls.Add(label3);
            grbIndentificacao.Location = new Point(35, 84);
            grbIndentificacao.Name = "grbIndentificacao";
            grbIndentificacao.Size = new Size(634, 152);
            grbIndentificacao.TabIndex = 0;
            grbIndentificacao.TabStop = false;
            grbIndentificacao.Text = "Identificação";
            // 
            // dgvConsultaCliente
            // 
            dgvConsultaCliente.AllowUserToAddRows = false;
            dgvConsultaCliente.AllowUserToDeleteRows = false;
            dgvConsultaCliente.AllowUserToResizeColumns = false;
            dgvConsultaCliente.AllowUserToResizeRows = false;
            dgvConsultaCliente.CausesValidation = false;
            dgvConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaCliente.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome });
            dgvConsultaCliente.Dock = DockStyle.Right;
            dgvConsultaCliente.Location = new Point(381, 19);
            dgvConsultaCliente.Name = "dgvConsultaCliente";
            dgvConsultaCliente.RowHeadersVisible = false;
            dgvConsultaCliente.Size = new Size(250, 130);
            dgvConsultaCliente.TabIndex = 6;
            dgvConsultaCliente.Visible = false;
            dgvConsultaCliente.CellContentClick += dgvConsultaCliente_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.Width = 70;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.Width = 180;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(34, 87);
            button1.Name = "button1";
            button1.Size = new Size(87, 40);
            button1.TabIndex = 5;
            button1.Text = "Cliente";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(506, 44);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(90, 62);
            btnInserePedido.TabIndex = 3;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(127, 93);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(78, 27);
            txtIdCliente.TabIndex = 1;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            txtIdCliente.Leave += txtIdCliente_Leave;
            txtIdCliente.MouseHover += txtIdCliente_MouseHover;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(209, 93);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(255, 27);
            txtNomeCliente.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(92, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(372, 27);
            txtUsuario.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 44);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(dgvConsultaProduto);
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(rbReal);
            grbItens.Controls.Add(rbPercentual);
            grbItens.Controls.Add(txtTotalItens);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(lblDesconto);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(35, 242);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(634, 327);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // dgvConsultaProduto
            // 
            dgvConsultaProduto.AllowUserToAddRows = false;
            dgvConsultaProduto.AllowUserToDeleteRows = false;
            dgvConsultaProduto.AllowUserToResizeColumns = false;
            dgvConsultaProduto.AllowUserToResizeRows = false;
            dgvConsultaProduto.CausesValidation = false;
            dgvConsultaProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaProduto.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, clnValorProduto });
            dgvConsultaProduto.Location = new Point(22, 89);
            dgvConsultaProduto.Name = "dgvConsultaProduto";
            dgvConsultaProduto.ReadOnly = true;
            dgvConsultaProduto.RowHeadersVisible = false;
            dgvConsultaProduto.Size = new Size(393, 130);
            dgvConsultaProduto.TabIndex = 16;
            dgvConsultaProduto.Visible = false;
            dgvConsultaProduto.CellContentClick += dgvConsultaCliente_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Código de Barras";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // clnValorProduto
            // 
            clnValorProduto.Frozen = true;
            clnValorProduto.HeaderText = "Valor Unit";
            clnValorProduto.Name = "clnValorProduto";
            clnValorProduto.ReadOnly = true;
            clnValorProduto.Width = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(472, 87);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 15;
            label4.Text = "R$ ";
            // 
            // rbReal
            // 
            rbReal.AutoSize = true;
            rbReal.Checked = true;
            rbReal.Location = new Point(463, 40);
            rbReal.Name = "rbReal";
            rbReal.Size = new Size(47, 19);
            rbReal.TabIndex = 14;
            rbReal.TabStop = true;
            rbReal.Text = "Real";
            rbReal.UseVisualStyleBackColor = true;
            // 
            // rbPercentual
            // 
            rbPercentual.AutoSize = true;
            rbPercentual.Location = new Point(463, 22);
            rbPercentual.Name = "rbPercentual";
            rbPercentual.Size = new Size(81, 19);
            rbPercentual.TabIndex = 13;
            rbPercentual.Text = "Percentual";
            rbPercentual.UseVisualStyleBackColor = true;
            // 
            // txtTotalItens
            // 
            txtTotalItens.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalItens.ForeColor = Color.Navy;
            txtTotalItens.Location = new Point(506, 285);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.ReadOnly = true;
            txtTotalItens.Size = new Size(122, 33);
            txtTotalItens.TabIndex = 5;
            txtTotalItens.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(430, 289);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(463, 10);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 11;
            lblDesconto.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 42);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 42);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 42);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 42);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(463, 60);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(70, 23);
            txtDescontoItem.TabIndex = 3;
            txtDescontoItem.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(404, 60);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(53, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(339, 60);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(59, 23);
            txtValorUnit.TabIndex = 6;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(22, 60);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(110, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            txtCodBar.MouseLeave += txtCodBar_MouseLeave;
            txtCodBar.MouseHover += txtCodBar_MouseHover;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(138, 60);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(195, 23);
            txtDescricao.TabIndex = 5;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(539, 42);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 42);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.AllowUserToResizeColumns = false;
            dgvItensPedido.AllowUserToResizeRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(6, 105);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(620, 173);
            dgvItensPedido.TabIndex = 6;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(170, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 33);
            label1.TabIndex = 3;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(484, 30);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 6;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(592, 23);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(181, 43);
            txtIdPedido.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(702, 475);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(118, 29);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "0,00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(702, 314);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(118, 23);
            txtSubTotal.TabIndex = 6;
            txtSubTotal.Text = "0,00";
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(702, 387);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(118, 23);
            txtDescontoItens.TabIndex = 7;
            txtDescontoItens.Text = "0,00";
            txtDescontoItens.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(720, 524);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 42);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(702, 431);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(118, 23);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.Text = "0,00";
            txtDescontoPedido.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(702, 295);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 9;
            label11.Text = "SubTotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(702, 369);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 9;
            label12.Text = "Desconto Itens ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(702, 413);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 9;
            label13.Text = "Desconto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(702, 457);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 9;
            label14.Text = "Total ";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 581);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIndentificacao);
            Controls.Add(btnFechar);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIndentificacao.ResumeLayout(false);
            grbIndentificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).EndInit();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIndentificacao;
        private GroupBox grbItens;
        private Label label3;
        private Label label1;
        private Label label2;
        public TextBox txtUsuario;
        private TextBox txtNomeCliente;
        private Button btnInserePedido;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Label lblDesconto;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtTotalItens;
        private Label label10;
        private TextBox txtTotal;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtDescontoPedido;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private RadioButton rbReal;
        private RadioButton rbPercentual;
        private Button button1;
        private Label label4;
        private TextBox txtIdPedido;
        private DataGridView dgvConsultaCliente;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridView dgvConsultaProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn clnValorProduto;
        private TextBox txtIdCliente;
    }
}