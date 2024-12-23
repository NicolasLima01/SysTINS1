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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            Hide();
            FrmLogin frmLogin = new();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
                Show();
            }
            else
                Application.Exit();
            Show();

        }

        private void novoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); //cria uma instância (objeto) do FrmUsuarios
            frmUsuarios.MdiParent = this; //associa esta instancia ao container (MDI) FrmPrincipal
            frmUsuarios.Show(); //Exibe o form Usuarios na janela do sistema
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoWell frmProdutos = new();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente frmNovoCliente = new();
            frmNovoCliente.MdiParent = this;
            frmNovoCliente.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.txtUsuario.Text = Program.UsuarioLogado.Id + "-" + Program.UsuarioLogado.Nome;
            frmPedidoNovo.Show();
        }

        private void novoEnderereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = new();
            frmNovoEndereco.MdiParent = this;
            frmNovoEndereco.Show();
        }

        private void niveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNiveis frmNiveis = new();
            frmNiveis.MdiParent = this;
            frmNiveis.Show();
        }
    }
}
