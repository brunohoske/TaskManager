using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace TaskManager
{
    internal static class Connection
    {

        static MySqlDataReader reader;
        static MySqlConnection connection;
        static DataTable dt;
        static MySqlDataAdapter da;

        static string user = "";
        static string pwd = "";

        static string conn = $"server=localhost;user={user};pwd={pwd};database=taskmanager; Allow User Variables=True";


        public static bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static int ExecutarComando(string sql)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return 1;

                }
                else
                {
                    return 2;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
            finally
            {
                CloseConnection();
            }

        }
        public static MySqlDataReader ExecuteCommandReader(string sql, MySqlDataReader read)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                read = cmd.ExecuteReader();
                return read;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }



        }
        public static string[] GetUsuarios()
        {
            List<string> usuarios = new List<string>();
            try
            {
                OpenConnection();
                reader = ExecuteCommandReader("Select username from usuarios;", reader);
                while (reader.Read())
                {
                    usuarios.Add(reader["Username"].ToString());
                }
                reader.Close();
                return usuarios.ToArray();

            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }

        }
        public static string GetIdUser(string usuario)
        {
            string id = "";
            try
            {
                OpenConnection();
                reader = ExecuteCommandReader($"Select id from usuarios where username = '{usuario}';", reader);


                while (reader.Read())
                {
                    id = reader["id"].ToString();
                }
                reader.Close();
                return id;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static string GetUsername(string id)
        {
            try
            {
                string username = "";
                OpenConnection();
                reader = ExecuteCommandReader($"Select username from usuarios where id = '{id}';", reader);

                while (reader.Read())
                {
                    username = reader["username"].ToString();
                }
                reader.Close();
                return username;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static string GetName(string id)
        {
            try
            {
                string name = "";
                OpenConnection();
                reader = ExecuteCommandReader($"Select nome from usuarios where id = '{id}';", reader);

                while (reader.Read())
                {
                    name = reader["nome"].ToString();
                }
                reader.Close();
                return name;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static string GetEmail(string id)
        {
            try
            {
                string email = "";
                OpenConnection();
                reader = ExecuteCommandReader($"Select email from usuarios where id = '{id}';", reader);

                while (reader.Read())
                {
                    email = reader["email"].ToString();
                }
                reader.Close();
                return email;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static string GetSenha(string id)
        {
            try
            {
                string senha = "";
                OpenConnection();
                reader = ExecuteCommandReader($"Select senha from usuarios where id = '{id}';", reader);

                while (reader.Read())
                {
                    senha = reader["senha"].ToString();
                }
                reader.Close();
                return senha;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static int ValidaUsuario(string usuario)
        {
            try
            {
                List<string> user = new List<string>();
                OpenConnection();
                reader = ExecuteCommandReader($"Select username from usuarios where username = '{usuario}';", reader);
                while (reader.Read())
                {
                    user.Add(reader["username"].ToString());
                }
                reader.Close();
                if (user.Count == 1)
                {
                    return 1;
                }
                else if (user.Count == 0) { return 0; }
                else { return -1; }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
        public static string ValidaSenha(string userId)
        {
            try
            {

                OpenConnection();
                reader = ExecuteCommandReader($"Select senha from usuarios where id = {userId}", reader);
                string senha = "";

                while (reader.Read())
                {
                    senha = reader["senha"].ToString();
                }
                reader.Close();
                return senha;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {

                CloseConnection();
            }
        }
        public static DataTable ExibirTarefas(int userId)
        {
            try
            {

                if (OpenConnection())
                {
                    string sql = $"SELECT * FROM TAREFAS where userId = {userId}";
                    da = new MySqlDataAdapter(sql, conn);
                    dt = new DataTable();

                    da.Fill(dt);
                    return dt;
                }
                else { return null; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void AlterUser(string usuario)
        {
            conn = $"server=localhost;user={usuario};pwd={pwd};database=taskmanager; Allow User Variables=True";
            Utilitarios.SaveText(@"bd.txt", usuario);
        }
        public static void AlterPassword(string password)
        {
            conn = $"server=localhost;user={user};pwd={password};database=taskmanager; Allow User Variables=True";
            Utilitarios.SaveText(@"bd.txt", password);


        }
        public static void AlterUserAndPassword(string usuario, string password)
        {
            conn = $"server=localhost;user={usuario};pwd={password};database=taskmanager; Allow User Variables=True";
            Utilitarios.SaveText(@"bd.txt",usuario,password);
        }

        public static string GetUserBd()
        {
            return user;
        }

        public static string GetPwdBd()
        {
            return pwd;
        }

    }
}

