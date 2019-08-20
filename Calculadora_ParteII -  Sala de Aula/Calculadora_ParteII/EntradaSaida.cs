using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ParteII
{
    public static class EntradaSaida
    {

        public static void Imprimnir(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ImprimnirLn(String texto)
        {
            Console.WriteLine(texto);
        }

        public static Double LerTeclado(String texto)
        {
            return Convert.ToDouble(texto);
        }

        public static String LerOpcao(String texto)
        {
            return texto;
        }

        public static void LimpaSaida()
        {
            Console.Clear();
        }
    }
}
