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
        }
        //Carrega o grid de clientes
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
        //Carrega o grid de endereços por cliente
        private void CarregaGridEnderecos(List<Endereco> Enderecos)
        {
            dgvEnderecosPorCliente.Rows.Clear(); //Apaga as linhas do data grid
            int linha = 0;
            foreach (var endereco in Enderecos)
            {
                dgvEnderecosPorCliente.Rows.Add(); //Adiciona nova linha no grid
                dgvEnderecosPorCliente.Rows[linha].Cells[0].Value = endereco.Cliente.Id;
                dgvEnderecosPorCliente.Rows[linha].Cells[1].Value = endereco.CEP;
                dgvEnderecosPorCliente.Rows[linha].Cells[2].Value = endereco.Logradouro;
                dgvEnderecosPorCliente.Rows[linha].Cells[3].Value = endereco.Numero;
                dgvEnderecosPorCliente.Rows[linha].Cells[4].Value = endereco.Complemento;
                dgvEnderecosPorCliente.Rows[linha].Cells[5].Value = endereco.Bairro;
                dgvEnderecosPorCliente.Rows[linha].Cells[6].Value = endereco.Cidade;
                dgvEnderecosPorCliente.Rows[linha].Cells[7].Value = endereco.UF;
                dgvEnderecosPorCliente.Rows[linha].Cells[8].Value = endereco.Tipo_endereco;
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
            else
            {
                MessageBox.Show($"Falha ao inserir o cliente");
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

            //Ativa o group box de enderecos e carrega o data grid
            grbEndereco.Enabled = true;
            cliente.Enderecos = Endereco.ListarPorClienteId(cliente.Id);
            CarregaGridEnderecos(cliente.Enderecos);
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

        private void dgvEnderecosPorCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = new();
            frmNovoEndereco.Show();        
        }

        //Atualiza os dados do cliente
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            cliente.Id = int.Parse(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Data_nasc = dtpData_Nasc.Value;
            if (cliente.Atualizar())
            {
                CarregaGridClientes();
                MessageBox.Show("Cliente atualizado com sucesso");
            }
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            cliente.Id = int.Parse(txtId.Text);
            cliente.Arquivar(cliente.Id);
            if (cliente.Ativo == false)
            {
                CarregaGridClientes();
                MessageBox.Show("Cliente arquivado com sucesso");
            }
        }
    }
}
