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
using static System.Windows.Forms.LinkLabel;

namespace SysTINSApp
{
    public partial class FrmNiveis : Form
    {
        public FrmNiveis()
        {
            InitializeComponent();
        }

        private void FrmNiveis_Load(object sender, EventArgs e)
        {
            CarregaGridNiveis();
        }

        private void CarregaGridNiveis()
        {
            dgvNiveis.Rows.Clear();
            List<Nivel> niveis = Nivel.ObterLista();
            int linha = 0;
            foreach (var nivel in niveis)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = nivel.Id;
                dgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;
                linha++;
            }
        }

        private void dgvNiveis_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvNiveis.CurrentRow.Index;
            var idNivel = Convert.ToInt32(dgvNiveis.Rows[linhaAtual].Cells[0].Value);
            var nivel = Nivel.ObterPorID(idNivel);
            txtId.Text = nivel.Id.ToString();
            txtNome.Text = nivel.Nome;
            txtSigla.Text = nivel.Sigla;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Nivel nivel = new(
                              txtNome.Text,
                              txtSigla.Text
                              );
            nivel.Inserir();
            if (nivel.Id > 0)
            {
                MessageBox.Show("Nivel adicionado com sucesso");
            }
            CarregaGridNiveis();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new();
            nivel.Id = Convert.ToInt32(txtId.Text);
            nivel.Nome = txtNome.Text;
            nivel.Sigla = txtSigla.Text;
            if (nivel.Atualizar())
            {
                CarregaGridNiveis();
                MessageBox.Show("Nivel atualizado com sucesso");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new();
            nivel.Id = Convert.ToInt32(txtId.Text);
            nivel.Excluir();
            CarregaGridNiveis();
        }
    }
}
