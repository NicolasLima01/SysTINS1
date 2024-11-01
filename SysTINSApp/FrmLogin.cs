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
    public partial class FrmLogin : Form
    {
        int tentativa = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //colocar a validação do login       
            var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuario.Id > 0) 
            {
                //Caso o login obteve sucesso
                Program.UsuarioLogado = usuario;
                this.DialogResult = DialogResult.OK;
                Close();               
            }
            else
            {
                tentativa++;
                if (tentativa < 3)
                {
                    lblMensagem.Text = $"Usuário e/ou senha inválidos \n Restam {tentativa + 1}/3 tentativas ";
                }
                else
                {
                    lblMensagem.Text = "Número de tentativas de login excedido!";
                    this.DialogResult = DialogResult.No;
                    Close();
                }
            }
            //Usuario usuario = new();
            //usuario.Email = ;
            //usuario.Senha = ;
            //var login = EfetuarLogin(usuario.Email, usuario.Senha);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
