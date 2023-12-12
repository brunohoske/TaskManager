using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManager
{
    internal class User
    {

        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

        public static string Id { get;  set; }

        public User() { Id = Connection.GetIdUser(Username); }
        public User(string nome) : this()
        {
            Nome = nome;
            Id = Connection.GetIdUser(Username);
        }
        public User(string nome, string username) : this(nome)
        {
            Username = username;
            Id = Connection.GetIdUser(Username);

        }
        public User(string nome, string username, string password) : this(nome, username)
        {
            Password = password;
            Id = Connection.GetIdUser(Username);
        }
        public User(string nome, string username, string password, string email) : this(nome, username, password)
        {
            Email = email;
            Id = Connection.GetIdUser(Username);
        }

        public int CriarUsuario(User user)
        {
            if (Connection.ExecutarComando($"INSERT INTO USUARIOS VALUES (DEFAULT,'{user.Username}','{user.Nome}','{user.Email}','{user.Password}')") == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static int AtualizarCadastro(string nome, string username, string email, string id)
        {
            if (Connection.ExecutarComando($"UPDATE USUARIOS SET NOME = '{nome}', username = '{username}',email = '{email}' where id = {id} ") == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int AtualizarSenha(string novaSenha, string id)
        {
            if (Connection.ExecutarComando($"UPDATE USUARIOS SET SENHA = '{novaSenha}' where id = {id} ") == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
