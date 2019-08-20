using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> listaVeiculo = new List<Veiculo>();
            bool menu = true;
            int id = 0, cod = 0;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Controle de Estacionamento Rotativo ");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1-  Registar Entrada ");
                Console.WriteLine("2-  Registrar Saída ");
                Console.WriteLine("3-  Exibir Faturamento ");
                Console.WriteLine("4-  Mostrar Veículos Estacionados ");
                Console.WriteLine("5-  Sair ");
                Console.WriteLine("Opcao desejada: ");
                Console.WriteLine("");
                string op = Console.ReadLine();

                Automovel automovel = new Automovel();
                Motocicleta motocicleta = new Motocicleta();

                switch (op)
                {
                    case "1":
                        Cadastro(listaVeiculo, automovel, motocicleta);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Digite a placa do veiculo: ");
                        cod = Convert.ToInt32(Console.ReadLine());
                        Veiculo selecionaDados = ListaVeiculos(listaVeiculo, cod);
                        Console.Clear();
                        Console.WriteLine("Placa do veiculo: ");
                        Console.WriteLine(selecionaDados.Placa);
                        Console.WriteLine("Hora de entrada: ");
                        Console.WriteLine(selecionaDados.HoraEntrada.ToLongTimeString());
                        selecionaDados.HoraSaida = DateTime.Now;
                        Console.WriteLine("Hora de saida: ");
                        Console.WriteLine(selecionaDados.HoraSaida.ToLongTimeString());
                        TimeSpan permanencia = selecionaDados.HoraSaida - selecionaDados.HoraEntrada;
                        int horas = Convert.ToInt32(permanencia.Hours);
                        int minutos = Convert.ToInt32(permanencia.Minutes);
                        double total = calculoPermanecia(horas, minutos);
                        selecionaDados.Total = total;
                        Console.WriteLine("R$: " + total.ToString());
                        Console.ReadKey();

                        for (int i = 0; i < listaVeiculo.Count; i++)
                        {
                            if (listaVeiculo[i].Placa == cod)
                            {
                                listaVeiculo[i] = selecionaDados;
                            }
                        }

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite a placa do veiculo: ");
                        cod = Convert.ToInt32(Console.ReadLine());
                        Veiculo seleciona = ListaVeiculos(listaVeiculo, cod);
                        foreach (var item in listaVeiculo)
                        {
                            if (item.Placa == cod)
                            {
                                Console.WriteLine("R$ " + seleciona.Total);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        foreach (var item in listaVeiculo)
                        {
                            Console.Write(item.Proprietario + "  ");
                            Console.ReadKey();
                        }

                        break;
                    case "5":
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

        private static void Cadastro(List<Veiculo> listaVeiculo, Automovel automovel, Motocicleta motocicleta)
        {
            Console.Clear();
            Console.WriteLine("Registro de Entrada de veiculos ");
            Console.Write("Tipo de veículo <1- Carro; 2-Moto> escolha um numero: ");
            Console.WriteLine("");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.Clear();
                Console.WriteLine("Dados do Automóvel ");
                Console.WriteLine("Digite os dados da placa <xxx-9999>: ");
                automovel.Placa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Digite a cor do carro: ");
                automovel.Cor = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Digite o nome do proprietario: ");
                automovel.Proprietario = Console.ReadLine();
                Console.WriteLine("Automovel Registrado com Sucesso!! ");
                Console.ReadKey();
                automovel.HoraEntrada = DateTime.Now;
                Console.WriteLine("");
                listaVeiculo.Add(automovel);
            }

            else if(escolha == "2")
            {
                Console.Clear();
                Console.WriteLine("Dados da Motocicleta ");
                Console.WriteLine("Digite os dados da placa <xxx-9999>: ");
                motocicleta.Placa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Digite a cor da moto: ");
                motocicleta.Cor = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Digite o nome do proprietario: ");
                motocicleta.Proprietario = Console.ReadLine();
                Console.WriteLine("Motocicleta Registrada com Sucesso!! ");
                Console.ReadKey();
                motocicleta.HoraEntrada = DateTime.Now;
                Console.WriteLine("");
                listaVeiculo.Add(motocicleta);
            }
        }
        private static Veiculo ListaVeiculos(List<Veiculo> listaVeiculo, int cod)
        {
            foreach (var item in listaVeiculo)
            {
                if (item.Placa == cod)
                {
                    return item;
                }
            }
            return null;
        }
        private static double calculoPermanecia(int horas, int minutos)
        {
            double total = 0;
            if (horas > 0)
            {
                total += horas * 60;
            }

            if (minutos > 0)
            {
                total += minutos;
            }
            return total;
        }

    }
}


