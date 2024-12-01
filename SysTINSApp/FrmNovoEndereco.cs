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
        public FrmNovoEndereco()
        {
            InitializeComponent();
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
            }
            else
            {
                MessageBox.Show("Falha ao adicionar o endereço");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = this;
            frmNovoEndereco.Close();
        }
    }
}
