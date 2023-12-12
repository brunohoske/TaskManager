using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        string id;
        string username = Connection.GetUsername(User.Id);
        string nome = Connection.GetName(User.Id);
        string email = Connection.GetEmail(User.Id);
        string pwd = Connection.GetSenha(User.Id);

        private void Menu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Boas vindas {nome}";
            lblUsername.Text = "@" + username;
            
        }

        private void AtualizaDados()
        {
            username = Connection.GetUsername(User.Id);
            nome = Connection.GetName(User.Id);
            email = Connection.GetEmail(User.Id);
            pwd = Connection.GetSenha(User.Id);
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            CriarTarefa ct = new CriarTarefa();
            ct.Show();
        }
        private void tabControlMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage tabPageSelected = (sender as TabControl).SelectedTab;

            if(tabPageSelected == tpTarefas)
            {
                DataTable dt = Connection.ExibirTarefas(int.Parse(User.Id));
                dtgTarefas.DataSource = dt.AsDataView();

                dtgTarefas.Columns[0].Visible = false;
                dtgTarefas.Columns[1].HeaderText = "Nome";
                dtgTarefas.Columns[2].HeaderText = "Data inicial";
                dtgTarefas.Columns[3].HeaderText = "Data final";
                dtgTarefas.Columns[4].HeaderText = "Descrição";
                dtgTarefas.Columns[5].Visible = false;

                dtgTarefas.Columns[1].Width = dtgTarefas.Width / 5;
                dtgTarefas.Columns[2].Width = dtgTarefas.Width / 5;
                dtgTarefas.Columns[3].Width = dtgTarefas.Width / 5;
                dtgTarefas.Columns[4].Width = dtgTarefas.Width / 3;




            }
            else if(tabPageSelected == tpConfig)
            {
                AtualizaDados();
                txtNome.Text = nome;
                txtUsername.Text = username;
                txtEmail.Text = email;

            }
            else if(tabPageSelected == tpMenu)
            {
                AtualizaDados();
                lblWelcome.Text = $"Boas vindas {nome}";
                lblUsername.Text = "@" + username;
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(User.AtualizarCadastro(txtNome.Text,txtUsername.Text,txtEmail.Text,User.Id) == 1)
            {
                MessageBox.Show("Cadastro Atualizado");
            }
            else
            {
                MessageBox.Show("Cadastro não atualizado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if(Connection.GetSenha(User.Id) == txtSenha.Text)
            {
                if (txtNovaSenha.Text == txtConfirmarNovaSenha.Text)
                {
                    User.AtualizarSenha(txtNovaSenha.Text, User.Id);
                    MessageBox.Show("Senha alterada com sucesso");
                }
                else
                {
                    MessageBox.Show("Senhas não conferem");
                }
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
           
        }

        private void btnMinhasTarefas_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }
        private void dtgTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtgTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(Connection.ExecutarComando($"delete from tarefas where id = {id}") == 1)
            {
                MessageBox.Show("Tarefa apagada com sucesso");
                DataTable dt = Connection.ExibirTarefas(int.Parse(User.Id));
                dtgTarefas.DataSource = dt.AsDataView();
            }
           
        }
    }
}
