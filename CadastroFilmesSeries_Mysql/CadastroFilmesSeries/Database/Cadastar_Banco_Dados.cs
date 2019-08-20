using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroFilmesSeries
{
    class Cadastar_Banco_Dados
    {
        private string conexaoString = "Server=localhost;Port=3306;Database=ENTRETENIMENTO;Uid=administrator;Pwd=1234;";
        public void InserirDadosFilmes()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
                Filmes filme = new Filmes();
                Console.WriteLine("Digite o nome do filme:");
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
                    string query = "INSERT INTO FILMES(NOME,CLASSIFICACAO,DURACAO,DIRETOR,ESTUDIO) VALUES (?NOME,?CLASSIFICACAO,?DURACAO,?DIRETOR,?ESTUDIO);";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", filme.Nome);
                    comando.Parameters.AddWithValue("?CLASSIFICACAO", filme.Classificacao);
                    comando.Parameters.AddWithValue("?DURACAO", filme.Duracao);
                    comando.Parameters.AddWithValue("?DIRETOR", filme.Diretor);
                    comando.Parameters.AddWithValue("?ESTUDIO", filme.Estudio);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("filme cadastrado com sucesso!");
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

        public void InserirDadosSeries()
        {
            Console.Clear();
            MySqlConnection conexao = new MySqlConnection(this.conexaoString);
            try
            {
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
                    string query = "INSERT INTO SERIES(NOME,CLASSIFICACAO,DURACAO,DIRETOR,ESTUDIO,TEMPORADAS) VALUES (?NOME,?CLASSIFICACAO,?DURACAO,?DIRETOR,?ESTUDIO,?TEMPORADAS);";
                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("?NOME", serie.Nome);
                    comando.Parameters.AddWithValue("?CLASSIFICACAO", serie.Classificacao);
                    comando.Parameters.AddWithValue("?DURACAO", serie.Duracao);
                    comando.Parameters.AddWithValue("?DIRETOR", serie.Diretor);
                    comando.Parameters.AddWithValue("?ESTUDIO", serie.Estudio);
                    comando.Parameters.AddWithValue("?TEMPORADAS", serie.Temporadas);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("série cadastrada com sucesso!");
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
