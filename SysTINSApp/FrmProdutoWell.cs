using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmProdutoWell : Form
    {
        public FrmProdutoWell()
        {
            InitializeComponent();
        }
        private void FrmProdutoWell_Load(object sender, EventArgs e)
        {
            CarregaComboCategoria();
            CarregaGrid();
        }
        private void CarregaComboCategoria()
        {
            //Carregando combo box com as categorias
            var categorias = Categoria.ObterLista();
            categorias.Add(new(0, ">>>>>>> Nova Categoria <<<<<<<"));
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }

        private void CarregaGrid()
        {
            var listaProdutos = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int linha = 0;
            foreach (var produto in listaProdutos)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Cod_barras;
                dgvProdutos.Rows[linha].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[linha].Cells[3].Value = "R$ " + produto.Valor_unidade;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[linha].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[linha].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[linha].Cells[7].Value = (produto.Classe_desconto * 100) + "%";
                dgvProdutos.Rows[linha].Cells[8].Value = produto.Data_cadastro;
                linha++;
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCodBar.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ConsultarPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)npEstoqueMinimo.Value, //cast
                double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                CarregaGrid();
                MessageBox.Show($"Produto cadastrado com o ID {produto.Id}");
            }
            else
            {
                MessageBox.Show("Falha ao inserir o produto");
            }
        }

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.ValueMember != "" && Convert.ToUInt32(cmbCategoria.SelectedValue) == 0)
            {
                panel1.Visible = true;
                txtNewCat.Focus();
                gpProdutos.Enabled = false;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtNewCat.Text, txtNewCatSigla.Text);
            categoria.Inserir();
            txtNewCat.Clear();
            CarregaComboCategoria();
            cmbCategoria.SelectedValue = categoria.Id;
            panel1.Visible = false;
            gpProdutos.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            gpProdutos.Enabled = true;
            cmbCategoria.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
            Usuario usuario = new();
            usuario.Id = int.Parse(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = Nivel.ObterPorID(Convert.ToInt32(cmbNivel.SelectedValue));
            if (usuario.Atualizar())
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuario atualizado com sucesso");
            }
            */

            Produto produto = new()
            {
                Id = int.Parse(txtId.Text),
                Cod_barras = txtCodBar.Text,
                Descricao = txtDescricao.Text,
                Valor_unidade = double.Parse(txtValorUnit.Text),
                Unidade_venda = txtUnidadeVenda.Text,
                Categoria = Categoria.ConsultarPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                Estoque_minimo = Convert.ToDouble(npEstoqueMinimo.Value),
                Classe_desconto = double.Parse(txtDesconto.Text)
            };
            if (produto.Atualizar())
            {
                CarregaGrid();
                MessageBox.Show("Produto editado com sucesso");
            }
        }

        private void txtUnidadeVenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
