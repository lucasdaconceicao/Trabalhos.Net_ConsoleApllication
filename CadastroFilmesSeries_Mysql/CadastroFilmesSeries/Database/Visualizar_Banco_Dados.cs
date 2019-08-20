using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace CadastroFilmesSeries
{
    class Visualizar_Banco_Dados
    {
        private string conexaoString = "Server=localhost;Port=3306;Database=ENTRETENIMENTO;Uid=administrator;Pwd=1234;";
        public void VisualizarDadosFilmes()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome a ser pesquisado:");
                string nomePesquisa = Console.ReadLine();

                MySqlDataReader MysqlReader = null;
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query = "SELECT*FROM FILMES WHERE NOME LIKE '%" + nomePesquisa + "%';";
                    comando.CommandText = query;

                    MysqlReader = comando.ExecuteReader();

                    if (MysqlReader.HasRows == false)
                    {
                        Console.WriteLine("Nao existe nenhum dado!");
                        return;
                    }

                    Console.Clear();
                    while (MysqlReader.Read())
                    {
                        string[] valores = new string[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i).ToString();
                            //Console.WriteLine("Dados:");
                            Console.Write(valores[i] + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //fechando a conexao com o banco de dados
                conexao.Close();
            }
        }
        public void VisualizarDadosSeries()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome a ser pesquisado:");
                string nomePesquisa = Console.ReadLine();

                MySqlDataReader MysqlReader = null;
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query = "SELECT*FROM SERIES WHERE NOME LIKE '%" + nomePesquisa + "%';";
                    comando.CommandText = query;

                    MysqlReader = comando.ExecuteReader();

                    if (MysqlReader.HasRows == false)
                    {
                        Console.WriteLine("Nao existe nenhum dado!");
                        return;
                    }

                    Console.Clear();
                    while (MysqlReader.Read())
                    {
                        string[] valores = new string[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i).ToString();
                            //Console.WriteLine("Dados:");
                            Console.Write(valores[i] + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //fechando a conexao com o banco de dados
                conexao.Close();
            }
        }
    }
}
