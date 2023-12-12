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

            Connection.ExecutarComando("CREATE SCHEMA IF NOT EXISTS `taskmanager` DEFAULT CHARACTER SET utf8 ;");
            Connection.ExecutarComando("CREATE TABLE IF NOT EXISTS `taskmanager`.`Usuarios` (`ID` INT NOT NULL AUTO_INCREMENT,`Username` VARCHAR(45) NOT NULL,  `Nome` VARCHAR(80) NOT NULL, `Email` VARCHAR(80) NOT NULL, `Senha` VARCHAR(45) NOT NULL,  PRIMARY KEY (`ID`));");
            Connection.ExecutarComando("CREATE TABLE IF NOT EXISTS `taskmanager`.`Tarefas` (  `ID` INT NOT NULL AUTO_INCREMENT,  `NomeTarefa` VARCHAR(20) NOT NULL,  `DataInicio` DATETIME NOT NULL, `DataFim` DATETIME NOT NULL,  `Descricao` VARCHAR(300) NOT NULL,  `UserID` INT NOT NULL,  PRIMARY KEY (`ID`), INDEX `fk_Tarefas_Usuarios_idx` (`UserID` ASC) );");


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
