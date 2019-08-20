using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controleGerente, controleCaixa, controleVendedor;
            bool menu = true;

            Gerentes[] listaGerentes = new Gerentes[100];
            Caixas[] listaCaixas = new Caixas[100];
            Vendedores[] listaVendedores = new Vendedores[100];

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha um numero: ");
                Console.WriteLine("1-  Cadastro");
                Console.WriteLine("2-  Listar");
                Console.WriteLine("3-  Sair");
                Console.WriteLine("");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Gerentes gerente = new Gerentes();
                        Caixas caixa = new Caixas();
                        Vendedores vendedor = new Vendedores();
                        string escolha = Legenda();

                        if (escolha == "1")
                        {
                            //cadastro
                            CadastroGerente(gerente);

                            //controle de cadastro
                            controleGerente = Gerentes.cadastrarGerentes(listaGerentes, gerente);

                            if (controleGerente)
                            {
                                Console.WriteLine("Gerente Cadastrado");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.WriteLine("Erro no Cadastro");
                                Console.ReadKey();
                            }
                        }

                        else if (escolha == "2")
                        {

                            CadastroCaixa(caixa);
                            controleCaixa = Caixas.cadastrarCaixas(listaCaixas, caixa);

                            if (controleCaixa)
                            {
                                Console.WriteLine("Caixa Cadastrado");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.WriteLine("Erro no Cadastro");
                                Console.ReadKey();
                            }
                        }

                        else if (escolha == "3")
                        {

                            CadastroVendedor(vendedor);
                            controleVendedor = Vendedores.cadastrarvendedor(listaVendedores, vendedor);

                            if (controleVendedor)
                            {
                                Console.WriteLine("Vendedor Cadastrado");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.WriteLine("Erro no Cadastro");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Escolha um numero válido! ");
                            Console.ReadKey();
                        }

                        break;
                    case "2":
                        string escolhaNome;
                        string lista = Legenda();
                        if (lista == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um Nomes: ");
                            escolhaNome = Console.ReadLine();
                            Console.Clear();
                            Gerentes selecionar = Gerentes.buscarGerentes(listaGerentes, escolhaNome);
                            selecionaDadosGerente(selecionar);
                            Console.ReadKey();
                        }

                        else if (lista == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um dos Nomes: ");
                            escolhaNome = Console.ReadLine();
                            Console.Clear();
                            Caixas selecionar = Caixas.buscarCaixas(listaCaixas, escolhaNome);
                            selecionaDadosCaixa(selecionar);
                            Console.ReadKey();
                        }
                        else if (lista == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um dos Nomes");
                            escolhaNome = Console.ReadLine();
                            Console.Clear();
                            Vendedores selecionar = Vendedores.buscarVendedores(listaVendedores, escolhaNome);
                            selecionaDadosVendedor(selecionar);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Escolha um numero válido! ");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        menu = false;
                        Console.Write("\n");
                        break;
                    default:
                        Console.Write("\n");
                        Console.WriteLine("Digite um numero válido! ");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //metodo para selecionar dados
        private static void selecionaDadosGerente(Gerentes selecionar)
        {
            Console.WriteLine("Nome: ");
            Console.WriteLine(selecionar.Nome);
            Console.WriteLine("");
            Console.WriteLine("Comissao: ");
            Console.WriteLine(selecionar.Comissao);
            Console.WriteLine("");
            Console.WriteLine("Data de Nascimento: ");
            Console.WriteLine(selecionar.DataNascimento);
            Console.WriteLine("");
            Console.WriteLine("Qntd filhos: ");
            Console.WriteLine(selecionar.QuantidadeFilhos);
            Console.WriteLine("");
            Console.WriteLine("Salario base: ");
            Console.WriteLine(selecionar.SalarioBase);
            Console.WriteLine("");
            Console.WriteLine("Salario com comissao: ");
            Console.WriteLine(selecionar.SalarioComissao);
        }

        private static void selecionaDadosCaixa(Caixas selecionar)
        {
            Console.WriteLine(selecionar.Nome);
            Console.WriteLine("");
            Console.WriteLine(selecionar.Comissao);
            Console.WriteLine("");
            Console.WriteLine(selecionar.DataNascimento);
            Console.WriteLine("");
            Console.WriteLine(selecionar.QuantidadeFilhos);
            Console.WriteLine("");
            Console.WriteLine(selecionar.SalarioBase);
            Console.WriteLine("");
            Console.WriteLine(selecionar.SalarioComissao);
        }

        private static void selecionaDadosVendedor(Vendedores selecionar)
        {
            Console.WriteLine(selecionar.Nome);
            Console.WriteLine("");
            Console.WriteLine(selecionar.Comissao);
            Console.WriteLine("");
            Console.WriteLine(selecionar.DataNascimento);
            Console.WriteLine("");
            Console.WriteLine(selecionar.QuantidadeFilhos);
            Console.WriteLine("");
            Console.WriteLine(selecionar.SalarioBase);
            Console.WriteLine("");
            Console.WriteLine(selecionar.SalarioComissao);
        }

        private static string Legenda()
        {
            Console.Clear();
            Console.WriteLine("Escolha um numero: ");
            Console.WriteLine("1-  Gerentes");
            Console.WriteLine("2-  Caixas");
            Console.WriteLine("3-  Vendedores");
            Console.WriteLine("");
            string escolha = Console.ReadLine();
            return escolha;
        }

        //metodo para cadastro
        private static void CadastroGerente(Gerentes gerente)
        {
            Console.Clear();
            Console.WriteLine("Digite o Nome: ");
            gerente.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Comissao Ex.:50: ");
            gerente.Comissao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a Data de Nascimento: ");
            gerente.DataNascimento = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Quantidade de filhos: ");
            gerente.QuantidadeFilhos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Salario: ");
            gerente.SalarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            gerente.SalarioComissao = gerente.calculoComissao(gerente.Comissao, gerente.SalarioBase);
        }

        private static void CadastroCaixa(Caixas caixa)
        {
            Console.Clear();
            Console.WriteLine("Digite o Nome: ");
            caixa.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Comissao Ex.:50: ");
            caixa.Comissao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a Data de Nascimento: ");
            caixa.DataNascimento = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Quantidade de filhos: ");
            caixa.QuantidadeFilhos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Salario: ");
            caixa.SalarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            caixa.SalarioComissao = caixa.calculoComissao(caixa.Comissao, caixa.SalarioBase);
        }

        private static void CadastroVendedor(Vendedores vendedor)
        {
            Console.Clear();
            Console.WriteLine("Digite o Nome: ");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Comissao Ex.:50: ");
            vendedor.Comissao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a Data de Nascimento: ");
            vendedor.DataNascimento = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Quantidade de filhos: ");
            vendedor.QuantidadeFilhos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Salario: ");
            vendedor.SalarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            vendedor.SalarioComissao = vendedor.calculoComissao(vendedor.Comissao, vendedor.SalarioBase);
        }

    }
}
