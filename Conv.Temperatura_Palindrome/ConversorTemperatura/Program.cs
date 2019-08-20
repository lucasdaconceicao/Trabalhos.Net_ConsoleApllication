using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            double valor = 0;
            double resultado = 0;

            bool menu = true;
            while (menu)
            {
                EntradaSaida.legenda();
                op = EntradaSaida.lerTransformacao(op);
                if (op == "7")
                {
                    Console.Write("\n");
                    break;
                }


                switch (op)
                {
                    case "1":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.CelsiusParaKelvin(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.CelsiusParaFarenheit(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.KelvinParaCelsius(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.KelvinParaFarenheit(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.FarenheitParaCelsius(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        valor = EntradaSaida.lerTemperatura(valor);
                        resultado = EntradaSaida.FarenheitParaKelvin(valor);
                        Console.WriteLine("Tempratura é: " + resultado);
                        Console.ReadKey();
                        break;
                    case "7":
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


    }
}
