using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager;

namespace TaskManager
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private bool ValidaCampos()
        {
            if(txtNome.Text != "" && txtEmail.Text != "" && txtSenha.Text != "" && txtSenhaConfirm.Text != "" && txtUser.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Connection.ValidaUsuario(txtUser.Text) == 0 && txtSenha.Text == txtSenhaConfirm.Text && ValidaCampos())
            {
                User user = new User(txtNome.Text, txtUser.Text, txtSenha.Text, txtEmail.Text);
                if (user.CriarUsuario(user) == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                }
                else 
                {
                   if(Connection.ValidaUsuario(txtUser.Text) == 0)
                   {
                        MessageBox.Show("Confira os valores digitados");
                   }
                }
            }
            else
            {
                MessageBox.Show("Confira os valores digitados");
            }
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

    }
}
