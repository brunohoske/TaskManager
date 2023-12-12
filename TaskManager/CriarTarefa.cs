using Org.BouncyCastle.Asn1.X509;
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
    public partial class CriarTarefa : Form
    {
        public CriarTarefa()
        {
            InitializeComponent();
        }
        private bool ValidaCampos()
        {
            if(txtNomeTarefa.Text != "" && dtInico.Text != "" && dtTermino.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string InverterData(DateTimePicker dtp)
        {
            string[] arrayStr = dtp.Text.Split('/');
            string str2 = arrayStr[2] + "-" + arrayStr[1] + "-" + arrayStr[0];
            return str2;
        }
        private string ToDataTime(DateTimePicker dtp, DateTimePicker dtt)
        {

            string data = InverterData(dtp);
            string time = dtt.Text;
            string result = $"{data} {time}";
            return result;
        }
        private void LimpaCampos()
        {
            txtNomeTarefa.Clear();
            txtDescricao.Clear();
            dtInico.Text = DateTime.Now.ToString();
            dtTimeInicio.Text = DateTime.Now.ToString();
            dtTermino.Text = DateTime.Now.ToString();
            dtTimeFim.Text = DateTime.Now.ToString();
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (dtInico.Value < dtTermino.Value)
                {
                    Tarefa tarefa = new Tarefa(txtNomeTarefa.Text, txtDescricao.Text, ToDataTime(dtInico, dtTimeInicio), ToDataTime(dtTermino, dtTimeFim));
                    if (tarefa.CriarTarefa(tarefa))
                    {
                        MessageBox.Show("Tarefa Criada com sucesso");
                        LimpaCampos();
                    }
                    else
                    {
                        MessageBox.Show("Confira os valores digitados");
                    }
                }
                else
                {
                    MessageBox.Show("Data inical não pode ser maior que data final");
                }
                
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }
        }
    }
}
