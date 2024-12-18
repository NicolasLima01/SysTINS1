using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;
using static System.Windows.Forms.LinkLabel;

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
            dgvEnderecos.Rows.Clear(); //Apaga as linhas do data grid
            int linha = 0;
            foreach (var endereco in Enderecos)
            {
                dgvEnderecos.Rows.Add(); //Adiciona nova linha no grid
                dgvEnderecos.Rows[linha].Cells[0].Value = endereco.Id;
                dgvEnderecos.Rows[linha].Cells[1].Value = endereco.Cliente.Id;
                dgvEnderecos.Rows[linha].Cells[2].Value = endereco.CEP;
                dgvEnderecos.Rows[linha].Cells[3].Value = endereco.Logradouro;
                dgvEnderecos.Rows[linha].Cells[4].Value = endereco.Numero;
                dgvEnderecos.Rows[linha].Cells[5].Value = endereco.Complemento;
                dgvEnderecos.Rows[linha].Cells[6].Value = endereco.Bairro;
                dgvEnderecos.Rows[linha].Cells[7].Value = endereco.Cidade;
                dgvEnderecos.Rows[linha].Cells[8].Value = endereco.UF;
                dgvEnderecos.Rows[linha].Cells[9].Value = endereco.Tipo_endereco;
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

            btnInserir.Enabled = false; //Desativa o botao de inserir

            //Ativa o group box de enderecos e carrega o data grid
            grbEndereco.Enabled = true;
            cliente.Enderecos = Endereco.ListarPorClienteId(cliente.Id);
            CarregaGridEnderecos(cliente.Enderecos);

            


            //Caso o dgvEnderecos tenha linhas, aparecerá um aviso abaixo do grid de clientes
            if (dgvEnderecos.Rows.Count != 0)
            {
                lblAvisoContent.Visible = true;
            }
            else
            {
                lblAvisoContent.Visible = false;
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = new(int.Parse(txtId.Text)); //fornece o id do cliente para o frm de endereco
            frmNovoEndereco.Show();

            //Ideia: ao fechar o frm de endereco, o dgv de enderecos é atualizado

            //Ocorre se o usuario apertar o botão de cancelar no dgv de endereco
            //if (frmNovoEndereco.ShowDialog() == DialogResult.Cancel)
            //{
            //    //Apaga as linhas do dgv
            //    dgvEnderecos.Rows.Clear();
            //    //Atualiza o grid após o fechamento do frmNovoEndereco
            //    CarregaGridEnderecos(Endereco.ListarPorClienteId(int.Parse(txtId.Text))); 
            //}
        }

        private void dgvEnderecosPorCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvEnderecos.CurrentRow.Index;
            int id = Convert.ToInt32(dgvEnderecos.Rows[linhaAtual].Cells[0].Value); //pega o id do endereco atravé do dgv
            var endereco = Endereco.ConsultarPorId(id);
            FrmNovoEndereco frmNovoEndereco = new(endereco); //fornece o objeto endereco para o frm de endereco
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

        //Torna o cliente inativo
        private void btnArquivar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Arquivar(cliente.Id);
            if (cliente.Ativo == false)
            {
                CarregaGridClientes();
                MessageBox.Show("Cliente arquivado com sucesso");
            }
        }

        //Tira todas as informações dos textbox e grid de enderecos
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            dgvEnderecos.Rows.Clear(); //Apaga os enderecos do dgvEnderecos
            lblAvisoContent.Visible = false; //Deixa o aviso do dgvEndereco invisivel
            btnInserir.Enabled = true;
        }
    }
}
