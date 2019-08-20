using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CadastroFilmesSeries
{
    class Excluir_Banco_Dados
    {
        private string conexaoString = "Server=localhost;Port=3306;Database=ENTRETENIMENTO;Uid=administrator;Pwd=1234;";
        public void ExcluirDadosFilmes()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome a ser apagado:");
                String nome = Console.ReadLine();
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query = "DELETE FROM FILMES WHERE NOME=?NOME;";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", nome);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("filme Apagado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExcluirDadosSeries()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome a ser apagado:");
                String nome = Console.ReadLine();
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query = "DELETE FROM SERIES WHERE NOME=?NOME";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", nome);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Série apagada com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}