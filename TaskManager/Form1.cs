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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utilitarios.CreateTextFile("file");
            Utilitarios.CreateTextFile("bd","root");
           
            string[] usuario = Utilitarios.GetText(@"file.txt", 2);
            string[] userBanco = Utilitarios.GetText(@"bd.txt", 2); 

            if (usuario != null)
            {
                txtUser.Text = usuario[0];
                txtSenha.Text = usuario[1];
            }
            if(userBanco != null)
            {
                Connection.AlterUserAndPassword(userBanco[0], userBanco[1]);
            }
        }

        private bool ValidaCampos()
        {
            if(txtUser.Text != "" && txtSenha.Text != "")
            {
                return true;
            }
            else { return false; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection.ExecutarComando("CREATE SCHEMA IF NOT EXISTS `taskmanager` DEFAULT CHARACTER SET utf8 ;");
            Connection.ExecutarComando("CREATE TABLE IF NOT EXISTS `taskmanager`.`Usuarios` (`ID` INT NOT NULL AUTO_INCREMENT,`Username` VARCHAR(45) NOT NULL,  `Nome` VARCHAR(80) NOT NULL, `Email` VARCHAR(80) NOT NULL, `Senha` VARCHAR(45) NOT NULL,  PRIMARY KEY (`ID`));");
            Connection.ExecutarComando("CREATE TABLE IF NOT EXISTS `taskmanager`.`Tarefas` (  `ID` INT NOT NULL AUTO_INCREMENT,  `NomeTarefa` VARCHAR(20) NOT NULL,  `DataInicio` DATETIME NOT NULL, `DataFim` DATETIME NOT NULL,  `Descricao` VARCHAR(300) NOT NULL,  `UserID` INT NOT NULL,  PRIMARY KEY (`ID`), INDEX `fk_Tarefas_Usuarios_idx` (`UserID` ASC) );");


            if (Connection.ValidaUsuario(txtUser.Text) == 1 && ValidaCampos())
            {
                string userID = Connection.GetIdUser(txtUser.Text);
                if (txtSenha.Text == Connection.ValidaSenha(userID) && userID != "")
                {
                    User.Id = Connection.GetIdUser(txtUser.Text);
                    Menu menu = new Menu();

                    if (cbSaveUser.Checked)
                    {
                        Utilitarios.ClearFileText(@"file.txt");
                        Utilitarios.SaveText(@"file.txt",txtUser.Text, txtSenha.Text);
                    }
                   
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario/senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("Usuario/senha incorretos");
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
        private void btnConfigBD_Click(object sender, EventArgs e)
        {
            BdConfig form = new BdConfig();
            form.Show();

        }
    }
}
