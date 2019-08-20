using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroFilmesSeries
{
    class Alterar_Banco_Dados
    {
        private string conexaoString = "Server=localhost;Port=3306;Database=ENTRETENIMENTO;Uid=administrator;Pwd=1234;";
        public void AlterarDadosFilmes()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome para ser alterado:");
                string nomeAlterar = Console.ReadLine();
                if (String.IsNullOrEmpty(nomeAlterar))
                {
                    return;
                }
                Filmes filme = new Filmes();
                Console.WriteLine("Digite o novo nome do filme:");
                filme.Nome = Console.ReadLine();
                Console.WriteLine("Digite a classificação do filme:");
                filme.Classificacao = Console.ReadLine();
                Console.WriteLine("Digite a duração do filme:");
                filme.Duracao = Console.ReadLine();
                Console.WriteLine("Digite o nome do diretor do filme:");
                filme.Diretor = Console.ReadLine();
                Console.WriteLine("Digite o nome do estúdio do filme:");
                filme.Estudio = Console.ReadLine();
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query = "UPDATE FILMES SET NOME = ?NOME, CLASSIFICACAO = ?CLASSIFICACAO, DURACAO = ?DURACAO, DIRETOR = ?DIRETOR, ESTUDIO = ?ESTUDIO WHERE NOME = ?nomeAlterar;";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", filme.Nome);
                    comando.Parameters.AddWithValue("?CLASSIFICACAO", filme.Classificacao);
                    comando.Parameters.AddWithValue("?DURACAO", filme.Duracao);
                    comando.Parameters.AddWithValue("?DIRETOR", filme.Diretor);
                    comando.Parameters.AddWithValue("?ESTUDIO", filme.Estudio);
                    comando.Parameters.AddWithValue("?nomeAlterar", nomeAlterar);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("filme alterado com sucesso!");
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
        public void AlterarDadosSeries()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Console.WriteLine("Digite o nome para ser alterado:");
                string nomeAlterar = Console.ReadLine();
                if (String.IsNullOrEmpty(nomeAlterar))
                {
                    return;
                }
                Series serie = new Series();
                Console.WriteLine("Digite o nome da série:");
                serie.Nome = Console.ReadLine();
                Console.WriteLine("Digite a classificação da série:");
                serie.Classificacao = Console.ReadLine();
                Console.WriteLine("Digite a duração da série:");
                serie.Duracao = Console.ReadLine();
                Console.WriteLine("Digite o nome do diretor da série:");
                serie.Diretor = Console.ReadLine();
                Console.WriteLine("Digite o nome do estúdio da série:");
                serie.Estudio = Console.ReadLine();
                Console.WriteLine("Digite quantidade de temporadas:");
                serie.Temporadas = Console.ReadLine();
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conexao.CreateCommand();
                    string query= "UPDATE SERIES SET NOME = ?NOME, CLASSIFICACAO = ?CLASSIFICACAO, DURACAO = ?DURACAO, DIRETOR = ?DIRETOR, ESTUDIO = ?ESTUDIO, TEMPORADAS= ?TEMPORADAS WHERE NOME = ?nomeAlterar;";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", serie.Nome);
                    comando.Parameters.AddWithValue("?CLASSIFICACAO", serie.Classificacao);
                    comando.Parameters.AddWithValue("?DURACAO", serie.Duracao);
                    comando.Parameters.AddWithValue("?DIRETOR", serie.Diretor);
                    comando.Parameters.AddWithValue("?ESTUDIO", serie.Estudio);
                    comando.Parameters.AddWithValue("?TEMPORADAS", serie.Temporadas);
                    comando.Parameters.AddWithValue("?nomeAlterar", nomeAlterar);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Série alterada com sucesso!");
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
