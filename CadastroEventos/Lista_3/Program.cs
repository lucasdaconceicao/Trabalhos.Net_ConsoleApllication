using Lista_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GERENCIAMENTO";
            List<Eventos> listaEventos = new List<Eventos>();
            bool menu = true;
            string nome = "";
            DateTime dataMin, dataMax;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("CONTROLE DE EVENTOS ");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1-  Registrar Eventos/Alterar Eventos ");
                Console.WriteLine("2-  Exibir Eventos ");
                Console.WriteLine("3-  Excluir Eventos ");
                Console.WriteLine("4-  Sair ");
                Console.WriteLine("Opcao desejada: ");
                Console.WriteLine("");
                string op = Console.ReadLine();
                Eventos evento = new Eventos();
                switch (op)
                {
                    case "1":
                        Cadastro(listaEventos, evento);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Busca por Periodo ");
                        Console.WriteLine("Digite uma Data Mínima: ");
                        dataMin = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Digite uma Data Máxima: ");
                        dataMax = Convert.ToDateTime(Console.ReadLine());
                        Console.Clear();

                        foreach (var item in listaEventos)
                        {
                            if (item.Data >= dataMin.Date && item.Data <= dataMax.Date)
                            {
                                SelecionaDados(item);
                            }
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o nome do Evento: ");
                        nome = Console.ReadLine();
                        Eventos itemEvento = RetornaEventos(listaEventos, nome);
                        listaEventos.Remove(itemEvento);
                        Console.WriteLine("Evento removido com sucesso");
                        Console.ReadKey();
                        break;
                    case "4":
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

        private static void Cadastro(List<Eventos> listaEventos, Eventos evento)
        {
            Console.Clear();
            Console.WriteLine("Registro de Entrada de Eventos ");
            Console.WriteLine("O que deseja fazer? <1- Registrar; 2-Alterar> escolha um numero: ");
            Console.WriteLine("");
            string escolha = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Titulo do Evento: ");
            evento.Titulo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a Data do Evento: ");
            evento.Data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a Hora Inicial: ");
            evento.HoraInicial = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a Hora Final: ");
            evento.HoraFinal = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite uma Descricao: ");
            evento.Descricao = Console.ReadLine();
            Console.WriteLine("");
            if (escolha == "1")
            {
                listaEventos.Add(evento);
                Console.WriteLine("Evento Registrado com Sucesso!! ");
                Console.ReadKey();
            }

            else if (escolha == "2")
            {
                for (int i = 0; i < listaEventos.Count; i++)
                {
                    if (listaEventos[i].Titulo == evento.Titulo)
                    {
                        listaEventos[i] = evento;
                    }
                }
                Console.WriteLine("Evento Alterado com Sucesso!! ");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Digite um numero válido ou revise o título se esta correto!! ");
                Console.ReadKey();
            }
        }

        private static Eventos RetornaEventos(List<Eventos> listaEventos, string nome)
        {
            foreach (var item in listaEventos)
            {
                if (item.Titulo == nome)
                {
                    return item;
                }
            }
            return null;
        }

        private static void SelecionaDados(Eventos seleciona)
        {
            Console.WriteLine("Titulo do Evento: ");
            Console.WriteLine(seleciona.Titulo);
            Console.WriteLine("");
            Console.WriteLine("Data: ");
            Console.WriteLine(seleciona.Data.ToLongDateString());
            Console.WriteLine("");
            Console.WriteLine("Hora Inicial: ");
            Console.WriteLine(seleciona.HoraInicial.ToLongTimeString());
            Console.WriteLine("");
            Console.WriteLine("Hora Final: ");
            Console.WriteLine(seleciona.HoraFinal.ToLongTimeString());
            Console.WriteLine("");
            Console.WriteLine("Descricao: ");
            Console.WriteLine(seleciona.Descricao);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
