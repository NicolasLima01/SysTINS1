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
            Produto produto = new(txtCodBar.Text, txtDescricao.Text);
            produto.Cod_barras = txtCodBar.Text;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select id from produtos where cod_barras = {produto.Cod_barras}";    
            produto = Produto.ConsultarPorID(Convert.ToInt32(cmd.ExecuteScalar()));
            cmd.Connection.Close();
            ItemPedido itemPedido = new(Convert.ToInt32(txtIdPedido.Text),
                                        Produto.ConsultarPorID(produto.Id),
                                        Convert.ToDouble(txtValorUnit.Text),
                                        Convert.ToDouble(txtQuantidade.Text),
                                        Convert.ToDouble(txtDescontoItem.Text)
                                        );                             
            itemPedido.Inserir();
        }
    }
}
