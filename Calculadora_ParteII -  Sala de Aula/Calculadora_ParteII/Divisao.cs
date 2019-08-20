using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ParteII
{
    class Divisao
    {
        public static void Calculo_Divisao(double valor1, double valor2)
        {
            double Resultado;
            Resultado = valor1 / valor2;
            EntradaSaida.LimpaSaida();
            Console.WriteLine("A divisão é: {0}", Resultado);
        }
    }
}
