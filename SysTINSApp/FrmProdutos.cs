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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //carregando o combo box de niveis
            cmbCategoria.DataSource = Nivel.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new(Convert.ToInt32(txtCod_Bar.Text), rtxtDescricao.Text, 
                Convert.ToInt32(txtVl_Unid.Text),Convert.ToInt32(txtUnid_Venda.Text),
                Convert.ToDateTime(txtData_Cad.Text), Convert.ToDouble(txtEstoque.Text),
                Convert.ToDouble(txtClasse_Desconto.Text),
                Categoria.ConsultarPorId(Convert.ToInt32(cmbCategoria.SelectedValue))
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                CarregaGridProdutos();
                MessageBox.Show($"Produto {produto.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
        private void CarregaGridProdutos()
        {
            //carregando o datagrid de Produtos
            dgvProdutos.Rows.Clear();
            var listaDeUsuarios = Produto.ObterLista();
            int linha = 0;
            foreach (var usuario in listaDeUsuarios)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Nome;
                dgvProdutos.Rows[linha].Cells[2].Value = produto.Email;
                dgvProdutos.Rows[linha].Cells[3].Value = produto.Nivel.Nome;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Ativo;
                linha++;
            }
        }
    }
}

