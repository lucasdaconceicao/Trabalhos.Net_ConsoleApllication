using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    class EntradaSaida
    {
        public static void legenda()
        {
            Console.Clear();
            Console.WriteLine("Escolha um numero: ");
            Console.WriteLine("1-  Celsius para Kelvin");
            Console.WriteLine("2-  Celsius para Farenheit");
            Console.WriteLine("3-  Kelvin para Celsius");
            Console.WriteLine("4-  Kelvin para Farenheit");
            Console.WriteLine("5-  Farenheit para Celsius");
            Console.WriteLine("6-  Farenheit para Kelvin");
            Console.WriteLine("7-  Sair");
            Console.WriteLine("");
        }

        public static string lerTransformacao( string op)
        {
            return op = Console.ReadLine();
        }

        public static double lerTemperatura(double valor)
        {
            Console.Write("Digite a temperatura: ");
            return valor = Convert.ToDouble(Console.ReadLine());
        }

        public static double CelsiusParaKelvin(double valor)
        {
            return valor + 273;
        }

        public static double CelsiusParaFarenheit(double valor)
        {
            return (valor * 1.8) + 32;
        }

        public static double KelvinParaCelsius(double valor)
        {
            return valor = Convert.ToDouble(Console.ReadLine());
        }

        public static double KelvinParaFarenheit(double valor)
        {
            return valor - 273;
        }

        public static double FarenheitParaCelsius(double valor)
        {
            return (valor - 32) / 1.8;
        }

        public static double FarenheitParaKelvin(double valor)
        {
            return (valor - 32) / 1.8 + 273.15; 
        }
    }
}
