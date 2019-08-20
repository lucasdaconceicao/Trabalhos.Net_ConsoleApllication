using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Caixas:Funcionarios
    {
        public static bool cadastrarCaixas(Caixas[] listarCaixas, Caixas cadastro)
        {
            for (int i = 0; i < listarCaixas.Length; i++)
            {
                if (listarCaixas[i] == null)
                {
                    listarCaixas[i] = cadastro;
                    return true;
                }
            }
            return false;
        }
        public static Caixas buscarCaixas(Caixas[] listarCaixas, string nome)
        {
            for (int i = 0; i < listarCaixas.Length; i++)
            {
                if (listarCaixas[i].Nome == nome)
                {
                    return listarCaixas[i];
                }
            }
            return null;
        }
    }
}
