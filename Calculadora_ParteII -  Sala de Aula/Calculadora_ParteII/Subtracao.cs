using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ParteII
{
    class Subtracao
    {
        public static void Calculo_Subtracao(double valor1, double valor2)
        {
            double Resultado;
            Resultado = valor1 - valor2;
            EntradaSaida.LimpaSaida();
            Console.WriteLine("A subtração é: {0}", Resultado);
        }
    }
}
