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
    public partial class BdConfig : Form
    {
        public BdConfig()
        {
            InitializeComponent();
        }
        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            Connection.AlterUserAndPassword(textBox1.Text, txtSenha.Text);

            MessageBox.Show("Configurações Atualizadas");
            this.Hide();
            form.Update();
        }

        private void BdConfig_Load(object sender, EventArgs e)
        {
            string[] user = Utilitarios.GetText(@"bd.txt", 2);
            textBox1.Text = user[0];
            txtSenha.Text = user[1];
        }
    }
}
