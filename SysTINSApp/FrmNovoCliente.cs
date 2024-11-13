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
            CarregaGrid();
        }
        private void CarregaGrid()
        {
            var listaClientes = Cliente.ObterLista();
            dgvClientes.Rows.Clear();
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
                linha++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
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
            //MessageBox.Show(linhaAtual.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
