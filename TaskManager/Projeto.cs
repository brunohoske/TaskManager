using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager;

namespace TaskManager
{
    internal class Tarefa
    {
        public string NomeTarefa {  get; set; }
        public string Descricao {  get; set; }
        public string DataIni { get; set; }
        public string DataFim { get; set; }
        
        public int UserID { get; private set; }

        public Tarefa() { }

        public Tarefa(string nomeTarefa)
        {
            NomeTarefa = nomeTarefa;
        }

        public Tarefa(string nomeTarefa, string descricao) : this(nomeTarefa)
        {
            Descricao = descricao;
        }

        public Tarefa(string nomeTarefa, string descricao, string dataIni, string dataFim) : this(nomeTarefa,descricao)
        {
            DataIni = dataIni;
            DataFim = dataFim;
        }


        public bool CriarTarefa(Tarefa tarefa)
        {
            if(Connection.ExecutarComando($"INSERT INTO TAREFAS VALUES(DEFAULT,'{tarefa.NomeTarefa}','{tarefa.DataIni}','{tarefa.DataFim}','{tarefa.Descricao}',{User.Id})") == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
