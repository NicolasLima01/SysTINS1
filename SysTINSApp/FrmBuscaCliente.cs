using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysTINSClass;
using System.Windows.Forms;

namespace SysTINSApp
{
    public partial class FrmBuscaCliente : Form
    {
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            CarregaGridBusca();
        }
        private void CarregaGridBusca()
        {
            dgvBuscaClientes.Rows.Clear();
            List<Cliente> clientes = new();
            clientes = Cliente.ObterLista();
            int linha = 0;
            foreach (var cliente in clientes)
            {
                dgvBuscaClientes.Rows.Add();
                dgvBuscaClientes.Rows[linha].Cells[0].Value = cliente.Id;
                dgvBuscaClientes.Rows[linha].Cells[1].Value = cliente.Nome;
                dgvBuscaClientes.Rows[linha].Cells[2].Value = cliente.CPF;
                dgvBuscaClientes.Rows[linha].Cells[3].Value = cliente.Telefone;
                dgvBuscaClientes.Rows[linha].Cells[4].Value = cliente.Data_nasc;
                dgvBuscaClientes.Rows[linha].Cells[5].Value = cliente.Data_cad;
                dgvBuscaClientes.Rows[linha].Cells[6].Value = cliente.Ativo;
                linha++;
            }
        }
    }
}
