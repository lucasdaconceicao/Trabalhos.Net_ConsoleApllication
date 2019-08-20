using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ParteII
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            EntradaSaida.Imprimnir(">>>> Projeto com 2 Classes Estaticas <<<<<");

            while (true)
            {
                String op = EntradaSaida.LerOpcao(Console.ReadLine());

                if (op.Equals("S") || op.Equals("s"))
                {
                    break;
                }

                EntradaSaida.Imprimnir("Digite o Primeiro Número : ");
                double valor1 = EntradaSaida.LerTeclado(Console.ReadLine());

                EntradaSaida.Imprimnir("Digite o Segundo Número : ");
                double valor2 = EntradaSaida.LerTeclado(Console.ReadLine());

                EntradaSaida.Imprimnir("Escolha a Operação [+] [-] [*] [/] ->");
                op = EntradaSaida.LerOpcao(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        EntradaSaida.LimpaSaida();
                        Soma.Calculo_Soma(valor1, valor2);
                        break;
                    case "-":
                        EntradaSaida.LimpaSaida();
                        Subtracao.Calculo_Subtracao(valor1, valor2);
                        break;
                    case "*":
                        EntradaSaida.LimpaSaida();
                        Multiplicacao.Calculo_Multiplicao(valor1, valor2);
                        break;
                    case "/":
                        EntradaSaida.LimpaSaida();
                        Divisao.Calculo_Divisao(valor1, valor2);
                        break;
                    default:
                        EntradaSaida.LimpaSaida();
                        Console.WriteLine("Operação Inválida.");
                        break;
                }
            }
        }
    }
}
