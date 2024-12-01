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
    public partial class FrmNovoCliente : Form
    {
        public FrmNovoCliente()
        {
            InitializeComponent();
        }

        private void FrmNovoCliente_Load(object sender, EventArgs e)
        {
            CarregaGridClientes();
            if (txtId.Text != "")
            {
                var cliente = Cliente.ConsultarPorId(Convert.ToInt32(txtId.Text));
                if (cliente.Id == Convert.ToInt32(txtId.Text))
                {
                    grbAddEndereco.Enabled = true;
                }
            }
        }
        private void CarregaGridClientes()
        {
            dgvClientes.Rows.Clear();
            var listaClientes = Cliente.ObterLista();
            int linha = 0;
            foreach (var cliente in listaClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[linha].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[linha].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[linha].Cells[2].Value = cliente.CPF;
                dgvClientes.Rows[linha].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[linha].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[linha].Cells[5].Value = cliente.Data_nasc;
                dgvClientes.Rows[linha].Cells[6].Value = cliente.Data_cad;
                dgvClientes.Rows[linha].Cells[7].Value = cliente.Ativo;
                linha++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            List<Endereco> enderecos = new();
            Cliente cliente = new(
                               txtNome.Text,
                               txtCpf.Text,
                               txtTelefone.Text,
                               txtEmail.Text,
                               dtpData_Nasc.Value,
                               chkAtivo.Checked,
                               enderecos
                               );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                CarregaGridClientes();
                MessageBox.Show($"Cliente {cliente.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvClientes.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvClientes.Rows[linhaAtual].Cells[0].Value);
            var cliente = Cliente.ConsultarPorId(idUser);
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.CPF;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            dtpData_Nasc.Text = cliente.Data_nasc.ToString();
            chkAtivo.Checked = (bool)cliente.Ativo;
            //MessageBox.Show(linhaAtual.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = new();
            frmNovoEndereco.Show();
        }
    }
}
