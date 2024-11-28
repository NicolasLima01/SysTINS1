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
            itemPedido.Produto.Cod_barras = txtCodBar.Text;
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select id from produtos where cod_barras = {itemPedido.Produto.Cod_barras}";
            itemPedido.Produto = Produto.ConsultarPorID(Convert.ToInt32(cmd.ExecuteScalar()));
            cmd.Connection.Close();

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
            if (txtIdCliente.Text.Length >= 4)
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
                if(produto.Id > 0)
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
    }
}
