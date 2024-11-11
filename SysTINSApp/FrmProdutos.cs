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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //carregando o combo box de categoria
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            /*Produto produto = new(txtCod_Barras.Text,
                                  txtDescricao.Text,
                                  Convert.ToInt32(txtVl_Unid.Text),
                                  txtUnid_Venda.Text,
                                  Categoria.ConsultarPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                                  Convert.ToDouble(txtEstoque.Text),
                                  Convert.ToDouble(txtClasse_Desconto.Text)
                                  );

            produto.Inserir();
            if (produto.Id > 0)
            {
                CarregaGridProdutos();
                MessageBox.Show($"Produto {produto.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }*/
        }
        private void CarregaGridProdutos()
        {
            //carregando o datagrid de Produtos
            dgvProdutos.Rows.Clear();
            var listaDeProdutos = Produto.ObterLista();
            int linha = 0;
            foreach (var produto in listaDeProdutos)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[linha].Cells[3].Value = produto.Valor_unidade;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[linha].Cells[8].Value = produto.Data_cadastro;
                dgvProdutos.Rows[linha].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[linha].Cells[7].Value = produto.Classe_desconto;
                dgvProdutos.Rows[linha].Cells[5].Value = produto.Categoria;
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Cod_barras;
                linha++;
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvProdutos.CurrentRow.Index;
            int idProduto = Convert.ToInt32(dgvProdutos.Rows[linhaAtual].Cells[0].Value);
            var produto = Produto.ConsultarPorID(idProduto);
            txtId.Text = produto.Id.ToString();
            txtCod_Barras.Text = produto.Cod_barras;
            txtVl_Unid.Text = produto.Valor_unidade.ToString();
            txtUnid_Venda.Text = produto.Unidade_venda;
            txtData_Cad.Text = produto.Data_cadastro.ToString();
            txtClasse_Desconto.Text = produto.Classe_desconto.ToString();
            txtEstoque.Text = produto.Estoque_minimo.ToString();
            cmbCategoria.SelectedValue = produto.Categoria.Id;
            btnAtualizar.Enabled = true;
        }
    }
}

