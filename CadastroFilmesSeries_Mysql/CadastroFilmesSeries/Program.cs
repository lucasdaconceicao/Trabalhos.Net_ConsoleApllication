using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmesSeries
{
    class Program
    {
        private static int numeroEscolhido;
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    Console.Clear();
                    Console.Title = "Gerenciar Filmes e Series";
                    Menu.tela();
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            Cadastar_Banco_Dados cadastrar = new Cadastar_Banco_Dados();
                            Console.Title = "Cadastrar Filmes e Series";
                            Console.WriteLine("1-Filmes");
                            Console.WriteLine("2-Series");
                            Console.WriteLine("Digite o numero:");
                            numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                            if (numeroEscolhido == 1)
                            {
                                cadastrar.InserirDadosFilmes();
                                Console.ReadKey();
                            }
                            else if (numeroEscolhido == 2)
                            {
                                cadastrar.InserirDadosSeries();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Digite um numero correto!");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Visualizar_Banco_Dados visualizar = new Visualizar_Banco_Dados();
                            Console.Title = "Visualizar Filmes e Series";
                            Console.WriteLine("1-Filmes");
                            Console.WriteLine("2-Series");
                            Console.WriteLine("Digite o numero:");
                            numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                            if (numeroEscolhido == 1)
                            {
                                visualizar.VisualizarDadosFilmes();
                                Console.ReadKey();
                            }
                            else if (numeroEscolhido == 2)
                            {
                                visualizar.VisualizarDadosSeries();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Digite um numero correto!");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Alterar_Banco_Dados alterar = new Alterar_Banco_Dados();
                            Console.Title = "Alterar Filmes e Series";
                            Console.WriteLine("1-Filmes");
                            Console.WriteLine("2-Series");
                            Console.WriteLine("Digite o numero:");
                            numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                            if (numeroEscolhido == 1)
                            {
                                alterar.AlterarDadosFilmes();
                                Console.ReadKey();
                            }
                            else if (numeroEscolhido == 2)
                            {
                                alterar.AlterarDadosSeries();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Digite um numero correto!");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Excluir_Banco_Dados excluir = new Excluir_Banco_Dados();
                            Console.Title = "Excluir Filmes e Series";
                            Console.WriteLine("1-Filmes");
                            Console.WriteLine("2-Series");
                            Console.WriteLine("Digite o numero:");
                            numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                            if (numeroEscolhido == 1)
                            {
                                excluir.ExcluirDadosFilmes();
                                Console.ReadKey();
                            }
                            else if (numeroEscolhido == 2)
                            {
                                excluir.ExcluirDadosSeries();
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Digite um numero correto!");
                            }
                            break;
                        case 5:
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Digite um numero válido..");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
