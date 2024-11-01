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
            //FrmLogin frmLogin = new();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
            //    Show();
            //}
            //else
            //    Application.Exit();
            Show();
        }

        private void novoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); //cria uma instância (objeto) do FrmUsuarios
            frmUsuarios.MdiParent = this; //associa esta instancia ao container (MDI) FrmPrincipal
            frmUsuarios.Show(); //Exibe o form Usuarios na janela do sistema
        }
    }
}
