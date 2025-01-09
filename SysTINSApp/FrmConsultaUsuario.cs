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
    public partial class FrmConsultaUsuario : Form
    {
        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void CarregaGridConsulta()
        {
            dgvConsultaUsuario.Rows.Clear();
            List<Usuario> usuarios = new();
            usuarios = Usuario.ObterLista();
            int linha = 0;
            foreach (var usuario in usuarios)
            {
                dgvConsultaUsuario.Rows.Add();
                dgvConsultaUsuario.Rows[linha].Cells[0].Value = usuario.Id;
                dgvConsultaUsuario.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvConsultaUsuario.Rows[linha].Cells[3].Value = usuario.Email;
                dgvConsultaUsuario.Rows[linha].Cells[4].Value = usuario.Senha;
                dgvConsultaUsuario.Rows[linha].Cells[5].Value = usuario.Nivel.Nome;
                dgvConsultaUsuario.Rows[linha].Cells[6].Value = usuario.Ativo;
                linha++;
            }
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            CarregaGridConsulta();
        }
    }
}
