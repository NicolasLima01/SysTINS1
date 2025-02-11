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
    public partial class FrmNovoEndereco : Form
    {

        public int? ClienteId { get; set; }//Propriedade para pegar o id do cliente no FrmNovoCiente  
        public Endereco? Endereco { get; set; }// Propriedade para pegar o id do endereco no dgvEnderecos

        public FrmNovoEndereco()
        {
            InitializeComponent();
        }

        //Construtor para receber o id do cliente
        public FrmNovoEndereco(int IdCliente)
        {
            ClienteId = IdCliente;
            InitializeComponent();
        }

        //Construtor feito para o ContentClick do dgvEnderecos
        public FrmNovoEndereco(Endereco endereco)
        {
            InitializeComponent();
            Endereco = endereco;
        }

        private void FrmNovoEndereco_Load(object sender, EventArgs e)
        {
            //Ocorre se a propriedade de ClienteId é entregue
            if (ClienteId > 0)
            {
                txtClienteId.Text = Convert.ToString(ClienteId);
            }

            //Ocorre se a propriedade de Endereco é entregue
            if (Endereco != null)
            {
                txtId.Text = Convert.ToString(Endereco.Id);
                txtClienteId.Text = Convert.ToString(Endereco.Cliente.Id);
                txtCep.Text = Endereco.CEP;
                txtLogradouro.Text = Endereco.Logradouro;
                txtNumero.Text = Endereco.Numero;
                txtComplemento.Text = Endereco.Complemento;
                txtBairro.Text = Endereco.Bairro;
                txtCidade.Text = Endereco.Cidade;
                cmbUf.SelectedItem = Endereco.UF;
                cmbTipoEndereco.SelectedItem = Endereco.Tipo_endereco;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                               Cliente.ConsultarPorId(Convert.ToInt32(txtClienteId.Text)),
                               txtCep.Text,
                               txtLogradouro.Text,
                               txtNumero.Text,
                               txtComplemento.Text,
                               txtBairro.Text,
                               txtCidade.Text,
                               Convert.ToString(cmbUf.SelectedItem),
                               Convert.ToString(cmbTipoEndereco.SelectedItem)
                               );
            endereco.Inserir();
            if (endereco.Cliente.Id > 0)
            {
                MessageBox.Show($"Endereço adicionado com sucesso");
                btnAdicionar.Enabled = false;
                txtId.Text = "";
                txtClienteId.Text = "";
                txtCep.Text = "";
                txtLogradouro.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                cmbUf.SelectedItem = "";
                cmbTipoEndereco.SelectedItem = "";
            }
            else
            {
                MessageBox.Show("Falha ao adicionar o endereço");
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Endereco endereco = new();
            endereco.Id = Convert.ToInt32(txtId.Text);
            endereco.CEP = txtCep.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.UF = Convert.ToString(cmbUf.SelectedItem);
            endereco.Tipo_endereco = Convert.ToString(cmbTipoEndereco.SelectedItem);
            if (endereco.Atualizar())
            {
                MessageBox.Show("Endereco atualizado com sucesso");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();
            endereco.Id = Convert.ToInt32(txtId.Text);
            endereco.Excluir(endereco.Id);            
        }     
    }
}
