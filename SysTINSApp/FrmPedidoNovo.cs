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
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Usuario.ObterPorID(Program.UsuarioLogado.Id),
                Cliente.ConsultarPorId(int.Parse(txtIdCliente.Text))
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbIndentificacao.Enabled = false;
            grbItens.Enabled = true;
            btnInserePedido.Enabled = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            /*
            //Resolução antes do Well
            Produto produto = new();
            produto.Cod_barras = txtCodBar.Text;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select id from produtos where cod_barras = {produto.Cod_barras}";
            produto = Produto.ConsultarPorID(Convert.ToInt32(cmd.ExecuteScalar()));
            */
            ItemPedido itemPedido = new(Convert.ToInt32(txtIdPedido.Text),
                                        Produto.ConsultarPorCodBar(txtCodBar.Text),
                                        Convert.ToDouble(txtQuantidade.Text),
                                        Convert.ToDouble(txtDescontoItem.Text)
                                        );
            itemPedido.Inserir();

            if (itemPedido.PedidoId > 0)
            {
                CarregaGridItemPedido();
                MessageBox.Show("Item adicionado com sucesso!");
                txtCodBar.Text = "";
                txtDescricao.Text = "";
                txtValorUnit.Text = "";
                txtQuantidade.Text = "";
                txtDescontoItem.Text = "";
                txtTotalItens.Text = "R$" + Convert.ToString(itemPedido.Produto.Valor_unidade * itemPedido.Quantidade);
            }
            else
            {
                MessageBox.Show($"Falha ao adicionar item");
            }
        }
        private void CarregaGridItemPedido()
        {
            //Declaração de produto do ItemPedido
            ItemPedido itemPedido = new();
            itemPedido.PedidoId = Convert.ToInt32(txtIdPedido.Text);
            itemPedido.Produto = Produto.ConsultarPorCodBar(txtCodBar.Text);

            /*
            //resolucao antes do Well
            itemPedido.Produto.Cod_barras = txtCodBar.Text;
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select id from produtos where cod_barras = {itemPedido.Produto.Cod_barras}";
            itemPedido.Produto = Produto.ConsultarPorID(Convert.ToInt32(cmd.ExecuteScalar()));
            cmd.Connection.Close();
            */

            //carregando o datagrid de pedidos
            dgvItensPedido.Rows.Clear();
            var listaDeItens = ItemPedido.ObterItemPorPedidoId(itemPedido.PedidoId);
            int linha = 0;
            int seq = 0;

            foreach (var item in listaDeItens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = ++seq;
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.Cod_barras;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.Produto.Valor_unidade;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                linha++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chamar um grid com lista de clientes
            //escolher o cliente na lista
            //caso não exista, clicar em novo
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            //O código vai acontecer quando o controle deixar de ser ativo.
            if (txtIdCliente.Text.Length >= 2)
            {
                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtIdCliente.Text));
                txtNomeCliente.Text = $"{cliente.Nome} - {cliente.CPF}";
            }
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 9)
            {
                Produto produto = Produto.ConsultarPorCodBar(txtCodBar.Text);
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.Valor_unidade.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado");
                }
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_MouseHover(object sender, EventArgs e)
        {
            dgvConsultaCliente.Visible = true;
            dgvConsultaCliente.Rows.Clear();
            List<Cliente> listaClientes = new();
            listaClientes = Cliente.ObterLista();
            int linha = 0;
            foreach (var cliente in listaClientes)
            {
                dgvConsultaCliente.Rows.Add();
                dgvConsultaCliente.Rows[linha].Cells[0].Value = cliente.Id;
                dgvConsultaCliente.Rows[linha].Cells[1].Value = cliente.Nome;
                linha++;
            }
        }

        private void dgvConsultaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvConsultaCliente.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvConsultaCliente.Rows[linhaAtual].Cells[0].Value);
            var cliente = Cliente.ConsultarPorId(idUser);
            txtIdCliente.Text = cliente.Id.ToString();
            txtNomeCliente.Text = cliente.Nome;
            if (cliente.Id > 0)
            {
                dgvConsultaCliente.Visible = false;
            }
        }

        private void txtCodBar_MouseHover(object sender, EventArgs e)
        {
            dgvConsultaProduto.Visible = true;
            dgvConsultaProduto.Rows.Clear();
            List<Produto> listaProdutos = new();
            listaProdutos = Produto.ObterLista();
            int linha = 0;
            foreach (var produto in listaProdutos)
            {
                dgvConsultaProduto.Rows.Add();
                dgvConsultaProduto.Rows[linha].Cells[0].Value = produto.Cod_barras;
                dgvConsultaProduto.Rows[linha].Cells[1].Value = produto.Descricao;
                dgvConsultaProduto.Rows[linha].Cells[2].Value = produto.Valor_unidade;
                linha++;
            }
        }

        private void dgvConsultaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvConsultaProduto.CurrentRow.Index;
            string CodProd = Convert.ToString(dgvConsultaProduto.Rows[linhaAtual].Cells[0].Value);
            var produto = Produto.ConsultarPorCodBar(CodProd);
            txtCodBar.Text = produto.Cod_barras.ToString();
            txtDescricao.Text = produto.Descricao;
            txtValorUnit.Text = produto.Valor_unidade.ToString();
            if (produto.Id > 0)
            {
                dgvConsultaProduto.Visible = false;
            }
        }

        private void txtCodBar_MouseLeave(object sender, EventArgs e)
        {
            //dgvConsultaProduto.Visible = false;
        }
    }
}
