using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Gerentes : Funcionarios
    {
        public static bool cadastrarGerentes(Gerentes[] listarGerentes, Gerentes cadastro)
        {
            for (int i = 0; i < listarGerentes.Length; i++)
            {
                if (listarGerentes[i] == null)
                {
                    listarGerentes[i] = cadastro;
                    return true;
                }
            }
            return false;
        }
        public static Gerentes buscarGerentes(Gerentes[] listarGerentes,string nome)
        {
            for (int i = 0; i < listarGerentes.Length; i++)
            {
                if (listarGerentes[i].Nome == nome)
                {
                    return listarGerentes[i];
                }
            }
            return null;
        }
    }
}

  
