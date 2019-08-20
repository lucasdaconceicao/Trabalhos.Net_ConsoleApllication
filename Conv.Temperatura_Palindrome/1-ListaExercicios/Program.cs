using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha um numero: ");
                Console.WriteLine("1-  Palindromo");
                Console.WriteLine("2-  Sair");
                Console.WriteLine("");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        VerificarPalavra();
                        break;
                    case "2":
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
        //verifica se a palavra é palindromo
        private static void VerificarPalavra()
        {
            Console.Clear();
            Console.Write("Digite a palavra: ");
            string palavra = Console.ReadLine();
            string auxPalavra = "";
            if (palavra != "")
            {
                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    auxPalavra += palavra[i];
                }

                Console.WriteLine(auxPalavra);
                if (auxPalavra.ToLower() == palavra.ToLower())
                {
                    Console.WriteLine("Palindromo ");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Palavra Comum ");
                    Console.ReadKey();
                }
            }
        }
    }
}
